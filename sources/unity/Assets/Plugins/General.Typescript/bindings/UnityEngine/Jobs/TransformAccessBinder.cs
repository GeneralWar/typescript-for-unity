using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineJobsTransformAccess
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Jobs.TransformAccess> self = space.DeclareClass<UnityEngine.Jobs.TransformAccess>();
			self.BindConstructor();
			self.BindInstanceProperty("position", get_position, set_position);
			self.BindInstanceProperty("rotation", get_rotation, set_rotation);
			self.BindInstanceProperty("localPosition", get_localPosition, set_localPosition);
			self.BindInstanceProperty("localRotation", get_localRotation, set_localRotation);
			self.BindInstanceProperty("localScale", get_localScale, set_localScale);
		}

		static private UnityEngine.Vector3 get_position(UnityEngine.Jobs.TransformAccess instance)
		{
			return instance.position;
		}

		static private void set_position(UnityEngine.Jobs.TransformAccess instance, UnityEngine.Vector3 value)
		{
			instance.position = value;
		}

		static private UnityEngine.Quaternion get_rotation(UnityEngine.Jobs.TransformAccess instance)
		{
			return instance.rotation;
		}

		static private void set_rotation(UnityEngine.Jobs.TransformAccess instance, UnityEngine.Quaternion value)
		{
			instance.rotation = value;
		}

		static private UnityEngine.Vector3 get_localPosition(UnityEngine.Jobs.TransformAccess instance)
		{
			return instance.localPosition;
		}

		static private void set_localPosition(UnityEngine.Jobs.TransformAccess instance, UnityEngine.Vector3 value)
		{
			instance.localPosition = value;
		}

		static private UnityEngine.Quaternion get_localRotation(UnityEngine.Jobs.TransformAccess instance)
		{
			return instance.localRotation;
		}

		static private void set_localRotation(UnityEngine.Jobs.TransformAccess instance, UnityEngine.Quaternion value)
		{
			instance.localRotation = value;
		}

		static private UnityEngine.Vector3 get_localScale(UnityEngine.Jobs.TransformAccess instance)
		{
			return instance.localScale;
		}

		static private void set_localScale(UnityEngine.Jobs.TransformAccess instance, UnityEngine.Vector3 value)
		{
			instance.localScale = value;
		}

	}
}
