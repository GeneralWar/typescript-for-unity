using System;
using System.Collections;
using System.IO;
using System.Net;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class SampleScene : MonoBehaviour
{
	[SerializeField]
	private Button mStartButton = null;

	void Start()
	{
		// To test if release is clear.
		//this.StartCoroutine(this.test());
		//Entry.Initialize();
		//Entry.Release();

		mStartButton.onClick.AddListener(this.onStartClick);
	}

	private void onStartClick()
	{
		if (General.Typescript.Entry.Initialize())
		{
            General.Typescript.Entry.AppendCustomSuperClass(typeof(General.Behaviour));
			General.Typescript.Files.AddSearchPath(Path.Combine(Application.streamingAssetsPath, "Scripts"));
			this.StartCoroutine(this.loadScript("sample-scene"));
		}
	}

	private IEnumerator test()
	{
		int count = 100;
		while (count-- > 0)
		{
			if (General.Typescript.Entry.Initialize())
			{
				General.Typescript.Files.AddSearchPath(Path.Combine(Application.streamingAssetsPath, "Scripts"));
				this.StartCoroutine(this.loadScript("main"));
			}
			yield return new WaitForSeconds(3);
			General.Typescript.Entry.Release();
			yield return new WaitForSeconds(3);
		}
	}

	private IEnumerator loadScript(string filename)
	{
#if UNITY_IPHONE || UNITY_STANDALONE
		string path = "file://" + Path.Combine(Application.streamingAssetsPath, string.Format("Scripts/{0}.gts", filename));
#elif UNITY_ANDROID
		string path = Path.Combine(Application.streamingAssetsPath, string.Format("Scripts/{0}.gts", filename));
#endif
		UnityWebRequest request = UnityWebRequest.Get(path);
		yield return request.SendWebRequest();
		Debug.LogFormat("Result of execution is : {0}", General.Typescript.Entry.ExecuteScript(request.downloadHandler.text, filename + ".js"));
	}
}
