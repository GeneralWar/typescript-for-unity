declare namespace UnityEngine
{
	export namespace HumanTrait
	{
		export function BoneFromMuscle(i: number): number;
		export function GetBoneDefaultHierarchyMass(i: number): number;
		export function GetMuscleDefaultMax(i: number): number;
		export function GetMuscleDefaultMin(i: number): number;
		export function GetParentBone(i: number): number;
		export function MuscleFromBone(i: number, dofIndex: number): number;
		export function RequiredBone(i: number): number;
	}
	export class HumanTrait
	{
		public constructor();
		static public get MuscleCount(): number;
		static public get MuscleName(): string[];
		static public get BoneCount(): number;
		static public get BoneName(): string[];
		static public get RequiredBoneCount(): number;
	}
}
