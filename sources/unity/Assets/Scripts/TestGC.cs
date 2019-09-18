using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class TestGC : MonoBehaviour
{
	[SerializeField]
	private SpriteRenderer mRenderer = null;

	private GCHandle mHandler;
	private GCHandle mHandler2;

	private object mInstance = null;
	private object mInstance2 = null;

	private Dictionary<object, GCHandle> mHandlers = new Dictionary<object, GCHandle>();

	private void Start()
	{
		mHandler = GCHandle.Alloc(mRenderer.gameObject, GCHandleType.Weak);
		mHandler2 = GCHandle.Alloc(mRenderer, GCHandleType.Weak);
		mInstance = mRenderer.gameObject;
		mInstance2 = mRenderer;
		mHandlers.Add(mInstance, mHandler);
		mHandlers.Add(mInstance2, mHandler2);
	}

	private void Update()
	{
		Debug.Log(mInstance);
		Debug.Log(mInstance2);
		//Debug.Log(GC.GetTotalMemory(false));
		if (Input.GetMouseButtonDown(0))
		{
			//mHandler.Free();
			if (mRenderer.gameObject)
			{
				GameObject.Destroy(mRenderer.gameObject);
			}
			else
			{
				mRenderer = null;
			}
		}
	}
}
