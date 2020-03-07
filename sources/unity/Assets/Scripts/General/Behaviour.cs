using System;
using UnityEngine;
using General.Typescript;
using System.Collections;

namespace General
{
	public class Behaviour : MonoBehaviour, ICustomSuperClass
	{
		string ICustomSuperClass.TypeFullName { get; set; }

		private JsObject mJsObject = null;

		private Coroutine mUpdateCoroutine = null;

		private void Awake()
		{
			(this as ICustomSuperClass).TypeFullName = Entry.LastCustomType;
		}

		private void Start()
		{
			if (mJsObject.HasFunction("Start"))
			{
				mJsObject.CallFunction("Start");
			}
		}

		void ICustomSuperClass.Initialize()
		{
			if (null == mJsObject) return;

			if (mJsObject.HasFunction("Awake"))
			{
				mJsObject.CallFunction("Awake");
			}

			if (mJsObject.HasFunction("Update") && null == mUpdateCoroutine)
			{
				mUpdateCoroutine = this.StartCoroutine(this.update());
			}
		}

		void ICustomSuperClass.SetJsHandle(IntPtr handle)
		{
			mJsObject = handle;
			Entry.Object.MakePersistent(mJsObject);
		}

		private IEnumerator update()
		{
			while (true)
			{
				yield return new WaitForEndOfFrame();
				mJsObject.CallFunction("Update");
			}
		}

		private void OnDestroy()
		{
			this.StopAllCoroutines();
			if (null != mJsObject)
			{
				if (mJsObject.HasFunction("OnDestroy"))
				{
					mJsObject.CallFunction("OnDestroy");
				}
				Entry.Object.MakeWeak(mJsObject);
				mJsObject = null;
			}
		}
	}
}