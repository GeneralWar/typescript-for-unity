declare namespace UnityEngine
{
	declare namespace EventSystems
	{
		export class StandaloneInputModule extends UnityEngine.EventSystems.PointerInputModule
		{
			public ActivateModule(): void;
			public DeactivateModule(): void;
			public IsModuleSupported(): boolean;
			public Process(): void;
			public ShouldActivateModule(): boolean;
			public UpdateModule(): void;
			public get forceModuleActive(): boolean;
			public set forceModuleActive(): boolean;
			public get inputActionsPerSecond(): number;
			public set inputActionsPerSecond(): number;
			public get repeatDelay(): number;
			public set repeatDelay(): number;
			public get horizontalAxis(): string;
			public set horizontalAxis(): string;
			public get verticalAxis(): string;
			public set verticalAxis(): string;
			public get submitButton(): string;
			public set submitButton(): string;
			public get cancelButton(): string;
			public set cancelButton(): string;
		}
	}
}
