using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineEventSystemsRaycastResult
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.EventSystems.RaycastResult> self = space.DeclareClass<UnityEngine.EventSystems.RaycastResult>();
			self.BindConstructor();
			self.BindInstanceFunction("Clear", Clear);
			self.BindInstanceFunction("ToString", ToString);
			self.BindInstanceProperty("gameObject", get_gameObject, set_gameObject);
			self.BindInstanceProperty("isValid", get_isValid, null);
		}

		static private void Clear(UnityEngine.EventSystems.RaycastResult instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Clear();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.RaycastResult.Clear has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.String ToString(UnityEngine.EventSystems.RaycastResult instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ToString();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.RaycastResult.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.GameObject get_gameObject(UnityEngine.EventSystems.RaycastResult instance)
		{
			return instance.gameObject;
		}

		static private void set_gameObject(UnityEngine.EventSystems.RaycastResult instance, UnityEngine.GameObject value)
		{
			instance.gameObject = value;
		}

		static private System.Boolean get_isValid(UnityEngine.EventSystems.RaycastResult instance)
		{
			return instance.isValid;
		}

	}
}
