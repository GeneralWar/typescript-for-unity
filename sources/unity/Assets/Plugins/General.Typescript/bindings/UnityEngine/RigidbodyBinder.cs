using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRigidbody
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Rigidbody> self = space.DeclareClass<UnityEngine.Rigidbody, UnityEngine.Component>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("AddExplosionForce", AddExplosionForce);
			self.BindInstanceFunction("AddForce", AddForce);
			self.BindInstanceFunction("AddForceAtPosition", AddForceAtPosition);
			self.BindInstanceFunction("AddRelativeForce", AddRelativeForce);
			self.BindInstanceFunction("AddRelativeTorque", AddRelativeTorque);
			self.BindInstanceFunction("AddTorque", AddTorque);
			self.BindInstanceFunction("ClosestPointOnBounds", ClosestPointOnBounds);
			self.BindInstanceFunction("GetPointVelocity", GetPointVelocity);
			self.BindInstanceFunction("GetRelativePointVelocity", GetRelativePointVelocity);
			self.BindInstanceFunction("IsSleeping", IsSleeping);
			self.BindInstanceFunction("MovePosition", MovePosition);
			self.BindInstanceFunction("MoveRotation", MoveRotation);
			self.BindInstanceFunction("ResetCenterOfMass", ResetCenterOfMass);
			self.BindInstanceFunction("ResetInertiaTensor", ResetInertiaTensor);
			self.BindInstanceFunction("SetDensity", SetDensity);
			self.BindInstanceFunction("Sleep", Sleep);
			self.BindInstanceFunction("SweepTestAll", SweepTestAll);
			self.BindInstanceFunction("WakeUp", WakeUp);
			self.BindInstanceProperty("velocity", get_velocity, set_velocity);
			self.BindInstanceProperty("sleepThreshold", get_sleepThreshold, set_sleepThreshold);
			self.BindInstanceProperty("solverIterations", get_solverIterations, set_solverIterations);
			self.BindInstanceProperty("interpolation", get_interpolation, set_interpolation);
			self.BindInstanceProperty("rotation", get_rotation, set_rotation);
			self.BindInstanceProperty("position", get_position, set_position);
			self.BindInstanceProperty("detectCollisions", get_detectCollisions, set_detectCollisions);
			self.BindInstanceProperty("inertiaTensor", get_inertiaTensor, set_inertiaTensor);
			self.BindInstanceProperty("inertiaTensorRotation", get_inertiaTensorRotation, set_inertiaTensorRotation);
			self.BindInstanceProperty("worldCenterOfMass", get_worldCenterOfMass, null);
			self.BindInstanceProperty("maxAngularVelocity", get_maxAngularVelocity, set_maxAngularVelocity);
			self.BindInstanceProperty("centerOfMass", get_centerOfMass, set_centerOfMass);
			self.BindInstanceProperty("constraints", get_constraints, set_constraints);
			self.BindInstanceProperty("freezeRotation", get_freezeRotation, set_freezeRotation);
			self.BindInstanceProperty("isKinematic", get_isKinematic, set_isKinematic);
			self.BindInstanceProperty("maxDepenetrationVelocity", get_maxDepenetrationVelocity, set_maxDepenetrationVelocity);
			self.BindInstanceProperty("useGravity", get_useGravity, set_useGravity);
			self.BindInstanceProperty("mass", get_mass, set_mass);
			self.BindInstanceProperty("angularDrag", get_angularDrag, set_angularDrag);
			self.BindInstanceProperty("drag", get_drag, set_drag);
			self.BindInstanceProperty("angularVelocity", get_angularVelocity, set_angularVelocity);
			self.BindInstanceProperty("collisionDetectionMode", get_collisionDetectionMode, set_collisionDetectionMode);
			self.BindInstanceProperty("solverVelocityIterations", get_solverVelocityIterations, set_solverVelocityIterations);
		}

		static private UnityEngine.Rigidbody Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Rigidbody();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Rigidbody.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Rigidbody);
		}

		static private void AddExplosionForce(UnityEngine.Rigidbody instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, UnityEngine.Vector3, System.Single>())
			{
				instance.AddExplosionForce(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.Single, UnityEngine.Vector3, System.Single, System.Single>())
			{
				instance.AddExplosionForce(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.Single, UnityEngine.Vector3, System.Single, System.Single, UnityEngine.ForceMode>())
			{
				instance.AddExplosionForce(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Single>(), parameters[4].ToObject<UnityEngine.ForceMode>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rigidbody.AddExplosionForce has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rigidbody.AddExplosionForce has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void AddForce(UnityEngine.Rigidbody instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				instance.AddForce(parameters[0].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.ForceMode>())
			{
				instance.AddForce(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.ForceMode>());
				return;
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				instance.AddForce(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single, UnityEngine.ForceMode>())
			{
				instance.AddForce(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<UnityEngine.ForceMode>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rigidbody.AddForce has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rigidbody.AddForce has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void AddForceAtPosition(UnityEngine.Rigidbody instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3>())
			{
				instance.AddForceAtPosition(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.ForceMode>())
			{
				instance.AddForceAtPosition(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.ForceMode>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rigidbody.AddForceAtPosition has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rigidbody.AddForceAtPosition has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void AddRelativeForce(UnityEngine.Rigidbody instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				instance.AddRelativeForce(parameters[0].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.ForceMode>())
			{
				instance.AddRelativeForce(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.ForceMode>());
				return;
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				instance.AddRelativeForce(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single, UnityEngine.ForceMode>())
			{
				instance.AddRelativeForce(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<UnityEngine.ForceMode>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rigidbody.AddRelativeForce has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rigidbody.AddRelativeForce has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void AddRelativeTorque(UnityEngine.Rigidbody instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				instance.AddRelativeTorque(parameters[0].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.ForceMode>())
			{
				instance.AddRelativeTorque(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.ForceMode>());
				return;
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				instance.AddRelativeTorque(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single, UnityEngine.ForceMode>())
			{
				instance.AddRelativeTorque(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<UnityEngine.ForceMode>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rigidbody.AddRelativeTorque has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rigidbody.AddRelativeTorque has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void AddTorque(UnityEngine.Rigidbody instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				instance.AddTorque(parameters[0].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.ForceMode>())
			{
				instance.AddTorque(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.ForceMode>());
				return;
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				instance.AddTorque(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single, UnityEngine.ForceMode>())
			{
				instance.AddTorque(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<UnityEngine.ForceMode>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rigidbody.AddTorque has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rigidbody.AddTorque has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Vector3 ClosestPointOnBounds(UnityEngine.Rigidbody instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.ClosestPointOnBounds(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rigidbody.ClosestPointOnBounds has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rigidbody.ClosestPointOnBounds has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private UnityEngine.Vector3 GetPointVelocity(UnityEngine.Rigidbody instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.GetPointVelocity(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rigidbody.GetPointVelocity has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rigidbody.GetPointVelocity has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private UnityEngine.Vector3 GetRelativePointVelocity(UnityEngine.Rigidbody instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.GetRelativePointVelocity(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rigidbody.GetRelativePointVelocity has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rigidbody.GetRelativePointVelocity has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private System.Boolean IsSleeping(UnityEngine.Rigidbody instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.IsSleeping();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Rigidbody.IsSleeping has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private void MovePosition(UnityEngine.Rigidbody instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				instance.MovePosition(parameters[0].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rigidbody.MovePosition has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rigidbody.MovePosition has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void MoveRotation(UnityEngine.Rigidbody instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Quaternion>())
			{
				instance.MoveRotation(parameters[0].ToObject<UnityEngine.Quaternion>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rigidbody.MoveRotation has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rigidbody.MoveRotation has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void ResetCenterOfMass(UnityEngine.Rigidbody instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.ResetCenterOfMass();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Rigidbody.ResetCenterOfMass has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void ResetInertiaTensor(UnityEngine.Rigidbody instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.ResetInertiaTensor();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Rigidbody.ResetInertiaTensor has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void SetDensity(UnityEngine.Rigidbody instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				instance.SetDensity(parameters[0].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rigidbody.SetDensity has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rigidbody.SetDensity has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Sleep(UnityEngine.Rigidbody instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Sleep();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Rigidbody.Sleep has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private UnityEngine.RaycastHit[] SweepTestAll(UnityEngine.Rigidbody instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.SweepTestAll(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, System.Single>())
			{
				return instance.SweepTestAll(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, System.Single, UnityEngine.QueryTriggerInteraction>())
			{
				return instance.SweepTestAll(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<UnityEngine.QueryTriggerInteraction>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rigidbody.SweepTestAll has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rigidbody.SweepTestAll has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void WakeUp(UnityEngine.Rigidbody instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.WakeUp();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Rigidbody.WakeUp has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private UnityEngine.Vector3 get_velocity(UnityEngine.Rigidbody instance, string name)
		{
			return instance.velocity;
		}

		static private void set_velocity(UnityEngine.Rigidbody instance, string name, UnityEngine.Vector3 value)
		{
			instance.velocity = value;
		}

		static private System.Single get_sleepThreshold(UnityEngine.Rigidbody instance, string name)
		{
			return instance.sleepThreshold;
		}

		static private void set_sleepThreshold(UnityEngine.Rigidbody instance, string name, System.Single value)
		{
			instance.sleepThreshold = value;
		}

		static private System.Int32 get_solverIterations(UnityEngine.Rigidbody instance, string name)
		{
			return instance.solverIterations;
		}

		static private void set_solverIterations(UnityEngine.Rigidbody instance, string name, System.Int32 value)
		{
			instance.solverIterations = value;
		}

		static private UnityEngine.RigidbodyInterpolation get_interpolation(UnityEngine.Rigidbody instance, string name)
		{
			return instance.interpolation;
		}

		static private void set_interpolation(UnityEngine.Rigidbody instance, string name, UnityEngine.RigidbodyInterpolation value)
		{
			instance.interpolation = value;
		}

		static private UnityEngine.Quaternion get_rotation(UnityEngine.Rigidbody instance, string name)
		{
			return instance.rotation;
		}

		static private void set_rotation(UnityEngine.Rigidbody instance, string name, UnityEngine.Quaternion value)
		{
			instance.rotation = value;
		}

		static private UnityEngine.Vector3 get_position(UnityEngine.Rigidbody instance, string name)
		{
			return instance.position;
		}

		static private void set_position(UnityEngine.Rigidbody instance, string name, UnityEngine.Vector3 value)
		{
			instance.position = value;
		}

		static private System.Boolean get_detectCollisions(UnityEngine.Rigidbody instance, string name)
		{
			return instance.detectCollisions;
		}

		static private void set_detectCollisions(UnityEngine.Rigidbody instance, string name, System.Boolean value)
		{
			instance.detectCollisions = value;
		}

		static private UnityEngine.Vector3 get_inertiaTensor(UnityEngine.Rigidbody instance, string name)
		{
			return instance.inertiaTensor;
		}

		static private void set_inertiaTensor(UnityEngine.Rigidbody instance, string name, UnityEngine.Vector3 value)
		{
			instance.inertiaTensor = value;
		}

		static private UnityEngine.Quaternion get_inertiaTensorRotation(UnityEngine.Rigidbody instance, string name)
		{
			return instance.inertiaTensorRotation;
		}

		static private void set_inertiaTensorRotation(UnityEngine.Rigidbody instance, string name, UnityEngine.Quaternion value)
		{
			instance.inertiaTensorRotation = value;
		}

		static private UnityEngine.Vector3 get_worldCenterOfMass(UnityEngine.Rigidbody instance, string name)
		{
			return instance.worldCenterOfMass;
		}

		static private System.Single get_maxAngularVelocity(UnityEngine.Rigidbody instance, string name)
		{
			return instance.maxAngularVelocity;
		}

		static private void set_maxAngularVelocity(UnityEngine.Rigidbody instance, string name, System.Single value)
		{
			instance.maxAngularVelocity = value;
		}

		static private UnityEngine.Vector3 get_centerOfMass(UnityEngine.Rigidbody instance, string name)
		{
			return instance.centerOfMass;
		}

		static private void set_centerOfMass(UnityEngine.Rigidbody instance, string name, UnityEngine.Vector3 value)
		{
			instance.centerOfMass = value;
		}

		static private UnityEngine.RigidbodyConstraints get_constraints(UnityEngine.Rigidbody instance, string name)
		{
			return instance.constraints;
		}

		static private void set_constraints(UnityEngine.Rigidbody instance, string name, UnityEngine.RigidbodyConstraints value)
		{
			instance.constraints = value;
		}

		static private System.Boolean get_freezeRotation(UnityEngine.Rigidbody instance, string name)
		{
			return instance.freezeRotation;
		}

		static private void set_freezeRotation(UnityEngine.Rigidbody instance, string name, System.Boolean value)
		{
			instance.freezeRotation = value;
		}

		static private System.Boolean get_isKinematic(UnityEngine.Rigidbody instance, string name)
		{
			return instance.isKinematic;
		}

		static private void set_isKinematic(UnityEngine.Rigidbody instance, string name, System.Boolean value)
		{
			instance.isKinematic = value;
		}

		static private System.Single get_maxDepenetrationVelocity(UnityEngine.Rigidbody instance, string name)
		{
			return instance.maxDepenetrationVelocity;
		}

		static private void set_maxDepenetrationVelocity(UnityEngine.Rigidbody instance, string name, System.Single value)
		{
			instance.maxDepenetrationVelocity = value;
		}

		static private System.Boolean get_useGravity(UnityEngine.Rigidbody instance, string name)
		{
			return instance.useGravity;
		}

		static private void set_useGravity(UnityEngine.Rigidbody instance, string name, System.Boolean value)
		{
			instance.useGravity = value;
		}

		static private System.Single get_mass(UnityEngine.Rigidbody instance, string name)
		{
			return instance.mass;
		}

		static private void set_mass(UnityEngine.Rigidbody instance, string name, System.Single value)
		{
			instance.mass = value;
		}

		static private System.Single get_angularDrag(UnityEngine.Rigidbody instance, string name)
		{
			return instance.angularDrag;
		}

		static private void set_angularDrag(UnityEngine.Rigidbody instance, string name, System.Single value)
		{
			instance.angularDrag = value;
		}

		static private System.Single get_drag(UnityEngine.Rigidbody instance, string name)
		{
			return instance.drag;
		}

		static private void set_drag(UnityEngine.Rigidbody instance, string name, System.Single value)
		{
			instance.drag = value;
		}

		static private UnityEngine.Vector3 get_angularVelocity(UnityEngine.Rigidbody instance, string name)
		{
			return instance.angularVelocity;
		}

		static private void set_angularVelocity(UnityEngine.Rigidbody instance, string name, UnityEngine.Vector3 value)
		{
			instance.angularVelocity = value;
		}

		static private UnityEngine.CollisionDetectionMode get_collisionDetectionMode(UnityEngine.Rigidbody instance, string name)
		{
			return instance.collisionDetectionMode;
		}

		static private void set_collisionDetectionMode(UnityEngine.Rigidbody instance, string name, UnityEngine.CollisionDetectionMode value)
		{
			instance.collisionDetectionMode = value;
		}

		static private System.Int32 get_solverVelocityIterations(UnityEngine.Rigidbody instance, string name)
		{
			return instance.solverVelocityIterations;
		}

		static private void set_solverVelocityIterations(UnityEngine.Rigidbody instance, string name, System.Int32 value)
		{
			instance.solverVelocityIterations = value;
		}

	}
}
