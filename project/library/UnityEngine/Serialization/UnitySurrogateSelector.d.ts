declare namespace UnityEngine
{
	declare namespace Serialization
	{
		export class UnitySurrogateSelector
		{
			public constructor();
			public ChainSelector(selector: any): void;
			public GetNextSelector(): any;
		}
	}
}
