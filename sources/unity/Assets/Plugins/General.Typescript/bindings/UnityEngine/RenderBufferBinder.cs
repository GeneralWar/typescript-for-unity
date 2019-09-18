using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderBuffer
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.RenderBuffer> self = space.DeclareClass<UnityEngine.RenderBuffer>();
			self.BindConstructor();
			self.BindInstanceFunction("GetNativeRenderBufferPtr", GetNativeRenderBufferPtr);
		}

		static private System.IntPtr GetNativeRenderBufferPtr(UnityEngine.RenderBuffer instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetNativeRenderBufferPtr();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.RenderBuffer.GetNativeRenderBufferPtr has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.IntPtr);
		}

	}
}
