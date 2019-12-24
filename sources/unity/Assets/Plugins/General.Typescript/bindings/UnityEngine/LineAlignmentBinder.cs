using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLineAlignment
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.LineAlignment> instance = space.DeclareEnum<UnityEngine.LineAlignment>();
			instance.SetValue("View", (long)UnityEngine.LineAlignment.View);
			instance.SetValue("TransformZ", (long)UnityEngine.LineAlignment.TransformZ);
		}
	}
}
