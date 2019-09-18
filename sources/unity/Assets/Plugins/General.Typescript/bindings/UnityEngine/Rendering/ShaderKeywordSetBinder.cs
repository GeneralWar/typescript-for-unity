using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingShaderKeywordSet
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Rendering.ShaderKeywordSet> self = space.DeclareClass<UnityEngine.Rendering.ShaderKeywordSet>();
			self.BindConstructor();
			self.BindInstanceFunction("Disable", Disable);
			self.BindInstanceFunction("Enable", Enable);
			self.BindInstanceFunction("GetShaderKeywords", GetShaderKeywords);
			self.BindInstanceFunction("IsEnabled", IsEnabled);
		}

		static private void Disable(UnityEngine.Rendering.ShaderKeywordSet instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.ShaderKeyword>())
			{
				instance.Disable(parameters[0].ToObject<UnityEngine.Rendering.ShaderKeyword>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.ShaderKeywordSet.Disable has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.ShaderKeywordSet.Disable has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Enable(UnityEngine.Rendering.ShaderKeywordSet instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.ShaderKeyword>())
			{
				instance.Enable(parameters[0].ToObject<UnityEngine.Rendering.ShaderKeyword>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.ShaderKeywordSet.Enable has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.ShaderKeywordSet.Enable has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Rendering.ShaderKeyword[] GetShaderKeywords(UnityEngine.Rendering.ShaderKeywordSet instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetShaderKeywords();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.ShaderKeywordSet.GetShaderKeywords has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Boolean IsEnabled(UnityEngine.Rendering.ShaderKeywordSet instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.ShaderKeyword>())
			{
				return instance.IsEnabled(parameters[0].ToObject<UnityEngine.Rendering.ShaderKeyword>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.ShaderKeywordSet.IsEnabled has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.ShaderKeywordSet.IsEnabled has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

	}
}
