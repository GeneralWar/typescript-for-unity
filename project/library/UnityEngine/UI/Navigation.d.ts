declare namespace UnityEngine
{
	declare namespace UI
	{
		export class Navigation extends System.ValueType
		{
			static public get defaultNavigation(): UnityEngine.UI.Navigation;
			public Equals(other: UnityEngine.UI.Navigation): boolean;
			public get selectOnUp(): UnityEngine.UI.Selectable;
			public set selectOnUp(): UnityEngine.UI.Selectable;
			public get selectOnDown(): UnityEngine.UI.Selectable;
			public set selectOnDown(): UnityEngine.UI.Selectable;
			public get selectOnLeft(): UnityEngine.UI.Selectable;
			public set selectOnLeft(): UnityEngine.UI.Selectable;
			public get selectOnRight(): UnityEngine.UI.Selectable;
			public set selectOnRight(): UnityEngine.UI.Selectable;
		}
	}
}
