using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCanvasGroup
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.CanvasGroup> self = space.DeclareClass<UnityEngine.CanvasGroup, UnityEngine.Behaviour>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("IsRaycastLocationValid", IsRaycastLocationValid);
			self.BindInstanceProperty("alpha", get_alpha, set_alpha);
			self.BindInstanceProperty("interactable", get_interactable, set_interactable);
			self.BindInstanceProperty("blocksRaycasts", get_blocksRaycasts, set_blocksRaycasts);
			self.BindInstanceProperty("ignoreParentGroups", get_ignoreParentGroups, set_ignoreParentGroups);
		}

		static private UnityEngine.CanvasGroup Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.CanvasGroup();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.CanvasGroup.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.CanvasGroup);
		}

		static private System.Boolean IsRaycastLocationValid(UnityEngine.CanvasGroup instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2, UnityEngine.Camera>())
			{
				return instance.IsRaycastLocationValid(parameters[0].ToObject<UnityEngine.Vector2>(), parameters[1].ToObject<UnityEngine.Camera>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.CanvasGroup.IsRaycastLocationValid has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.CanvasGroup.IsRaycastLocationValid has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Single get_alpha(UnityEngine.CanvasGroup instance, string name)
		{
			return instance.alpha;
		}

		static private void set_alpha(UnityEngine.CanvasGroup instance, string name, System.Single value)
		{
			instance.alpha = value;
		}

		static private System.Boolean get_interactable(UnityEngine.CanvasGroup instance, string name)
		{
			return instance.interactable;
		}

		static private void set_interactable(UnityEngine.CanvasGroup instance, string name, System.Boolean value)
		{
			instance.interactable = value;
		}

		static private System.Boolean get_blocksRaycasts(UnityEngine.CanvasGroup instance, string name)
		{
			return instance.blocksRaycasts;
		}

		static private void set_blocksRaycasts(UnityEngine.CanvasGroup instance, string name, System.Boolean value)
		{
			instance.blocksRaycasts = value;
		}

		static private System.Boolean get_ignoreParentGroups(UnityEngine.CanvasGroup instance, string name)
		{
			return instance.ignoreParentGroups;
		}

		static private void set_ignoreParentGroups(UnityEngine.CanvasGroup instance, string name, System.Boolean value)
		{
			instance.ignoreParentGroups = value;
		}

	}
}
