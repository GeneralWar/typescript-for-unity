using General.Typescript;
using System;
using System.Collections;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class SampleScene : MonoBehaviour
{
    [SerializeField]
    private string mScriptName = string.Empty;
    [SerializeField]
    private Button mStartButton = null;
    [SerializeField]
    private Button mFinishButton = null;

    void Awake()
    {
        FileUtility.ReplaceExtension(".js", ".gts");
    }

    void Start()
    {
        // To test if release is clear.
        //this.StartCoroutine(this.test());
        //Entry.Initialize();
        //Entry.Release();

        mStartButton.onClick.AddListener(this.onStartClick);
        mFinishButton.onClick.AddListener(this.onFinishClick);
    }

    private void onStartClick()
    {
        mFinishButton.interactable = false;
        General.Typescript.FileUtility.AddSearchPath(Path.Combine(Application.streamingAssetsPath, "Scripts"));
        General.Typescript.FileUtility.AddSearchPath(Application.streamingAssetsPath);
        General.Typescript.Entry.AppendBindDelegate(new Action<string>(General.Typescript.BinderUtility.BindFromJson), "typescript/binding-config.json");
        if (General.Typescript.Entry.Initialize())
        {
            General.Typescript.Entry.AppendCustomSuperClass<General.Behaviour>();

            this.StartCoroutine(this.loadScript(mScriptName));
            this.StartCoroutine(this.waitForGC());
        }
    }

    private void onFinishClick()
    {
        General.Typescript.Entry.Release();
    }

    private IEnumerator test()
    {
        int count = 100;
        while (count-- > 0)
        {
            if (General.Typescript.Entry.Initialize())
            {
                General.Typescript.FileUtility.AddSearchPath(Path.Combine(Application.streamingAssetsPath, "Scripts"));
                this.StartCoroutine(this.loadScript("main"));
            }
            yield return new WaitForSeconds(3);
            General.Typescript.Entry.Release();
            yield return new WaitForSeconds(3);
        }
    }

    private IEnumerator loadScript(string filename)
    {
        string content = string.Empty;
#if UNITY_STANDALONE
        try
        {
            content = File.ReadAllText(Path.Combine(Application.streamingAssetsPath, string.Format("Scripts/{0}.gts", filename)));
        }
        catch (Exception e)
        {
            Debug.LogException(e);
        }
        yield return null;
#else
#if UNITY_IPHONE
		string path = "file://" + Path.Combine(Application.streamingAssetsPath, string.Format("Scripts/{0}.gts", filename));
#elif UNITY_ANDROID
		string path = Path.Combine(Application.streamingAssetsPath, string.Format("Scripts/{0}.gts", filename));
#else
        string path = string.Empty;
#endif
        if (!string.IsNullOrWhiteSpace(path))
        {
            UnityWebRequest request = UnityWebRequest.Get(path);
            yield return request.SendWebRequest();
            content = request.downloadHandler.text;
        }
#endif
        Debug.LogFormat("Result of execution is : {0}", General.Typescript.Entry.ExecuteScript(content, filename + ".js"));
    }

    private IEnumerator waitForGC()
    {
        yield return new WaitForSeconds(5);
        Entry.RequestGarbageCollection();
        mFinishButton.interactable = true;
    }
}
