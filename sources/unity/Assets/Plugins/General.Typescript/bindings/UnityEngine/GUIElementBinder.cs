using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineGUIElement
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.GUIElement> self = space.DeclareClass<UnityEngine.GUIElement, UnityEngine.Behaviour>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("GetScreenRect", GetScreenRect);
			self.BindInstanceFunction("HitTest", HitTest);
		}

		static private UnityEngine.GUIElement Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.GUIElement();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.GUIElement.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.GUIElement);
		}

		static private UnityEngine.Rect GetScreenRect(UnityEngine.GUIElement instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetScreenRect();
			}
			if (parameters.CheckTypes<UnityEngine.Camera>())
			{
				return instance.GetScreenRect(parameters[0].ToObject<UnityEngine.Camera>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.GUIElement.GetScreenRect has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Rect);
		}

		static private System.Boolean HitTest(UnityEngine.GUIElement instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.HitTest(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Camera>())
			{
				return instance.HitTest(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Camera>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GUIElement.HitTest has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GUIElement.HitTest has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

	}
}
