declare namespace UnityEngine
{
	export namespace ScriptableObject
	{
		export function CreateInstance<T extends type>(type : { prototype : T }): T;
		export function CreateInstance(className: string): UnityEngine.ScriptableObject;
	}
	export class ScriptableObject extends UnityEngine.Object
	{
		public constructor();
	}
}
