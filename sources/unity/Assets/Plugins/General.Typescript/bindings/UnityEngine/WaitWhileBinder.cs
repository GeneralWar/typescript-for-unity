using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineWaitWhile
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.WaitWhile> self = space.DeclareClass<UnityEngine.WaitWhile>();
			self.BindConstructor();
			self.BindInstanceProperty("keepWaiting", get_keepWaiting, null);
		}

		static private System.Boolean get_keepWaiting(UnityEngine.WaitWhile instance, string name)
		{
			return instance.keepWaiting;
		}

	}
}
