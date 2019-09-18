using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineEventSystemsAxisEventData
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.EventSystems.AxisEventData> self = space.DeclareClass<UnityEngine.EventSystems.AxisEventData>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("moveVector", get_moveVector, set_moveVector);
			self.BindInstanceProperty("moveDir", get_moveDir, set_moveDir);
		}

		static private UnityEngine.EventSystems.AxisEventData Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.EventSystem>())
			{
				return new UnityEngine.EventSystems.AxisEventData(parameters[0].ToObject<UnityEngine.EventSystems.EventSystem>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.EventSystems.AxisEventData.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.AxisEventData.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.EventSystems.AxisEventData);
		}

		static private UnityEngine.Vector2 get_moveVector(UnityEngine.EventSystems.AxisEventData instance)
		{
			return instance.moveVector;
		}

		static private void set_moveVector(UnityEngine.EventSystems.AxisEventData instance, UnityEngine.Vector2 value)
		{
			instance.moveVector = value;
		}

		static private UnityEngine.EventSystems.MoveDirection get_moveDir(UnityEngine.EventSystems.AxisEventData instance)
		{
			return instance.moveDir;
		}

		static private void set_moveDir(UnityEngine.EventSystems.AxisEventData instance, UnityEngine.EventSystems.MoveDirection value)
		{
			instance.moveDir = value;
		}

	}
}
