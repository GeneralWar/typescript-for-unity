declare namespace UnityEngine
{
	declare namespace Assertions
	{
		declare namespace Comparers
		{
			export namespace FloatComparer
			{
				export function AreEqual(expected: number, actual: number, error: number): boolean;
				export function AreEqualRelative(expected: number, actual: number, error: number): boolean;
			}
			export class FloatComparer
			{
				public constructor();
				public constructor(relative: boolean);
				public constructor(error: number);
				public constructor(error: number, relative: boolean);
				public Equals(a: number, b: number): boolean;
				public GetHashCode(obj: number): number;
			}
		}
	}
}
