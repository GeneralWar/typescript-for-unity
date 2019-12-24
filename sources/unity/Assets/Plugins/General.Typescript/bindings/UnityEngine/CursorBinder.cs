using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCursor
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Cursor> self = space.DeclareClass<UnityEngine.Cursor>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("SetCursor", SetCursor);
			self.BindStaticProperty("visible", get_visible, set_visible);
			self.BindStaticProperty("lockState", get_lockState, set_lockState);
		}

		static private UnityEngine.Cursor Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Cursor();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Cursor.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Cursor);
		}

		static private void SetCursor(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Texture2D, UnityEngine.Vector2, UnityEngine.CursorMode>())
			{
				UnityEngine.Cursor.SetCursor(parameters[0].ToObject<UnityEngine.Texture2D>(), parameters[1].ToObject<UnityEngine.Vector2>(), parameters[2].ToObject<UnityEngine.CursorMode>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Cursor.SetCursor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Cursor.SetCursor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean get_visible(Type type, string name)
		{
			return UnityEngine.Cursor.visible;
		}

		static private void set_visible(Type type, string name, System.Boolean value)
		{
			UnityEngine.Cursor.visible = value;
		}

		static private UnityEngine.CursorLockMode get_lockState(Type type, string name)
		{
			return UnityEngine.Cursor.lockState;
		}

		static private void set_lockState(Type type, string name, UnityEngine.CursorLockMode value)
		{
			UnityEngine.Cursor.lockState = value;
		}

	}
}
