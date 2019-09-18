using System;
using System.Collections;
using System.IO;
using UnityEngine;

public class SampleScene : MonoBehaviour
{
	void Start()
	{
		// To test if release is clear.
		//this.StartCoroutine(this.test());
		//Entry.Initialize();
		//Entry.Release();

		if (General.Typescript.Entry.Initialize())
		{
            General.Typescript.Entry.AppendCustomSuperClass(typeof(General.Behaviour));
			General.Typescript.Files.AddSearchPath(Path.Combine(Application.streamingAssetsPath, "Scripts"));
			this.StartCoroutine(this.loadScript());
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
				this.StartCoroutine(this.loadScript());
			}
			yield return new WaitForSeconds(3);
			General.Typescript.Entry.Release();
			yield return new WaitForSeconds(3);
		}
	}

	private IEnumerator loadScript()
	{
#if UNITY_IPHONE || UNITY_STANDALONE
		string path = "file://" + Path.Combine(Application.streamingAssetsPath, "Scripts/main.gts");
#elif UNITY_ANDROID
		        string path = Path.Combine(Application.streamingAssetsPath, "Scripts/main.gts");
		        //#elif 
		        //		string path = "file://" + Path.Combine(Application.streamingAssetsPath, "Scripts/main.txt");
#endif
		WWW loader = new WWW(path);
		yield return loader;
		Debug.LogFormat("Result of execution is : {0}", General.Typescript.Entry.ExecuteScript(loader.text, "main.js"));
	}
}
