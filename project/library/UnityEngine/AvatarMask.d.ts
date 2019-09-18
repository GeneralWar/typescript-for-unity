declare namespace UnityEngine
{
	export class AvatarMask extends UnityEngine.Object
	{
		public constructor();
		public AddTransformPath(transform: UnityEngine.Transform): void;
		public AddTransformPath(transform: UnityEngine.Transform, recursive: number): void;
		public GetHumanoidBodyPartActive(index: UnityEngine.AvatarMaskBodyPart): number;
		public GetTransformActive(index: number): number;
		public GetTransformPath(index: number): string;
		public RemoveTransformPath(transform: UnityEngine.Transform): void;
		public RemoveTransformPath(transform: UnityEngine.Transform, recursive: number): void;
		public SetHumanoidBodyPartActive(index: UnityEngine.AvatarMaskBodyPart, value: number): void;
		public SetTransformActive(index: number, value: number): void;
		public SetTransformPath(index: number, path: string): void;
		public get transformCount(): number;
		public set transformCount(): number;
	}
}
