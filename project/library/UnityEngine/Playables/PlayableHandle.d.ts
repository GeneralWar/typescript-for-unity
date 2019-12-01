declare namespace UnityEngine
{
	declare namespace Playables
	{
		export class PlayableHandle extends System.ValueType
		{
			static public get Null(): UnityEngine.Playables.PlayableHandle;
			public Equals(p: any): boolean;
			public Equals(other: UnityEngine.Playables.PlayableHandle): boolean;
			public GetHashCode(): number;
		}
	}
}
