using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingGraphicsDeviceType
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.GraphicsDeviceType> instance = space.DeclareEnum<UnityEngine.Rendering.GraphicsDeviceType>();
			instance.SetValue("Direct3D11", (long)UnityEngine.Rendering.GraphicsDeviceType.Direct3D11);
			instance.SetValue("Null", (long)UnityEngine.Rendering.GraphicsDeviceType.Null);
			instance.SetValue("OpenGLES2", (long)UnityEngine.Rendering.GraphicsDeviceType.OpenGLES2);
			instance.SetValue("OpenGLES3", (long)UnityEngine.Rendering.GraphicsDeviceType.OpenGLES3);
			instance.SetValue("PlayStation4", (long)UnityEngine.Rendering.GraphicsDeviceType.PlayStation4);
			instance.SetValue("XboxOne", (long)UnityEngine.Rendering.GraphicsDeviceType.XboxOne);
			instance.SetValue("Metal", (long)UnityEngine.Rendering.GraphicsDeviceType.Metal);
			instance.SetValue("OpenGLCore", (long)UnityEngine.Rendering.GraphicsDeviceType.OpenGLCore);
			instance.SetValue("Direct3D12", (long)UnityEngine.Rendering.GraphicsDeviceType.Direct3D12);
			instance.SetValue("Vulkan", (long)UnityEngine.Rendering.GraphicsDeviceType.Vulkan);
			instance.SetValue("Switch", (long)UnityEngine.Rendering.GraphicsDeviceType.Switch);
			instance.SetValue("XboxOneD3D12", (long)UnityEngine.Rendering.GraphicsDeviceType.XboxOneD3D12);
		}
	}
}
