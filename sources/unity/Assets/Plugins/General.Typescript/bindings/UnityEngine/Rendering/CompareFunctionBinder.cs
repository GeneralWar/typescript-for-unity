using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingCompareFunction
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.CompareFunction> instance = space.DeclareEnum<UnityEngine.Rendering.CompareFunction>();
			instance.SetValue("Disabled", (long)UnityEngine.Rendering.CompareFunction.Disabled);
			instance.SetValue("Never", (long)UnityEngine.Rendering.CompareFunction.Never);
			instance.SetValue("Less", (long)UnityEngine.Rendering.CompareFunction.Less);
			instance.SetValue("Equal", (long)UnityEngine.Rendering.CompareFunction.Equal);
			instance.SetValue("LessEqual", (long)UnityEngine.Rendering.CompareFunction.LessEqual);
			instance.SetValue("Greater", (long)UnityEngine.Rendering.CompareFunction.Greater);
			instance.SetValue("NotEqual", (long)UnityEngine.Rendering.CompareFunction.NotEqual);
			instance.SetValue("GreaterEqual", (long)UnityEngine.Rendering.CompareFunction.GreaterEqual);
			instance.SetValue("Always", (long)UnityEngine.Rendering.CompareFunction.Always);
		}
	}
}
