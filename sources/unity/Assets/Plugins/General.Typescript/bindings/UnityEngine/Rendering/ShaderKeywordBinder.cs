using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingShaderKeyword
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Rendering.ShaderKeyword> self = space.DeclareClass<UnityEngine.Rendering.ShaderKeyword>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("GetKeywordName", GetKeywordName);
			self.BindInstanceFunction("GetKeywordType", GetKeywordType);
			self.BindInstanceFunction("IsValid", IsValid);
		}

		static private UnityEngine.Rendering.ShaderKeyword Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return new UnityEngine.Rendering.ShaderKeyword(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.ShaderKeyword.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.ShaderKeyword.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Rendering.ShaderKeyword);
		}

		static private System.String GetKeywordName(UnityEngine.Rendering.ShaderKeyword instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetKeywordName();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.ShaderKeyword.GetKeywordName has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.Rendering.ShaderKeywordType GetKeywordType(UnityEngine.Rendering.ShaderKeyword instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetKeywordType();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.ShaderKeyword.GetKeywordType has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Rendering.ShaderKeywordType);
		}

		static private System.Boolean IsValid(UnityEngine.Rendering.ShaderKeyword instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.IsValid();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.ShaderKeyword.IsValid has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

	}
}
