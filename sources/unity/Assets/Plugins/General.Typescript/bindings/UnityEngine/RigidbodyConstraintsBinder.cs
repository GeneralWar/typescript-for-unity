using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRigidbodyConstraints
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.RigidbodyConstraints> instance = space.DeclareEnum<UnityEngine.RigidbodyConstraints>();
			instance.SetValue("None", (long)UnityEngine.RigidbodyConstraints.None);
			instance.SetValue("FreezePositionX", (long)UnityEngine.RigidbodyConstraints.FreezePositionX);
			instance.SetValue("FreezePositionY", (long)UnityEngine.RigidbodyConstraints.FreezePositionY);
			instance.SetValue("FreezePositionZ", (long)UnityEngine.RigidbodyConstraints.FreezePositionZ);
			instance.SetValue("FreezePosition", (long)UnityEngine.RigidbodyConstraints.FreezePosition);
			instance.SetValue("FreezeRotationX", (long)UnityEngine.RigidbodyConstraints.FreezeRotationX);
			instance.SetValue("FreezeRotationY", (long)UnityEngine.RigidbodyConstraints.FreezeRotationY);
			instance.SetValue("FreezeRotationZ", (long)UnityEngine.RigidbodyConstraints.FreezeRotationZ);
			instance.SetValue("FreezeRotation", (long)UnityEngine.RigidbodyConstraints.FreezeRotation);
			instance.SetValue("FreezeAll", (long)UnityEngine.RigidbodyConstraints.FreezeAll);
		}
	}
}
