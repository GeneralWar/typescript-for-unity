using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEnginePhysicsScene
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.PhysicsScene> self = space.DeclareClass<UnityEngine.PhysicsScene>();
			self.BindConstructor();
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindInstanceFunction("IsEmpty", IsEmpty);
			self.BindInstanceFunction("IsValid", IsValid);
			self.BindInstanceFunction("Raycast", Raycast);
			self.BindInstanceFunction("Simulate", Simulate);
			self.BindInstanceFunction("ToString", ToString);
		}

		static private System.Boolean Equals(UnityEngine.PhysicsScene instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (parameters.CheckTypes<UnityEngine.PhysicsScene>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.PhysicsScene>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.PhysicsScene.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.PhysicsScene.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 GetHashCode(UnityEngine.PhysicsScene instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetHashCode();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.PhysicsScene.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.Boolean IsEmpty(UnityEngine.PhysicsScene instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.IsEmpty();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.PhysicsScene.IsEmpty has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private System.Boolean IsValid(UnityEngine.PhysicsScene instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.IsValid();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.PhysicsScene.IsValid has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private System.Object Raycast(UnityEngine.PhysicsScene instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single, System.Int32, UnityEngine.QueryTriggerInteraction>())
			{
				return instance.Raycast(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.QueryTriggerInteraction>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.RaycastHit[], System.Single, System.Int32, UnityEngine.QueryTriggerInteraction>())
			{
				return instance.Raycast(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.RaycastHit[]>(), parameters[3].ToObject<System.Single>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<UnityEngine.QueryTriggerInteraction>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.PhysicsScene.Raycast has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.PhysicsScene.Raycast has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void Simulate(UnityEngine.PhysicsScene instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				instance.Simulate(parameters[0].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.PhysicsScene.Simulate has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.PhysicsScene.Simulate has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.String ToString(UnityEngine.PhysicsScene instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.PhysicsScene.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

	}
}
