using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingBlendOp
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.BlendOp> instance = space.DeclareEnum<UnityEngine.Rendering.BlendOp>();
			instance.SetValue("Add", (long)UnityEngine.Rendering.BlendOp.Add);
			instance.SetValue("Subtract", (long)UnityEngine.Rendering.BlendOp.Subtract);
			instance.SetValue("ReverseSubtract", (long)UnityEngine.Rendering.BlendOp.ReverseSubtract);
			instance.SetValue("Min", (long)UnityEngine.Rendering.BlendOp.Min);
			instance.SetValue("Max", (long)UnityEngine.Rendering.BlendOp.Max);
			instance.SetValue("LogicalClear", (long)UnityEngine.Rendering.BlendOp.LogicalClear);
			instance.SetValue("LogicalSet", (long)UnityEngine.Rendering.BlendOp.LogicalSet);
			instance.SetValue("LogicalCopy", (long)UnityEngine.Rendering.BlendOp.LogicalCopy);
			instance.SetValue("LogicalCopyInverted", (long)UnityEngine.Rendering.BlendOp.LogicalCopyInverted);
			instance.SetValue("LogicalNoop", (long)UnityEngine.Rendering.BlendOp.LogicalNoop);
			instance.SetValue("LogicalInvert", (long)UnityEngine.Rendering.BlendOp.LogicalInvert);
			instance.SetValue("LogicalAnd", (long)UnityEngine.Rendering.BlendOp.LogicalAnd);
			instance.SetValue("LogicalNand", (long)UnityEngine.Rendering.BlendOp.LogicalNand);
			instance.SetValue("LogicalOr", (long)UnityEngine.Rendering.BlendOp.LogicalOr);
			instance.SetValue("LogicalNor", (long)UnityEngine.Rendering.BlendOp.LogicalNor);
			instance.SetValue("LogicalXor", (long)UnityEngine.Rendering.BlendOp.LogicalXor);
			instance.SetValue("LogicalEquivalence", (long)UnityEngine.Rendering.BlendOp.LogicalEquivalence);
			instance.SetValue("LogicalAndReverse", (long)UnityEngine.Rendering.BlendOp.LogicalAndReverse);
			instance.SetValue("LogicalAndInverted", (long)UnityEngine.Rendering.BlendOp.LogicalAndInverted);
			instance.SetValue("LogicalOrReverse", (long)UnityEngine.Rendering.BlendOp.LogicalOrReverse);
			instance.SetValue("LogicalOrInverted", (long)UnityEngine.Rendering.BlendOp.LogicalOrInverted);
			instance.SetValue("Multiply", (long)UnityEngine.Rendering.BlendOp.Multiply);
			instance.SetValue("Screen", (long)UnityEngine.Rendering.BlendOp.Screen);
			instance.SetValue("Overlay", (long)UnityEngine.Rendering.BlendOp.Overlay);
			instance.SetValue("Darken", (long)UnityEngine.Rendering.BlendOp.Darken);
			instance.SetValue("Lighten", (long)UnityEngine.Rendering.BlendOp.Lighten);
			instance.SetValue("ColorDodge", (long)UnityEngine.Rendering.BlendOp.ColorDodge);
			instance.SetValue("ColorBurn", (long)UnityEngine.Rendering.BlendOp.ColorBurn);
			instance.SetValue("HardLight", (long)UnityEngine.Rendering.BlendOp.HardLight);
			instance.SetValue("SoftLight", (long)UnityEngine.Rendering.BlendOp.SoftLight);
			instance.SetValue("Difference", (long)UnityEngine.Rendering.BlendOp.Difference);
			instance.SetValue("Exclusion", (long)UnityEngine.Rendering.BlendOp.Exclusion);
			instance.SetValue("HSLHue", (long)UnityEngine.Rendering.BlendOp.HSLHue);
			instance.SetValue("HSLSaturation", (long)UnityEngine.Rendering.BlendOp.HSLSaturation);
			instance.SetValue("HSLColor", (long)UnityEngine.Rendering.BlendOp.HSLColor);
			instance.SetValue("HSLLuminosity", (long)UnityEngine.Rendering.BlendOp.HSLLuminosity);
		}
	}
}
