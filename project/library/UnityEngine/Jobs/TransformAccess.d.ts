declare namespace UnityEngine
{
	declare namespace Jobs
	{
		export class TransformAccess extends System.ValueType
		{
			public get position(): UnityEngine.Vector3;
			public set position(): UnityEngine.Vector3;
			public get rotation(): UnityEngine.Quaternion;
			public set rotation(): UnityEngine.Quaternion;
			public get localPosition(): UnityEngine.Vector3;
			public set localPosition(): UnityEngine.Vector3;
			public get localRotation(): UnityEngine.Quaternion;
			public set localRotation(): UnityEngine.Quaternion;
			public get localScale(): UnityEngine.Vector3;
			public set localScale(): UnityEngine.Vector3;
		}
	}
}
