declare namespace UnityEngine
{
	declare namespace Assertions
	{
		declare namespace Comparers
		{
			export namespace FloatComparer
			{
				export function AreEqual(expected: number, actual: number, error: number): number;
				export function AreEqualRelative(expected: number, actual: number, error: number): number;
			}
			export class FloatComparer
			{
				public constructor();
				public constructor(relative: number);
				public constructor(error: number);
				public constructor(error: number, relative: number);
				public Equals(a: number, b: number): number;
				public GetHashCode(obj: number): number;
			}
		}
	}
}
