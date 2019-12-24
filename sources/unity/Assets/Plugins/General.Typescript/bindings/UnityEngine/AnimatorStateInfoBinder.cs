using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimatorStateInfo
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.AnimatorStateInfo> self = space.DeclareClass<UnityEngine.AnimatorStateInfo>();
			self.BindConstructor();
			self.BindInstanceFunction("IsName", IsName);
			self.BindInstanceFunction("IsTag", IsTag);
			self.BindInstanceProperty("fullPathHash", get_fullPathHash, null);
			self.BindInstanceProperty("shortNameHash", get_shortNameHash, null);
			self.BindInstanceProperty("normalizedTime", get_normalizedTime, null);
			self.BindInstanceProperty("length", get_length, null);
			self.BindInstanceProperty("speed", get_speed, null);
			self.BindInstanceProperty("speedMultiplier", get_speedMultiplier, null);
			self.BindInstanceProperty("tagHash", get_tagHash, null);
			self.BindInstanceProperty("loop", get_loop, null);
		}

		static private System.Boolean IsName(UnityEngine.AnimatorStateInfo instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.IsName(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AnimatorStateInfo.IsName has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimatorStateInfo.IsName has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean IsTag(UnityEngine.AnimatorStateInfo instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.IsTag(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AnimatorStateInfo.IsTag has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimatorStateInfo.IsTag has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 get_fullPathHash(UnityEngine.AnimatorStateInfo instance, string name)
		{
			return instance.fullPathHash;
		}

		static private System.Int32 get_shortNameHash(UnityEngine.AnimatorStateInfo instance, string name)
		{
			return instance.shortNameHash;
		}

		static private System.Single get_normalizedTime(UnityEngine.AnimatorStateInfo instance, string name)
		{
			return instance.normalizedTime;
		}

		static private System.Single get_length(UnityEngine.AnimatorStateInfo instance, string name)
		{
			return instance.length;
		}

		static private System.Single get_speed(UnityEngine.AnimatorStateInfo instance, string name)
		{
			return instance.speed;
		}

		static private System.Single get_speedMultiplier(UnityEngine.AnimatorStateInfo instance, string name)
		{
			return instance.speedMultiplier;
		}

		static private System.Int32 get_tagHash(UnityEngine.AnimatorStateInfo instance, string name)
		{
			return instance.tagHash;
		}

		static private System.Boolean get_loop(UnityEngine.AnimatorStateInfo instance, string name)
		{
			return instance.loop;
		}

	}
}
