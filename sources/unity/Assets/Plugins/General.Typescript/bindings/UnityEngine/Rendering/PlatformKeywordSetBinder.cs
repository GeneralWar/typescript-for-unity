using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingPlatformKeywordSet
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Rendering.PlatformKeywordSet> self = space.DeclareClass<UnityEngine.Rendering.PlatformKeywordSet>();
			self.BindConstructor();
			self.BindInstanceFunction("Disable", Disable);
			self.BindInstanceFunction("Enable", Enable);
			self.BindInstanceFunction("IsEnabled", IsEnabled);
		}

		static private void Disable(UnityEngine.Rendering.PlatformKeywordSet instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.BuiltinShaderDefine>())
			{
				instance.Disable(parameters[0].ToObject<UnityEngine.Rendering.BuiltinShaderDefine>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.PlatformKeywordSet.Disable has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.PlatformKeywordSet.Disable has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Enable(UnityEngine.Rendering.PlatformKeywordSet instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.BuiltinShaderDefine>())
			{
				instance.Enable(parameters[0].ToObject<UnityEngine.Rendering.BuiltinShaderDefine>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.PlatformKeywordSet.Enable has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.PlatformKeywordSet.Enable has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean IsEnabled(UnityEngine.Rendering.PlatformKeywordSet instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.BuiltinShaderDefine>())
			{
				return instance.IsEnabled(parameters[0].ToObject<UnityEngine.Rendering.BuiltinShaderDefine>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.PlatformKeywordSet.IsEnabled has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.PlatformKeywordSet.IsEnabled has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

	}
}
