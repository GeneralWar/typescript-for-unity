using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System;
using AOT;

namespace General.Typescript
{
#if UNITY_ANDROID
 //   public class AndroidEntry : Entry
 //   {
 //       override public bool initialize()
 //       {
 //           return true;
	//	}

	//	protected override void bind(IntPtr handle)
	//	{
	//		throw new NotImplementedException();
	//	}

	//	[MonoPInvokeCallback(typeof(FunctionInt))]
 //       static private int testFunction(int value)
 //       {
 //           Debug.Log("Maybe oc is calling unity function...");
 //           Debug.Log(value.ToString());
 //           return value * 3;
 //       }

 //       override public object executeString(string content)
 //       {
 //           return null;
 //       }

 //       public override Namespace declareNamespace(string name)
 //       {
 //           throw new NotImplementedException();
 //       }

 //       public override Class<T> declareClass<T>(string name)
 //       {
 //           throw new NotImplementedException();
 //       }

	//	public override IntPtr toJSObject<T>(T value)
	//	{
	//		throw new NotImplementedException();
	//	}

 //       public override T fromJSObject<T>(IntPtr handle)
 //       {
 //           throw new NotImplementedException();
 //       }

 //       public override JSValueType getType(IntPtr handle)
 //       {
 //           throw new NotImplementedException();
 //       }
	//}
#endif
}