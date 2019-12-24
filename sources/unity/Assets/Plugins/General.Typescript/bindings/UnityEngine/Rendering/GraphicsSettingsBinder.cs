using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingGraphicsSettings
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Rendering.GraphicsSettings> self = space.DeclareClass<UnityEngine.Rendering.GraphicsSettings, UnityEngine.Object>();
			self.BindConstructor();
			self.BindStaticFunction("GetCustomShader", GetCustomShader);
			self.BindStaticFunction("GetShaderMode", GetShaderMode);
			self.BindStaticFunction("HasShaderDefine", HasShaderDefine);
			self.BindStaticFunction("SetCustomShader", SetCustomShader);
			self.BindStaticFunction("SetShaderMode", SetShaderMode);
			self.BindStaticProperty("transparencySortMode", get_transparencySortMode, set_transparencySortMode);
			self.BindStaticProperty("transparencySortAxis", get_transparencySortAxis, set_transparencySortAxis);
			self.BindStaticProperty("lightsUseLinearIntensity", get_lightsUseLinearIntensity, set_lightsUseLinearIntensity);
			self.BindStaticProperty("lightsUseColorTemperature", get_lightsUseColorTemperature, set_lightsUseColorTemperature);
			self.BindStaticProperty("useScriptableRenderPipelineBatching", get_useScriptableRenderPipelineBatching, set_useScriptableRenderPipelineBatching);
			self.BindStaticProperty("logWhenShaderIsCompiled", get_logWhenShaderIsCompiled, set_logWhenShaderIsCompiled);
			self.BindStaticProperty("renderPipelineAsset", get_renderPipelineAsset, set_renderPipelineAsset);
		}

		static private UnityEngine.Shader GetCustomShader(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.BuiltinShaderType>())
			{
				return UnityEngine.Rendering.GraphicsSettings.GetCustomShader(parameters[0].ToObject<UnityEngine.Rendering.BuiltinShaderType>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.GraphicsSettings.GetCustomShader has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.GraphicsSettings.GetCustomShader has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private UnityEngine.Rendering.BuiltinShaderMode GetShaderMode(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.BuiltinShaderType>())
			{
				return UnityEngine.Rendering.GraphicsSettings.GetShaderMode(parameters[0].ToObject<UnityEngine.Rendering.BuiltinShaderType>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.GraphicsSettings.GetShaderMode has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.GraphicsSettings.GetShaderMode has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Rendering.BuiltinShaderMode);
		}

		static private System.Boolean HasShaderDefine(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.BuiltinShaderDefine>())
			{
				return UnityEngine.Rendering.GraphicsSettings.HasShaderDefine(parameters[0].ToObject<UnityEngine.Rendering.BuiltinShaderDefine>());
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.GraphicsTier, UnityEngine.Rendering.BuiltinShaderDefine>())
			{
				return UnityEngine.Rendering.GraphicsSettings.HasShaderDefine(parameters[0].ToObject<UnityEngine.Rendering.GraphicsTier>(), parameters[1].ToObject<UnityEngine.Rendering.BuiltinShaderDefine>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.GraphicsSettings.HasShaderDefine has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.GraphicsSettings.HasShaderDefine has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void SetCustomShader(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.BuiltinShaderType, UnityEngine.Shader>())
			{
				UnityEngine.Rendering.GraphicsSettings.SetCustomShader(parameters[0].ToObject<UnityEngine.Rendering.BuiltinShaderType>(), parameters[1].ToObject<UnityEngine.Shader>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.GraphicsSettings.SetCustomShader has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.GraphicsSettings.SetCustomShader has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetShaderMode(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.BuiltinShaderType, UnityEngine.Rendering.BuiltinShaderMode>())
			{
				UnityEngine.Rendering.GraphicsSettings.SetShaderMode(parameters[0].ToObject<UnityEngine.Rendering.BuiltinShaderType>(), parameters[1].ToObject<UnityEngine.Rendering.BuiltinShaderMode>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.GraphicsSettings.SetShaderMode has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.GraphicsSettings.SetShaderMode has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.TransparencySortMode get_transparencySortMode(Type type, string name)
		{
			return UnityEngine.Rendering.GraphicsSettings.transparencySortMode;
		}

		static private void set_transparencySortMode(Type type, string name, UnityEngine.TransparencySortMode value)
		{
			UnityEngine.Rendering.GraphicsSettings.transparencySortMode = value;
		}

		static private UnityEngine.Vector3 get_transparencySortAxis(Type type, string name)
		{
			return UnityEngine.Rendering.GraphicsSettings.transparencySortAxis;
		}

		static private void set_transparencySortAxis(Type type, string name, UnityEngine.Vector3 value)
		{
			UnityEngine.Rendering.GraphicsSettings.transparencySortAxis = value;
		}

		static private System.Boolean get_lightsUseLinearIntensity(Type type, string name)
		{
			return UnityEngine.Rendering.GraphicsSettings.lightsUseLinearIntensity;
		}

		static private void set_lightsUseLinearIntensity(Type type, string name, System.Boolean value)
		{
			UnityEngine.Rendering.GraphicsSettings.lightsUseLinearIntensity = value;
		}

		static private System.Boolean get_lightsUseColorTemperature(Type type, string name)
		{
			return UnityEngine.Rendering.GraphicsSettings.lightsUseColorTemperature;
		}

		static private void set_lightsUseColorTemperature(Type type, string name, System.Boolean value)
		{
			UnityEngine.Rendering.GraphicsSettings.lightsUseColorTemperature = value;
		}

		static private System.Boolean get_useScriptableRenderPipelineBatching(Type type, string name)
		{
			return UnityEngine.Rendering.GraphicsSettings.useScriptableRenderPipelineBatching;
		}

		static private void set_useScriptableRenderPipelineBatching(Type type, string name, System.Boolean value)
		{
			UnityEngine.Rendering.GraphicsSettings.useScriptableRenderPipelineBatching = value;
		}

		static private System.Boolean get_logWhenShaderIsCompiled(Type type, string name)
		{
			return UnityEngine.Rendering.GraphicsSettings.logWhenShaderIsCompiled;
		}

		static private void set_logWhenShaderIsCompiled(Type type, string name, System.Boolean value)
		{
			UnityEngine.Rendering.GraphicsSettings.logWhenShaderIsCompiled = value;
		}

		static private UnityEngine.Experimental.Rendering.RenderPipelineAsset get_renderPipelineAsset(Type type, string name)
		{
			return UnityEngine.Rendering.GraphicsSettings.renderPipelineAsset;
		}

		static private void set_renderPipelineAsset(Type type, string name, UnityEngine.Experimental.Rendering.RenderPipelineAsset value)
		{
			UnityEngine.Rendering.GraphicsSettings.renderPipelineAsset = value;
		}

	}
}
