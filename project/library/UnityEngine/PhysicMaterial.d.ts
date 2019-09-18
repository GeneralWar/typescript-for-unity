declare namespace UnityEngine
{
	export class PhysicMaterial extends UnityEngine.Object
	{
		public constructor();
		public constructor(name: string);
		public get bounciness(): number;
		public set bounciness(): number;
		public get dynamicFriction(): number;
		public set dynamicFriction(): number;
		public get staticFriction(): number;
		public set staticFriction(): number;
		public get frictionCombine(): UnityEngine.PhysicMaterialCombine;
		public set frictionCombine(): UnityEngine.PhysicMaterialCombine;
		public get bounceCombine(): UnityEngine.PhysicMaterialCombine;
		public set bounceCombine(): UnityEngine.PhysicMaterialCombine;
	}
}
