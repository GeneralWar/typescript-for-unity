using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRectTransformEdge
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.RectTransform.Edge> instance = space.DeclareEnum<UnityEngine.RectTransform.Edge>();
			instance.SetValue("Left", (long)UnityEngine.RectTransform.Edge.Left);
			instance.SetValue("Right", (long)UnityEngine.RectTransform.Edge.Right);
			instance.SetValue("Top", (long)UnityEngine.RectTransform.Edge.Top);
			instance.SetValue("Bottom", (long)UnityEngine.RectTransform.Edge.Bottom);
		}
	}
}
