using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineInternalTypeInferenceRules
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngineInternal.TypeInferenceRules> instance = space.DeclareEnum<UnityEngineInternal.TypeInferenceRules>();
			instance.SetValue("TypeReferencedByFirstArgument", (long)UnityEngineInternal.TypeInferenceRules.TypeReferencedByFirstArgument);
			instance.SetValue("TypeReferencedBySecondArgument", (long)UnityEngineInternal.TypeInferenceRules.TypeReferencedBySecondArgument);
			instance.SetValue("ArrayOfTypeReferencedByFirstArgument", (long)UnityEngineInternal.TypeInferenceRules.ArrayOfTypeReferencedByFirstArgument);
			instance.SetValue("TypeOfFirstArgument", (long)UnityEngineInternal.TypeInferenceRules.TypeOfFirstArgument);
		}
	}
}
