declare namespace UnityEngine
{
	export namespace Object
	{
		export function Destroy(obj: UnityEngine.Object): void;
		export function Destroy(obj: UnityEngine.Object, t: number): void;
		export function DestroyImmediate(obj: UnityEngine.Object): void;
		export function DestroyImmediate(obj: UnityEngine.Object, allowDestroyingAssets: number): void;
		export function DontDestroyOnLoad(target: UnityEngine.Object): void;
		export function FindObjectOfType<T extends type>(type : { prototype : T }): T;
		export function FindObjectsOfType<T extends type>(type : { prototype : T }): T;
		export function Instantiate(original: UnityEngine.Object): UnityEngine.Object;
		export function Instantiate(original: UnityEngine.Object, parent: UnityEngine.Transform): UnityEngine.Object;
		export function Instantiate(original: UnityEngine.Object, position: UnityEngine.Vector3, rotation: UnityEngine.Quaternion): UnityEngine.Object;
		export function Instantiate(original: UnityEngine.Object, parent: UnityEngine.Transform, instantiateInWorldSpace: number): UnityEngine.Object;
		export function Instantiate(original: UnityEngine.Object, position: UnityEngine.Vector3, rotation: UnityEngine.Quaternion, parent: UnityEngine.Transform): UnityEngine.Object;
	}
	export class Object
	{
		public constructor();
		public Equals(other: any): number;
		public GetHashCode(): number;
		public GetInstanceID(): number;
		public ToString(): string;
		public get name(): string;
		public set name(): string;
		public get hideFlags(): UnityEngine.HideFlags;
		public set hideFlags(): UnityEngine.HideFlags;
	}
}
