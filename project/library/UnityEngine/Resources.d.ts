declare namespace UnityEngine
{
	export namespace Resources
	{
		export function FindObjectsOfTypeAll<T extends type>(type : { prototype : T }): T;
		export function GetBuiltinResource<T extends type>(type : { prototype : T }, path: string): T;
		export function Load(path: string): UnityEngine.Object;
		export function Load<T extends type>(path: string, type : { prototype : T }): T;
		export function LoadAll(path: string): UnityEngine.Object[];
		export function LoadAll<T extends type>(path: string, type : { prototype : T }): T;
		export function LoadAsync(path: string): UnityEngine.ResourceRequest;
		export function LoadAsync(path: string, type : { prototype : T }): UnityEngine.ResourceRequest;
		export function UnloadAsset(assetToUnload: UnityEngine.Object): void;
		export function UnloadUnusedAssets(): UnityEngine.AsyncOperation;
	}
	export class Resources
	{
		public constructor();
	}
}
