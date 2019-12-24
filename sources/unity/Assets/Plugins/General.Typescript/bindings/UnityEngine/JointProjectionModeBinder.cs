using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineJointProjectionMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.JointProjectionMode> instance = space.DeclareEnum<UnityEngine.JointProjectionMode>();
			instance.SetValue("None", (long)UnityEngine.JointProjectionMode.None);
			instance.SetValue("PositionAndRotation", (long)UnityEngine.JointProjectionMode.PositionAndRotation);
		}
	}
}
