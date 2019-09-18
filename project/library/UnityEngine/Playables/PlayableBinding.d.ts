declare namespace UnityEngine
{
	declare namespace Playables
	{
		export class PlayableBinding extends System.ValueType
		{
			public get streamName(): string;
			public set streamName(): string;
			public get sourceObject(): UnityEngine.Object;
			public set sourceObject(): UnityEngine.Object;
			public get outputTargetType(): System.Type;
		}
	}
}
