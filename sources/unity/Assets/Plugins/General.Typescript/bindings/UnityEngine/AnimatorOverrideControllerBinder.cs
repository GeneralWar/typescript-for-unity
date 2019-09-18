using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimatorOverrideController
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.AnimatorOverrideController> self = space.DeclareClass<UnityEngine.AnimatorOverrideController, UnityEngine.RuntimeAnimatorController>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("runtimeAnimatorController", get_runtimeAnimatorController, set_runtimeAnimatorController);
			self.BindInstanceProperty("overridesCount", get_overridesCount, null);
		}

		static private UnityEngine.AnimatorOverrideController Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.AnimatorOverrideController();
			}
			if (parameters.CheckTypes<UnityEngine.RuntimeAnimatorController>())
			{
				return new UnityEngine.AnimatorOverrideController(parameters[0].ToObject<UnityEngine.RuntimeAnimatorController>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimatorOverrideController.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.AnimatorOverrideController);
		}

		static private UnityEngine.RuntimeAnimatorController get_runtimeAnimatorController(UnityEngine.AnimatorOverrideController instance)
		{
			return instance.runtimeAnimatorController;
		}

		static private void set_runtimeAnimatorController(UnityEngine.AnimatorOverrideController instance, UnityEngine.RuntimeAnimatorController value)
		{
			instance.runtimeAnimatorController = value;
		}

		static private System.Int32 get_overridesCount(UnityEngine.AnimatorOverrideController instance)
		{
			return instance.overridesCount;
		}

	}
}
