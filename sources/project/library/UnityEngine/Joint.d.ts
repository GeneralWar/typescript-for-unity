declare namespace UnityEngine
{
	export class Joint extends UnityEngine.Component
	{
		public constructor();
		public get connectedBody(): UnityEngine.Rigidbody;
		public set connectedBody(): UnityEngine.Rigidbody;
		public get axis(): UnityEngine.Vector3;
		public set axis(): UnityEngine.Vector3;
		public get anchor(): UnityEngine.Vector3;
		public set anchor(): UnityEngine.Vector3;
		public get connectedAnchor(): UnityEngine.Vector3;
		public set connectedAnchor(): UnityEngine.Vector3;
		public get autoConfigureConnectedAnchor(): boolean;
		public set autoConfigureConnectedAnchor(): boolean;
		public get breakForce(): number;
		public set breakForce(): number;
		public get breakTorque(): number;
		public set breakTorque(): number;
		public get enableCollision(): boolean;
		public set enableCollision(): boolean;
		public get enablePreprocessing(): boolean;
		public set enablePreprocessing(): boolean;
		public get massScale(): number;
		public set massScale(): number;
		public get connectedMassScale(): number;
		public set connectedMassScale(): number;
		public get currentForce(): UnityEngine.Vector3;
		public get currentTorque(): UnityEngine.Vector3;
	}
}
