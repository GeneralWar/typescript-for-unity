using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineWaitUntil
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.WaitUntil> self = space.DeclareClass<UnityEngine.WaitUntil>();
			self.BindConstructor();
			self.BindInstanceProperty("keepWaiting", get_keepWaiting, null);
		}

		static private System.Boolean get_keepWaiting(UnityEngine.WaitUntil instance, string name)
		{
			return instance.keepWaiting;
		}

	}
}
