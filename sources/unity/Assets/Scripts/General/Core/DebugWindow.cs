using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public struct DebugMessage
{
    public string message { get; private set; }
    public string stackTraces { get; private set; }

    public DebugMessage(string message, string stackTraces)
    {
        this.message = message;
        this.stackTraces = stackTraces;
    }
}

public class DebugMessageList
{
    private LogType mType;
    public LogType Type { get { return mType; } }

    private List<DebugMessage> mMessages = new List<DebugMessage>();
    public List<DebugMessage> Messages { get { return mMessages; } }

    private float mFontSize = .0f;
    public float FontSize { get { return mFontSize; } }

    private float mSpaceSize = .0f;
    public float SpaceSize { get { return mSpaceSize; } }

    private float mBottom = .0f;
    public float Bottom { get { return mBottom; } }

    public DebugMessageList(LogType type, float fontSize, float spaceSize)
    {
        mType = type;
        mFontSize = fontSize;
        mSpaceSize = spaceSize;
    }

    public void AddMessage(string message, string stackTraces)
    {
        string format = "{0}";
        switch (mType)
        {
            case LogType.Error:
                format = "<color=#ff0000>{0}</color>";
                break;
            case LogType.Warning:
                format = "<color=#ffff00>{0}</color>";
                break;
        }
        mMessages.Add(new DebugMessage(string.Format(format, message), string.Format(format, stackTraces)));
    }

    public void RemoveMessage(DebugMessage message)
    {
        this.RemoveMessage(message.message, message.stackTraces);
    }

    public void RemoveMessage(string message, string stackTraces)
    {
        mMessages.RemoveAll(m => m.message == message && m.stackTraces == stackTraces);
    }

    public void Clear()
    {
        mMessages.Clear();
    }
}

public class DebugWindow : MonoBehaviour
{
    [SerializeField]
    private GUISkin mGuiSkin = null;
    [SerializeField]
    private bool mVisibleOnAwake = false;

    private DebugMessageList mAllLogMessages = null;
    private Dictionary<LogType, DebugMessageList> mLogMessages = new Dictionary<LogType, DebugMessageList>();
    private int mCurrentType = -1;

    static private bool sVisible = false;
    static public bool Visible { get { return sVisible; } }

    private int mUpTimes = 0;
    private float mUpTime = .0f;

    private int mButtonSpace = 6;
    private int mButtonWidth = 0;
    private int mButtonHeight = 48;

    private int mScrollWidth = 0;
    private int mScrollHeight = 0;

    private Rect mClearPosition = Rect.zero;
    private Rect mClearAllPosition = Rect.zero;

    private Vector2 mScrollPosition = Vector2.zero;

    private Vector3 mScale = Vector3.one;

    private void Awake()
    {
        mScale.x = mScale.y = Screen.width / 960.0f;
        Vector2Int size = new Vector2Int(960, Mathf.RoundToInt(Screen.height / mScale.y));
        mScrollWidth = size.x - mButtonSpace * 2;
        mScrollHeight = size.y - mButtonSpace * 3 - mButtonHeight;
        mButtonWidth = Mathf.FloorToInt((size.x - mButtonSpace * 7) / 4.0f);
        mClearPosition = new Rect(size.x - mButtonHeight * 2 - mButtonSpace * 6, size.y - mButtonHeight + mButtonSpace, mButtonHeight * 2, mButtonHeight - mButtonSpace * 2);
        mClearAllPosition = new Rect(mClearPosition.x - mClearPosition.width - mButtonSpace, mClearPosition.y, mClearPosition.width, mClearPosition.height);

        mAllLogMessages = new DebugMessageList(LogType.Log, mGuiSkin.label.fontSize, 3.1f);
        mLogMessages.Add(LogType.Log, new DebugMessageList(LogType.Log, mGuiSkin.label.fontSize, 3.1f));
        mLogMessages.Add(LogType.Warning, new DebugMessageList(LogType.Warning, mGuiSkin.label.fontSize, 3.1f));
        mLogMessages.Add(LogType.Error, new DebugMessageList(LogType.Error, mGuiSkin.label.fontSize, 3.1f));
        sVisible = this.mVisibleOnAwake;
        if (sVisible)
        {
            mScrollPosition = new Vector2(.0f, float.MaxValue);
        }
    }

    private void Start()
    {
        Application.logMessageReceived += onLog;
        //Application.logMessageReceivedThreaded += onLog;
        Debug.Log("DebugWindow is listening...");
    }

    private void onLog(string condition, string stackTrace, LogType type)
    {
        string format = "{0}";
        if (LogType.Assert == type || LogType.Exception == type)
        {
            type = LogType.Error;
        }
        switch (type)
        {
            case LogType.Error:
                format = "<color=#ff0000>{0}</color>";
                break;
            case LogType.Warning:
                format = "<color=#ffff00>{0}</color>";
                break;
        }
        mAllLogMessages.AddMessage(string.Format(format, condition), string.Format(format, stackTrace));
        mLogMessages[type].AddMessage(condition, stackTrace);
    }

    private void checkClickTime(float time)
    {
        if (.0f == mUpTime)
        {
            ++mUpTimes;
            mUpTime = time;
        }
        else if (time - mUpTime < .3)
        {
            if (++mUpTimes > 5)
            {
                sVisible = !sVisible;
                if (sVisible)
                {
                    mScrollPosition = new Vector2(.0f, float.MaxValue);
                }
                mUpTimes = 0;
            }
            mUpTime = time;
        }
    }

    private void Update()
    {
        float time = Time.time;
#if UNITY_EDITOR || UNITY_STANDALONE
        if (Input.GetMouseButtonUp(0))
        {
            this.checkClickTime(time);
        }
#else
		if (Input.touches.Length > 0 && TouchPhase.Ended == Input.touches[0].phase)
		{
			this.checkClickTime(time);
		}
#endif
        if (time - mUpTime > .5f)
        {
            mUpTime = .0f;
            mUpTimes = 0;
        }
    }

    private void OnGUI()
    {
        if (sVisible)
        {
            GUI.matrix = Matrix4x4.Scale(mScale);

            GUILayout.BeginVertical();
            GUILayout.Space(mButtonSpace);
            GUILayout.BeginHorizontal();
            GUILayout.Space(mButtonSpace);
            if (-1 == mCurrentType)
            {
                GUILayout.Box("All", mGuiSkin.box, GUILayout.Width(mButtonWidth), GUILayout.Height(mButtonHeight));
            }
            else if (GUILayout.Button("<size=24>All</size>", GUILayout.Width(mButtonWidth), GUILayout.Height(mButtonHeight)))
            {
                mCurrentType = -1;
            }
            GUILayout.Space(mButtonSpace);
            if ((int)LogType.Log == mCurrentType)
            {
                GUILayout.Box("Information", mGuiSkin.box, GUILayout.Width(mButtonWidth), GUILayout.Height(mButtonHeight));
            }
            else if (GUILayout.Button("<size=24>Information</size>", GUILayout.Width(mButtonWidth), GUILayout.Height(mButtonHeight)))
            {
                mCurrentType = (int)LogType.Log;
            }
            GUILayout.Space(mButtonSpace);
            if ((int)LogType.Warning == mCurrentType)
            {
                GUILayout.Box("Warning", mGuiSkin.box, GUILayout.Width(mButtonWidth), GUILayout.Height(mButtonHeight));
            }
            else if (GUILayout.Button("<size=24>Warning</size>", GUILayout.Width(mButtonWidth), GUILayout.Height(mButtonHeight)))
            {
                mCurrentType = (int)LogType.Warning;
            }
            GUILayout.Space(mButtonSpace);
            if ((int)LogType.Error == mCurrentType)
            {
                GUILayout.Box("Error", mGuiSkin.box, GUILayout.Width(mButtonWidth), GUILayout.Height(mButtonHeight));
            }
            else if (GUILayout.Button("<size=24>Error</size>", GUILayout.Width(mButtonWidth), GUILayout.Height(mButtonHeight)))
            {
                mCurrentType = (int)LogType.Error;
            }
            GUILayout.Space(mButtonSpace);
            GUILayout.EndHorizontal();
            GUILayout.Space(mButtonSpace);

            mScrollPosition = GUILayout.BeginScrollView(mScrollPosition, false, false, mGuiSkin.verticalScrollbar, mGuiSkin.verticalScrollbar, GUILayout.Width(mScrollWidth), GUILayout.Height(mScrollHeight));
            DebugMessageList list = -1 == mCurrentType ? mAllLogMessages : mLogMessages[(LogType)mCurrentType];
            foreach (DebugMessage message in list.Messages)
            {
                GUILayout.Label(message.message, mGuiSkin.label);
                if (!string.IsNullOrWhiteSpace(message.stackTraces))
                {
                    GUILayout.Label(message.stackTraces, mGuiSkin.label);
                }
            }

            GUILayout.EndScrollView();
            GUILayout.EndVertical();

            if (GUI.Button(mClearAllPosition, "<size=18>ClearAll</size>"))
            {
                this.clearAll();
            }
            if (GUI.Button(mClearPosition, "<size=18>Clear</size>"))
            {
                if (-1 == mCurrentType)
                {
                    this.clearAll();
                }
                else
                {
                    this.clear((LogType)mCurrentType);
                }
            }
        }
    }

    private void clear(LogType type)
    {
        DebugMessageList list = mLogMessages[type];
        foreach (DebugMessage message in list.Messages)
        {
            mAllLogMessages.RemoveMessage(message);
        }
        list.Clear();
    }

    private void clearAll()
    {
        mAllLogMessages.Clear();
        foreach (DebugMessageList list in mLogMessages.Values)
        {
            list.Clear();
        }
    }
}
