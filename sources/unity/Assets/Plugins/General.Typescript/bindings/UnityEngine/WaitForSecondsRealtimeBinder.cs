using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineWaitForSecondsRealtime
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.WaitForSecondsRealtime> self = space.DeclareClass<UnityEngine.WaitForSecondsRealtime>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("waitTime", get_waitTime, set_waitTime);
			self.BindInstanceProperty("keepWaiting", get_keepWaiting, null);
		}

		static private UnityEngine.WaitForSecondsRealtime Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				return new UnityEngine.WaitForSecondsRealtime(parameters[0].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.WaitForSecondsRealtime.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.WaitForSecondsRealtime.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.WaitForSecondsRealtime);
		}

		static private System.Single get_waitTime(UnityEngine.WaitForSecondsRealtime instance)
		{
			return instance.waitTime;
		}

		static private void set_waitTime(UnityEngine.WaitForSecondsRealtime instance, System.Single value)
		{
			instance.waitTime = value;
		}

		static private System.Boolean get_keepWaiting(UnityEngine.WaitForSecondsRealtime instance)
		{
			return instance.keepWaiting;
		}

	}
}
