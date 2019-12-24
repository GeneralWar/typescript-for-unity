using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimatorTransitionInfo
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.AnimatorTransitionInfo> self = space.DeclareClass<UnityEngine.AnimatorTransitionInfo>();
			self.BindConstructor();
			self.BindInstanceFunction("IsName", IsName);
			self.BindInstanceFunction("IsUserName", IsUserName);
			self.BindInstanceProperty("fullPathHash", get_fullPathHash, null);
			self.BindInstanceProperty("nameHash", get_nameHash, null);
			self.BindInstanceProperty("userNameHash", get_userNameHash, null);
			self.BindInstanceProperty("durationUnit", get_durationUnit, null);
			self.BindInstanceProperty("duration", get_duration, null);
			self.BindInstanceProperty("normalizedTime", get_normalizedTime, null);
			self.BindInstanceProperty("anyState", get_anyState, null);
		}

		static private System.Boolean IsName(UnityEngine.AnimatorTransitionInfo instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.IsName(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AnimatorTransitionInfo.IsName has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimatorTransitionInfo.IsName has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean IsUserName(UnityEngine.AnimatorTransitionInfo instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.IsUserName(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AnimatorTransitionInfo.IsUserName has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimatorTransitionInfo.IsUserName has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 get_fullPathHash(UnityEngine.AnimatorTransitionInfo instance, string name)
		{
			return instance.fullPathHash;
		}

		static private System.Int32 get_nameHash(UnityEngine.AnimatorTransitionInfo instance, string name)
		{
			return instance.nameHash;
		}

		static private System.Int32 get_userNameHash(UnityEngine.AnimatorTransitionInfo instance, string name)
		{
			return instance.userNameHash;
		}

		static private UnityEngine.DurationUnit get_durationUnit(UnityEngine.AnimatorTransitionInfo instance, string name)
		{
			return instance.durationUnit;
		}

		static private System.Single get_duration(UnityEngine.AnimatorTransitionInfo instance, string name)
		{
			return instance.duration;
		}

		static private System.Single get_normalizedTime(UnityEngine.AnimatorTransitionInfo instance, string name)
		{
			return instance.normalizedTime;
		}

		static private System.Boolean get_anyState(UnityEngine.AnimatorTransitionInfo instance, string name)
		{
			return instance.anyState;
		}

	}
}
