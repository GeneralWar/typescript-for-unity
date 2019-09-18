//using General.Typescript;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AndroidTest : MonoBehaviour
{
	[SerializeField]
	private Text mLabel = null;

	private void Start()
	{
		//try
		//{
		//	Entry.Initialize();
		//	IntPtr handle = Entry.ContextHandle;
		//	mLabel.text = handle.ToInt64().ToString();
		//}
		//catch(Exception e)
		//{
		//	mLabel.text = string.Format("({0})Failed!!!", Entry.ContextHandle.ToInt64().ToString());
		//	Debug.LogException(e);
		//}
	}
}
