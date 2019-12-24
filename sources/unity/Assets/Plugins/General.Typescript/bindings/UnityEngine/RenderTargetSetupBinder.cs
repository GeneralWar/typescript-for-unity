using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderTargetSetup
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.RenderTargetSetup> self = space.DeclareClass<UnityEngine.RenderTargetSetup>();
			self.BindConstructor(Constructor);
		}

		static private UnityEngine.RenderTargetSetup Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.RenderBuffer, UnityEngine.RenderBuffer>())
			{
				return new UnityEngine.RenderTargetSetup(parameters[0].ToObject<UnityEngine.RenderBuffer>(), parameters[1].ToObject<UnityEngine.RenderBuffer>());
			}
			if (parameters.CheckTypes<UnityEngine.RenderBuffer[], UnityEngine.RenderBuffer>())
			{
				return new UnityEngine.RenderTargetSetup(parameters[0].ToObject<UnityEngine.RenderBuffer[]>(), parameters[1].ToObject<UnityEngine.RenderBuffer>());
			}
			if (parameters.CheckTypes<UnityEngine.RenderBuffer, UnityEngine.RenderBuffer, System.Int32>())
			{
				return new UnityEngine.RenderTargetSetup(parameters[0].ToObject<UnityEngine.RenderBuffer>(), parameters[1].ToObject<UnityEngine.RenderBuffer>(), parameters[2].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.RenderBuffer[], UnityEngine.RenderBuffer, System.Int32>())
			{
				return new UnityEngine.RenderTargetSetup(parameters[0].ToObject<UnityEngine.RenderBuffer[]>(), parameters[1].ToObject<UnityEngine.RenderBuffer>(), parameters[2].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.RenderBuffer, UnityEngine.RenderBuffer, System.Int32, UnityEngine.CubemapFace>())
			{
				return new UnityEngine.RenderTargetSetup(parameters[0].ToObject<UnityEngine.RenderBuffer>(), parameters[1].ToObject<UnityEngine.RenderBuffer>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.CubemapFace>());
			}
			if (parameters.CheckTypes<UnityEngine.RenderBuffer[], UnityEngine.RenderBuffer, System.Int32, UnityEngine.CubemapFace>())
			{
				return new UnityEngine.RenderTargetSetup(parameters[0].ToObject<UnityEngine.RenderBuffer[]>(), parameters[1].ToObject<UnityEngine.RenderBuffer>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.CubemapFace>());
			}
			if (parameters.CheckTypes<UnityEngine.RenderBuffer, UnityEngine.RenderBuffer, System.Int32, UnityEngine.CubemapFace, System.Int32>())
			{
				return new UnityEngine.RenderTargetSetup(parameters[0].ToObject<UnityEngine.RenderBuffer>(), parameters[1].ToObject<UnityEngine.RenderBuffer>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.CubemapFace>(), parameters[4].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.RenderBuffer[], UnityEngine.RenderBuffer, System.Int32, UnityEngine.CubemapFace, UnityEngine.Rendering.RenderBufferLoadAction[], UnityEngine.Rendering.RenderBufferStoreAction[], UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction>())
			{
				return new UnityEngine.RenderTargetSetup(parameters[0].ToObject<UnityEngine.RenderBuffer[]>(), parameters[1].ToObject<UnityEngine.RenderBuffer>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.CubemapFace>(), parameters[4].ToObject<UnityEngine.Rendering.RenderBufferLoadAction[]>(), parameters[5].ToObject<UnityEngine.Rendering.RenderBufferStoreAction[]>(), parameters[6].ToObject<UnityEngine.Rendering.RenderBufferLoadAction>(), parameters[7].ToObject<UnityEngine.Rendering.RenderBufferStoreAction>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.RenderTargetSetup.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.RenderTargetSetup.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.RenderTargetSetup);
		}

	}
}
