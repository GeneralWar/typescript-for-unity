using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingIndexFormat
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.IndexFormat> instance = space.DeclareEnum<UnityEngine.Rendering.IndexFormat>();
			instance.SetValue("UInt16", (long)UnityEngine.Rendering.IndexFormat.UInt16);
			instance.SetValue("UInt32", (long)UnityEngine.Rendering.IndexFormat.UInt32);
		}
	}
}
