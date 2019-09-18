using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineHideFlags
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.HideFlags> instance = space.DeclareEnum<UnityEngine.HideFlags>();
			instance.SetValue("None", (long)UnityEngine.HideFlags.None);
			instance.SetValue("HideInHierarchy", (long)UnityEngine.HideFlags.HideInHierarchy);
			instance.SetValue("HideInInspector", (long)UnityEngine.HideFlags.HideInInspector);
			instance.SetValue("DontSaveInEditor", (long)UnityEngine.HideFlags.DontSaveInEditor);
			instance.SetValue("NotEditable", (long)UnityEngine.HideFlags.NotEditable);
			instance.SetValue("DontSaveInBuild", (long)UnityEngine.HideFlags.DontSaveInBuild);
			instance.SetValue("DontUnloadUnusedAsset", (long)UnityEngine.HideFlags.DontUnloadUnusedAsset);
			instance.SetValue("DontSave", (long)UnityEngine.HideFlags.DontSave);
			instance.SetValue("HideAndDontSave", (long)UnityEngine.HideFlags.HideAndDontSave);
		}
	}
}
