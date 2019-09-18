declare namespace UnityEngine
{
	declare namespace Android
	{
		export namespace Permission
		{
			export function HasUserAuthorizedPermission(permission: string): number;
			export function RequestUserPermission(permission: string): void;
		}
		export class Permission extends System.ValueType
		{
		}
	}
}
