using System;
using UnityEngine;
using General.Typescript;
using System.Collections;

namespace General
{
	public class Behaviour : MonoBehaviour
	{
		private CustomType mType = null;

		public string Name { get { return mType.Name; } }
		public string FullName { get { return string.Concat(CustomType.CUSTOM_PREFIX, ".", mType.Name); } }
		
		private Instance mPersistent = null;

		private Coroutine mUpdateCoroutine = null;

		private void Start()
		{
			if (mPersistent.HasFunction("Start"))
			{
				mPersistent.CallFunction("Start");
			}
		}

		internal void SetType(CustomType type)
		{
			mType = type;
		}

		new public Type GetType()
		{
			return mType;
		}

		private void initialize()
		{
			if (null == mPersistent) return;

			if (mPersistent.HasFunction("Update") && null == mUpdateCoroutine)
			{
				mUpdateCoroutine = this.StartCoroutine(this.update());
			}
		}

		internal void SetPersistentHandle(IntPtr persistent)
		{
			mPersistent = new Instance(persistent);
			this.initialize();
		}

		private IEnumerator update()
		{
			while (true)
			{
				yield return new WaitForEndOfFrame();
				mPersistent.CallFunction("Update");
			}
		}

		private void OnDestroy()
		{
			this.StopAllCoroutines();
			if (null != mPersistent)
			{
				if (mPersistent.HasFunction("OnDestroy"))
				{
					mPersistent.CallFunction("OnDestroy");
				}
				mPersistent = null;
			}
		}
	}
}