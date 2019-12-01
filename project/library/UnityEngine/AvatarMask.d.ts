declare namespace UnityEngine
{
	export class AvatarMask extends UnityEngine.Object
	{
		public constructor();
		public AddTransformPath(transform: UnityEngine.Transform): void;
		public AddTransformPath(transform: UnityEngine.Transform, recursive: boolean): void;
		public GetHumanoidBodyPartActive(index: UnityEngine.AvatarMaskBodyPart): boolean;
		public GetTransformActive(index: number): boolean;
		public GetTransformPath(index: number): string;
		public RemoveTransformPath(transform: UnityEngine.Transform): void;
		public RemoveTransformPath(transform: UnityEngine.Transform, recursive: boolean): void;
		public SetHumanoidBodyPartActive(index: UnityEngine.AvatarMaskBodyPart, value: boolean): void;
		public SetTransformActive(index: number, value: boolean): void;
		public SetTransformPath(index: number, path: string): void;
		public get transformCount(): number;
		public set transformCount(): number;
	}
}
