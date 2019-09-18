using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingRenderTargetIdentifier
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Rendering.RenderTargetIdentifier> self = space.DeclareClass<UnityEngine.Rendering.RenderTargetIdentifier>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindInstanceFunction("ToString", ToString);
		}

		static private UnityEngine.Rendering.RenderTargetIdentifier Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.BuiltinRenderTextureType>())
			{
				return new UnityEngine.Rendering.RenderTargetIdentifier(parameters[0].ToObject<UnityEngine.Rendering.BuiltinRenderTextureType>());
			}
			if (parameters.CheckTypes<System.String>())
			{
				return new UnityEngine.Rendering.RenderTargetIdentifier(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return new UnityEngine.Rendering.RenderTargetIdentifier(parameters[0].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Texture>())
			{
				return new UnityEngine.Rendering.RenderTargetIdentifier(parameters[0].ToObject<UnityEngine.Texture>());
			}
			if (parameters.CheckTypes<System.String, System.Int32, UnityEngine.CubemapFace, System.Int32>())
			{
				return new UnityEngine.Rendering.RenderTargetIdentifier(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.CubemapFace>(), parameters[3].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, UnityEngine.CubemapFace, System.Int32>())
			{
				return new UnityEngine.Rendering.RenderTargetIdentifier(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.CubemapFace>(), parameters[3].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.RenderTargetIdentifier, System.Int32, UnityEngine.CubemapFace, System.Int32>())
			{
				return new UnityEngine.Rendering.RenderTargetIdentifier(parameters[0].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.CubemapFace>(), parameters[3].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Texture, System.Int32, UnityEngine.CubemapFace, System.Int32>())
			{
				return new UnityEngine.Rendering.RenderTargetIdentifier(parameters[0].ToObject<UnityEngine.Texture>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.CubemapFace>(), parameters[3].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.RenderBuffer, System.Int32, UnityEngine.CubemapFace, System.Int32>())
			{
				return new UnityEngine.Rendering.RenderTargetIdentifier(parameters[0].ToObject<UnityEngine.RenderBuffer>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.CubemapFace>(), parameters[3].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.RenderTargetIdentifier.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.RenderTargetIdentifier.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Rendering.RenderTargetIdentifier);
		}

		static private System.Boolean Equals(UnityEngine.Rendering.RenderTargetIdentifier instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.RenderTargetIdentifier>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>());
			}
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.RenderTargetIdentifier.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.RenderTargetIdentifier.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 GetHashCode(UnityEngine.Rendering.RenderTargetIdentifier instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetHashCode();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.RenderTargetIdentifier.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.String ToString(UnityEngine.Rendering.RenderTargetIdentifier instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ToString();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.RenderTargetIdentifier.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

	}
}
