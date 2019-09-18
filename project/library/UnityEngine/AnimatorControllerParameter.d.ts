declare namespace UnityEngine
{
	export class AnimatorControllerParameter
	{
		public constructor();
		public Equals(o: any): number;
		public GetHashCode(): number;
		public get name(): string;
		public get nameHash(): number;
		public get type(): UnityEngine.AnimatorControllerParameterType;
		public set type(): UnityEngine.AnimatorControllerParameterType;
		public get defaultFloat(): number;
		public set defaultFloat(): number;
		public get defaultInt(): number;
		public set defaultInt(): number;
		public get defaultBool(): number;
		public set defaultBool(): number;
	}
}
