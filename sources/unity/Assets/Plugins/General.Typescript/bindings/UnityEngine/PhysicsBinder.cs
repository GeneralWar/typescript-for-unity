using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEnginePhysics
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Physics> self = space.DeclareClass<UnityEngine.Physics>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("BoxCast", BoxCast);
			self.BindStaticFunction("BoxCastAll", BoxCastAll);
			self.BindStaticFunction("BoxCastNonAlloc", BoxCastNonAlloc);
			self.BindStaticFunction("CapsuleCast", CapsuleCast);
			self.BindStaticFunction("CapsuleCastAll", CapsuleCastAll);
			self.BindStaticFunction("CapsuleCastNonAlloc", CapsuleCastNonAlloc);
			self.BindStaticFunction("CheckBox", CheckBox);
			self.BindStaticFunction("CheckCapsule", CheckCapsule);
			self.BindStaticFunction("CheckSphere", CheckSphere);
			self.BindStaticFunction("ClosestPoint", ClosestPoint);
			self.BindStaticFunction("GetIgnoreLayerCollision", GetIgnoreLayerCollision);
			self.BindStaticFunction("IgnoreCollision", IgnoreCollision);
			self.BindStaticFunction("IgnoreLayerCollision", IgnoreLayerCollision);
			self.BindStaticFunction("Linecast", Linecast);
			self.BindStaticFunction("OverlapBox", OverlapBox);
			self.BindStaticFunction("OverlapBoxNonAlloc", OverlapBoxNonAlloc);
			self.BindStaticFunction("OverlapCapsule", OverlapCapsule);
			self.BindStaticFunction("OverlapCapsuleNonAlloc", OverlapCapsuleNonAlloc);
			self.BindStaticFunction("OverlapSphere", OverlapSphere);
			self.BindStaticFunction("OverlapSphereNonAlloc", OverlapSphereNonAlloc);
			self.BindStaticFunction("Raycast", Raycast);
			self.BindStaticFunction("RaycastAll", RaycastAll);
			self.BindStaticFunction("RaycastNonAlloc", RaycastNonAlloc);
			self.BindStaticFunction("RebuildBroadphaseRegions", RebuildBroadphaseRegions);
			self.BindStaticFunction("Simulate", Simulate);
			self.BindStaticFunction("SphereCast", SphereCast);
			self.BindStaticFunction("SphereCastAll", SphereCastAll);
			self.BindStaticFunction("SphereCastNonAlloc", SphereCastNonAlloc);
			self.BindStaticFunction("SyncTransforms", SyncTransforms);
			self.BindStaticProperty("gravity", get_gravity, set_gravity);
			self.BindStaticProperty("defaultContactOffset", get_defaultContactOffset, set_defaultContactOffset);
			self.BindStaticProperty("sleepThreshold", get_sleepThreshold, set_sleepThreshold);
			self.BindStaticProperty("queriesHitTriggers", get_queriesHitTriggers, set_queriesHitTriggers);
			self.BindStaticProperty("queriesHitBackfaces", get_queriesHitBackfaces, set_queriesHitBackfaces);
			self.BindStaticProperty("bounceThreshold", get_bounceThreshold, set_bounceThreshold);
			self.BindStaticProperty("defaultSolverIterations", get_defaultSolverIterations, set_defaultSolverIterations);
			self.BindStaticProperty("defaultSolverVelocityIterations", get_defaultSolverVelocityIterations, set_defaultSolverVelocityIterations);
			self.BindStaticProperty("defaultPhysicsScene", get_defaultPhysicsScene, null);
			self.BindStaticProperty("autoSimulation", get_autoSimulation, set_autoSimulation);
			self.BindStaticProperty("autoSyncTransforms", get_autoSyncTransforms, set_autoSyncTransforms);
			self.BindStaticProperty("reuseCollisionCallbacks", get_reuseCollisionCallbacks, set_reuseCollisionCallbacks);
			self.BindStaticProperty("interCollisionDistance", get_interCollisionDistance, set_interCollisionDistance);
			self.BindStaticProperty("interCollisionStiffness", get_interCollisionStiffness, set_interCollisionStiffness);
			self.BindStaticProperty("interCollisionSettingsToggle", get_interCollisionSettingsToggle, set_interCollisionSettingsToggle);
		}

		static private UnityEngine.Physics Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Physics();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Physics.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Physics);
		}

		static private System.Boolean BoxCast(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3>())
			{
				return UnityEngine.Physics.BoxCast(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Vector3>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Quaternion>())
			{
				return UnityEngine.Physics.BoxCast(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Vector3>(), parameters[3].ToObject<UnityEngine.Quaternion>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Quaternion, System.Single>())
			{
				return UnityEngine.Physics.BoxCast(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Vector3>(), parameters[3].ToObject<UnityEngine.Quaternion>(), parameters[4].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Quaternion, System.Single, System.Int32>())
			{
				return UnityEngine.Physics.BoxCast(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Vector3>(), parameters[3].ToObject<UnityEngine.Quaternion>(), parameters[4].ToObject<System.Single>(), parameters[5].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Quaternion, System.Single, System.Int32, UnityEngine.QueryTriggerInteraction>())
			{
				return UnityEngine.Physics.BoxCast(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Vector3>(), parameters[3].ToObject<UnityEngine.Quaternion>(), parameters[4].ToObject<System.Single>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.QueryTriggerInteraction>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Physics.BoxCast has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Physics.BoxCast has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private UnityEngine.RaycastHit[] BoxCastAll(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3>())
			{
				return UnityEngine.Physics.BoxCastAll(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Vector3>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Quaternion>())
			{
				return UnityEngine.Physics.BoxCastAll(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Vector3>(), parameters[3].ToObject<UnityEngine.Quaternion>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Quaternion, System.Single>())
			{
				return UnityEngine.Physics.BoxCastAll(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Vector3>(), parameters[3].ToObject<UnityEngine.Quaternion>(), parameters[4].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Quaternion, System.Single, System.Int32>())
			{
				return UnityEngine.Physics.BoxCastAll(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Vector3>(), parameters[3].ToObject<UnityEngine.Quaternion>(), parameters[4].ToObject<System.Single>(), parameters[5].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Quaternion, System.Single, System.Int32, UnityEngine.QueryTriggerInteraction>())
			{
				return UnityEngine.Physics.BoxCastAll(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Vector3>(), parameters[3].ToObject<UnityEngine.Quaternion>(), parameters[4].ToObject<System.Single>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.QueryTriggerInteraction>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Physics.BoxCastAll has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Physics.BoxCastAll has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Int32 BoxCastNonAlloc(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.RaycastHit[]>())
			{
				return UnityEngine.Physics.BoxCastNonAlloc(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Vector3>(), parameters[3].ToObject<UnityEngine.RaycastHit[]>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.RaycastHit[], UnityEngine.Quaternion>())
			{
				return UnityEngine.Physics.BoxCastNonAlloc(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Vector3>(), parameters[3].ToObject<UnityEngine.RaycastHit[]>(), parameters[4].ToObject<UnityEngine.Quaternion>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.RaycastHit[], UnityEngine.Quaternion, System.Single>())
			{
				return UnityEngine.Physics.BoxCastNonAlloc(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Vector3>(), parameters[3].ToObject<UnityEngine.RaycastHit[]>(), parameters[4].ToObject<UnityEngine.Quaternion>(), parameters[5].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.RaycastHit[], UnityEngine.Quaternion, System.Single, System.Int32>())
			{
				return UnityEngine.Physics.BoxCastNonAlloc(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Vector3>(), parameters[3].ToObject<UnityEngine.RaycastHit[]>(), parameters[4].ToObject<UnityEngine.Quaternion>(), parameters[5].ToObject<System.Single>(), parameters[6].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.RaycastHit[], UnityEngine.Quaternion, System.Single, System.Int32, UnityEngine.QueryTriggerInteraction>())
			{
				return UnityEngine.Physics.BoxCastNonAlloc(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Vector3>(), parameters[3].ToObject<UnityEngine.RaycastHit[]>(), parameters[4].ToObject<UnityEngine.Quaternion>(), parameters[5].ToObject<System.Single>(), parameters[6].ToObject<System.Int32>(), parameters[7].ToObject<UnityEngine.QueryTriggerInteraction>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Physics.BoxCastNonAlloc has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Physics.BoxCastNonAlloc has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Boolean CapsuleCast(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single, UnityEngine.Vector3>())
			{
				return UnityEngine.Physics.CapsuleCast(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<UnityEngine.Vector3>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single, UnityEngine.Vector3, System.Single>())
			{
				return UnityEngine.Physics.CapsuleCast(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<UnityEngine.Vector3>(), parameters[4].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single, UnityEngine.Vector3, System.Single, System.Int32>())
			{
				return UnityEngine.Physics.CapsuleCast(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<UnityEngine.Vector3>(), parameters[4].ToObject<System.Single>(), parameters[5].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single, UnityEngine.Vector3, System.Single, System.Int32, UnityEngine.QueryTriggerInteraction>())
			{
				return UnityEngine.Physics.CapsuleCast(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<UnityEngine.Vector3>(), parameters[4].ToObject<System.Single>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.QueryTriggerInteraction>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Physics.CapsuleCast has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Physics.CapsuleCast has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private UnityEngine.RaycastHit[] CapsuleCastAll(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single, UnityEngine.Vector3>())
			{
				return UnityEngine.Physics.CapsuleCastAll(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<UnityEngine.Vector3>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single, UnityEngine.Vector3, System.Single>())
			{
				return UnityEngine.Physics.CapsuleCastAll(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<UnityEngine.Vector3>(), parameters[4].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single, UnityEngine.Vector3, System.Single, System.Int32>())
			{
				return UnityEngine.Physics.CapsuleCastAll(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<UnityEngine.Vector3>(), parameters[4].ToObject<System.Single>(), parameters[5].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single, UnityEngine.Vector3, System.Single, System.Int32, UnityEngine.QueryTriggerInteraction>())
			{
				return UnityEngine.Physics.CapsuleCastAll(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<UnityEngine.Vector3>(), parameters[4].ToObject<System.Single>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.QueryTriggerInteraction>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Physics.CapsuleCastAll has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Physics.CapsuleCastAll has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Int32 CapsuleCastNonAlloc(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single, UnityEngine.Vector3, UnityEngine.RaycastHit[]>())
			{
				return UnityEngine.Physics.CapsuleCastNonAlloc(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<UnityEngine.Vector3>(), parameters[4].ToObject<UnityEngine.RaycastHit[]>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single, UnityEngine.Vector3, UnityEngine.RaycastHit[], System.Single>())
			{
				return UnityEngine.Physics.CapsuleCastNonAlloc(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<UnityEngine.Vector3>(), parameters[4].ToObject<UnityEngine.RaycastHit[]>(), parameters[5].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single, UnityEngine.Vector3, UnityEngine.RaycastHit[], System.Single, System.Int32>())
			{
				return UnityEngine.Physics.CapsuleCastNonAlloc(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<UnityEngine.Vector3>(), parameters[4].ToObject<UnityEngine.RaycastHit[]>(), parameters[5].ToObject<System.Single>(), parameters[6].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single, UnityEngine.Vector3, UnityEngine.RaycastHit[], System.Single, System.Int32, UnityEngine.QueryTriggerInteraction>())
			{
				return UnityEngine.Physics.CapsuleCastNonAlloc(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<UnityEngine.Vector3>(), parameters[4].ToObject<UnityEngine.RaycastHit[]>(), parameters[5].ToObject<System.Single>(), parameters[6].ToObject<System.Int32>(), parameters[7].ToObject<UnityEngine.QueryTriggerInteraction>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Physics.CapsuleCastNonAlloc has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Physics.CapsuleCastNonAlloc has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Boolean CheckBox(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3>())
			{
				return UnityEngine.Physics.CheckBox(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Quaternion>())
			{
				return UnityEngine.Physics.CheckBox(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Quaternion>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Quaternion, System.Int32>())
			{
				return UnityEngine.Physics.CheckBox(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Quaternion>(), parameters[3].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Quaternion, System.Int32, UnityEngine.QueryTriggerInteraction>())
			{
				return UnityEngine.Physics.CheckBox(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Quaternion>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.QueryTriggerInteraction>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Physics.CheckBox has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Physics.CheckBox has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean CheckCapsule(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single>())
			{
				return UnityEngine.Physics.CheckCapsule(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single, System.Int32>())
			{
				return UnityEngine.Physics.CheckCapsule(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single, System.Int32, UnityEngine.QueryTriggerInteraction>())
			{
				return UnityEngine.Physics.CheckCapsule(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.QueryTriggerInteraction>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Physics.CheckCapsule has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Physics.CheckCapsule has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean CheckSphere(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, System.Single>())
			{
				return UnityEngine.Physics.CheckSphere(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, System.Single, System.Int32>())
			{
				return UnityEngine.Physics.CheckSphere(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, System.Single, System.Int32, UnityEngine.QueryTriggerInteraction>())
			{
				return UnityEngine.Physics.CheckSphere(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.QueryTriggerInteraction>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Physics.CheckSphere has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Physics.CheckSphere has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private UnityEngine.Vector3 ClosestPoint(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Collider, UnityEngine.Vector3, UnityEngine.Quaternion>())
			{
				return UnityEngine.Physics.ClosestPoint(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Collider>(), parameters[2].ToObject<UnityEngine.Vector3>(), parameters[3].ToObject<UnityEngine.Quaternion>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Physics.ClosestPoint has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Physics.ClosestPoint has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private System.Boolean GetIgnoreLayerCollision(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				return UnityEngine.Physics.GetIgnoreLayerCollision(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Physics.GetIgnoreLayerCollision has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Physics.GetIgnoreLayerCollision has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void IgnoreCollision(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Collider, UnityEngine.Collider>())
			{
				UnityEngine.Physics.IgnoreCollision(parameters[0].ToObject<UnityEngine.Collider>(), parameters[1].ToObject<UnityEngine.Collider>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Collider, UnityEngine.Collider, System.Boolean>())
			{
				UnityEngine.Physics.IgnoreCollision(parameters[0].ToObject<UnityEngine.Collider>(), parameters[1].ToObject<UnityEngine.Collider>(), parameters[2].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Physics.IgnoreCollision has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Physics.IgnoreCollision has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void IgnoreLayerCollision(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				UnityEngine.Physics.IgnoreLayerCollision(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Boolean>())
			{
				UnityEngine.Physics.IgnoreLayerCollision(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Physics.IgnoreLayerCollision has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Physics.IgnoreLayerCollision has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean Linecast(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3>())
			{
				return UnityEngine.Physics.Linecast(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Int32>())
			{
				return UnityEngine.Physics.Linecast(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Int32, UnityEngine.QueryTriggerInteraction>())
			{
				return UnityEngine.Physics.Linecast(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.QueryTriggerInteraction>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Physics.Linecast has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Physics.Linecast has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private UnityEngine.Collider[] OverlapBox(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3>())
			{
				return UnityEngine.Physics.OverlapBox(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Quaternion>())
			{
				return UnityEngine.Physics.OverlapBox(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Quaternion>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Quaternion, System.Int32>())
			{
				return UnityEngine.Physics.OverlapBox(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Quaternion>(), parameters[3].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Quaternion, System.Int32, UnityEngine.QueryTriggerInteraction>())
			{
				return UnityEngine.Physics.OverlapBox(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Quaternion>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.QueryTriggerInteraction>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Physics.OverlapBox has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Physics.OverlapBox has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Int32 OverlapBoxNonAlloc(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Collider[]>())
			{
				return UnityEngine.Physics.OverlapBoxNonAlloc(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Collider[]>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Collider[], UnityEngine.Quaternion>())
			{
				return UnityEngine.Physics.OverlapBoxNonAlloc(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Collider[]>(), parameters[3].ToObject<UnityEngine.Quaternion>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Collider[], UnityEngine.Quaternion, System.Int32>())
			{
				return UnityEngine.Physics.OverlapBoxNonAlloc(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Collider[]>(), parameters[3].ToObject<UnityEngine.Quaternion>(), parameters[4].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Collider[], UnityEngine.Quaternion, System.Int32, UnityEngine.QueryTriggerInteraction>())
			{
				return UnityEngine.Physics.OverlapBoxNonAlloc(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Collider[]>(), parameters[3].ToObject<UnityEngine.Quaternion>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<UnityEngine.QueryTriggerInteraction>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Physics.OverlapBoxNonAlloc has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Physics.OverlapBoxNonAlloc has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private UnityEngine.Collider[] OverlapCapsule(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single>())
			{
				return UnityEngine.Physics.OverlapCapsule(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single, System.Int32>())
			{
				return UnityEngine.Physics.OverlapCapsule(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single, System.Int32, UnityEngine.QueryTriggerInteraction>())
			{
				return UnityEngine.Physics.OverlapCapsule(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.QueryTriggerInteraction>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Physics.OverlapCapsule has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Physics.OverlapCapsule has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Int32 OverlapCapsuleNonAlloc(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single, UnityEngine.Collider[]>())
			{
				return UnityEngine.Physics.OverlapCapsuleNonAlloc(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<UnityEngine.Collider[]>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single, UnityEngine.Collider[], System.Int32>())
			{
				return UnityEngine.Physics.OverlapCapsuleNonAlloc(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<UnityEngine.Collider[]>(), parameters[4].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single, UnityEngine.Collider[], System.Int32, UnityEngine.QueryTriggerInteraction>())
			{
				return UnityEngine.Physics.OverlapCapsuleNonAlloc(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<UnityEngine.Collider[]>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<UnityEngine.QueryTriggerInteraction>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Physics.OverlapCapsuleNonAlloc has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Physics.OverlapCapsuleNonAlloc has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private UnityEngine.Collider[] OverlapSphere(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, System.Single>())
			{
				return UnityEngine.Physics.OverlapSphere(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, System.Single, System.Int32>())
			{
				return UnityEngine.Physics.OverlapSphere(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, System.Single, System.Int32, UnityEngine.QueryTriggerInteraction>())
			{
				return UnityEngine.Physics.OverlapSphere(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.QueryTriggerInteraction>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Physics.OverlapSphere has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Physics.OverlapSphere has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Int32 OverlapSphereNonAlloc(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, System.Single, UnityEngine.Collider[]>())
			{
				return UnityEngine.Physics.OverlapSphereNonAlloc(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<UnityEngine.Collider[]>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, System.Single, UnityEngine.Collider[], System.Int32>())
			{
				return UnityEngine.Physics.OverlapSphereNonAlloc(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<UnityEngine.Collider[]>(), parameters[3].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, System.Single, UnityEngine.Collider[], System.Int32, UnityEngine.QueryTriggerInteraction>())
			{
				return UnityEngine.Physics.OverlapSphereNonAlloc(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<UnityEngine.Collider[]>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.QueryTriggerInteraction>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Physics.OverlapSphereNonAlloc has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Physics.OverlapSphereNonAlloc has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Boolean Raycast(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Ray>())
			{
				return UnityEngine.Physics.Raycast(parameters[0].ToObject<UnityEngine.Ray>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3>())
			{
				return UnityEngine.Physics.Raycast(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>());
			}
			if (parameters.CheckTypes<UnityEngine.Ray, System.Single>())
			{
				return UnityEngine.Physics.Raycast(parameters[0].ToObject<UnityEngine.Ray>(), parameters[1].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single>())
			{
				return UnityEngine.Physics.Raycast(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<UnityEngine.Ray, System.Single, System.Int32>())
			{
				return UnityEngine.Physics.Raycast(parameters[0].ToObject<UnityEngine.Ray>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single, System.Int32>())
			{
				return UnityEngine.Physics.Raycast(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Ray, System.Single, System.Int32, UnityEngine.QueryTriggerInteraction>())
			{
				return UnityEngine.Physics.Raycast(parameters[0].ToObject<UnityEngine.Ray>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.QueryTriggerInteraction>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single, System.Int32, UnityEngine.QueryTriggerInteraction>())
			{
				return UnityEngine.Physics.Raycast(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.QueryTriggerInteraction>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Physics.Raycast has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Physics.Raycast has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private UnityEngine.RaycastHit[] RaycastAll(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Ray>())
			{
				return UnityEngine.Physics.RaycastAll(parameters[0].ToObject<UnityEngine.Ray>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3>())
			{
				return UnityEngine.Physics.RaycastAll(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>());
			}
			if (parameters.CheckTypes<UnityEngine.Ray, System.Single>())
			{
				return UnityEngine.Physics.RaycastAll(parameters[0].ToObject<UnityEngine.Ray>(), parameters[1].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single>())
			{
				return UnityEngine.Physics.RaycastAll(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<UnityEngine.Ray, System.Single, System.Int32>())
			{
				return UnityEngine.Physics.RaycastAll(parameters[0].ToObject<UnityEngine.Ray>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single, System.Int32>())
			{
				return UnityEngine.Physics.RaycastAll(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Ray, System.Single, System.Int32, UnityEngine.QueryTriggerInteraction>())
			{
				return UnityEngine.Physics.RaycastAll(parameters[0].ToObject<UnityEngine.Ray>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.QueryTriggerInteraction>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single, System.Int32, UnityEngine.QueryTriggerInteraction>())
			{
				return UnityEngine.Physics.RaycastAll(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.QueryTriggerInteraction>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Physics.RaycastAll has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Physics.RaycastAll has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Int32 RaycastNonAlloc(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Ray, UnityEngine.RaycastHit[]>())
			{
				return UnityEngine.Physics.RaycastNonAlloc(parameters[0].ToObject<UnityEngine.Ray>(), parameters[1].ToObject<UnityEngine.RaycastHit[]>());
			}
			if (parameters.CheckTypes<UnityEngine.Ray, UnityEngine.RaycastHit[], System.Single>())
			{
				return UnityEngine.Physics.RaycastNonAlloc(parameters[0].ToObject<UnityEngine.Ray>(), parameters[1].ToObject<UnityEngine.RaycastHit[]>(), parameters[2].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.RaycastHit[]>())
			{
				return UnityEngine.Physics.RaycastNonAlloc(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.RaycastHit[]>());
			}
			if (parameters.CheckTypes<UnityEngine.Ray, UnityEngine.RaycastHit[], System.Single, System.Int32>())
			{
				return UnityEngine.Physics.RaycastNonAlloc(parameters[0].ToObject<UnityEngine.Ray>(), parameters[1].ToObject<UnityEngine.RaycastHit[]>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.RaycastHit[], System.Single>())
			{
				return UnityEngine.Physics.RaycastNonAlloc(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.RaycastHit[]>(), parameters[3].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<UnityEngine.Ray, UnityEngine.RaycastHit[], System.Single, System.Int32, UnityEngine.QueryTriggerInteraction>())
			{
				return UnityEngine.Physics.RaycastNonAlloc(parameters[0].ToObject<UnityEngine.Ray>(), parameters[1].ToObject<UnityEngine.RaycastHit[]>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.QueryTriggerInteraction>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.RaycastHit[], System.Single, System.Int32>())
			{
				return UnityEngine.Physics.RaycastNonAlloc(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.RaycastHit[]>(), parameters[3].ToObject<System.Single>(), parameters[4].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.RaycastHit[], System.Single, System.Int32, UnityEngine.QueryTriggerInteraction>())
			{
				return UnityEngine.Physics.RaycastNonAlloc(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.RaycastHit[]>(), parameters[3].ToObject<System.Single>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<UnityEngine.QueryTriggerInteraction>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Physics.RaycastNonAlloc has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Physics.RaycastNonAlloc has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private void RebuildBroadphaseRegions(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Bounds, System.Int32>())
			{
				UnityEngine.Physics.RebuildBroadphaseRegions(parameters[0].ToObject<UnityEngine.Bounds>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Physics.RebuildBroadphaseRegions has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Physics.RebuildBroadphaseRegions has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Simulate(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				UnityEngine.Physics.Simulate(parameters[0].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Physics.Simulate has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Physics.Simulate has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean SphereCast(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Ray, System.Single>())
			{
				return UnityEngine.Physics.SphereCast(parameters[0].ToObject<UnityEngine.Ray>(), parameters[1].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<UnityEngine.Ray, System.Single, System.Single>())
			{
				return UnityEngine.Physics.SphereCast(parameters[0].ToObject<UnityEngine.Ray>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<UnityEngine.Ray, System.Single, System.Single, System.Int32>())
			{
				return UnityEngine.Physics.SphereCast(parameters[0].ToObject<UnityEngine.Ray>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Ray, System.Single, System.Single, System.Int32, UnityEngine.QueryTriggerInteraction>())
			{
				return UnityEngine.Physics.SphereCast(parameters[0].ToObject<UnityEngine.Ray>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.QueryTriggerInteraction>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Physics.SphereCast has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Physics.SphereCast has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private UnityEngine.RaycastHit[] SphereCastAll(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Ray, System.Single>())
			{
				return UnityEngine.Physics.SphereCastAll(parameters[0].ToObject<UnityEngine.Ray>(), parameters[1].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, System.Single, UnityEngine.Vector3>())
			{
				return UnityEngine.Physics.SphereCastAll(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<UnityEngine.Vector3>());
			}
			if (parameters.CheckTypes<UnityEngine.Ray, System.Single, System.Single>())
			{
				return UnityEngine.Physics.SphereCastAll(parameters[0].ToObject<UnityEngine.Ray>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, System.Single, UnityEngine.Vector3, System.Single>())
			{
				return UnityEngine.Physics.SphereCastAll(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<UnityEngine.Vector3>(), parameters[3].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<UnityEngine.Ray, System.Single, System.Single, System.Int32>())
			{
				return UnityEngine.Physics.SphereCastAll(parameters[0].ToObject<UnityEngine.Ray>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, System.Single, UnityEngine.Vector3, System.Single, System.Int32>())
			{
				return UnityEngine.Physics.SphereCastAll(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<UnityEngine.Vector3>(), parameters[3].ToObject<System.Single>(), parameters[4].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Ray, System.Single, System.Single, System.Int32, UnityEngine.QueryTriggerInteraction>())
			{
				return UnityEngine.Physics.SphereCastAll(parameters[0].ToObject<UnityEngine.Ray>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.QueryTriggerInteraction>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, System.Single, UnityEngine.Vector3, System.Single, System.Int32, UnityEngine.QueryTriggerInteraction>())
			{
				return UnityEngine.Physics.SphereCastAll(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<UnityEngine.Vector3>(), parameters[3].ToObject<System.Single>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<UnityEngine.QueryTriggerInteraction>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Physics.SphereCastAll has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Physics.SphereCastAll has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Int32 SphereCastNonAlloc(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Ray, System.Single, UnityEngine.RaycastHit[]>())
			{
				return UnityEngine.Physics.SphereCastNonAlloc(parameters[0].ToObject<UnityEngine.Ray>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<UnityEngine.RaycastHit[]>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, System.Single, UnityEngine.Vector3, UnityEngine.RaycastHit[]>())
			{
				return UnityEngine.Physics.SphereCastNonAlloc(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<UnityEngine.Vector3>(), parameters[3].ToObject<UnityEngine.RaycastHit[]>());
			}
			if (parameters.CheckTypes<UnityEngine.Ray, System.Single, UnityEngine.RaycastHit[], System.Single>())
			{
				return UnityEngine.Physics.SphereCastNonAlloc(parameters[0].ToObject<UnityEngine.Ray>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<UnityEngine.RaycastHit[]>(), parameters[3].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, System.Single, UnityEngine.Vector3, UnityEngine.RaycastHit[], System.Single>())
			{
				return UnityEngine.Physics.SphereCastNonAlloc(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<UnityEngine.Vector3>(), parameters[3].ToObject<UnityEngine.RaycastHit[]>(), parameters[4].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<UnityEngine.Ray, System.Single, UnityEngine.RaycastHit[], System.Single, System.Int32>())
			{
				return UnityEngine.Physics.SphereCastNonAlloc(parameters[0].ToObject<UnityEngine.Ray>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<UnityEngine.RaycastHit[]>(), parameters[3].ToObject<System.Single>(), parameters[4].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, System.Single, UnityEngine.Vector3, UnityEngine.RaycastHit[], System.Single, System.Int32>())
			{
				return UnityEngine.Physics.SphereCastNonAlloc(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<UnityEngine.Vector3>(), parameters[3].ToObject<UnityEngine.RaycastHit[]>(), parameters[4].ToObject<System.Single>(), parameters[5].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Ray, System.Single, UnityEngine.RaycastHit[], System.Single, System.Int32, UnityEngine.QueryTriggerInteraction>())
			{
				return UnityEngine.Physics.SphereCastNonAlloc(parameters[0].ToObject<UnityEngine.Ray>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<UnityEngine.RaycastHit[]>(), parameters[3].ToObject<System.Single>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<UnityEngine.QueryTriggerInteraction>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, System.Single, UnityEngine.Vector3, UnityEngine.RaycastHit[], System.Single, System.Int32, UnityEngine.QueryTriggerInteraction>())
			{
				return UnityEngine.Physics.SphereCastNonAlloc(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<UnityEngine.Vector3>(), parameters[3].ToObject<UnityEngine.RaycastHit[]>(), parameters[4].ToObject<System.Single>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.QueryTriggerInteraction>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Physics.SphereCastNonAlloc has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Physics.SphereCastNonAlloc has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private void SyncTransforms(Type type, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.Physics.SyncTransforms();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Physics.SyncTransforms has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private UnityEngine.Vector3 get_gravity(Type type, string name)
		{
			return UnityEngine.Physics.gravity;
		}

		static private void set_gravity(Type type, string name, UnityEngine.Vector3 value)
		{
			UnityEngine.Physics.gravity = value;
		}

		static private System.Single get_defaultContactOffset(Type type, string name)
		{
			return UnityEngine.Physics.defaultContactOffset;
		}

		static private void set_defaultContactOffset(Type type, string name, System.Single value)
		{
			UnityEngine.Physics.defaultContactOffset = value;
		}

		static private System.Single get_sleepThreshold(Type type, string name)
		{
			return UnityEngine.Physics.sleepThreshold;
		}

		static private void set_sleepThreshold(Type type, string name, System.Single value)
		{
			UnityEngine.Physics.sleepThreshold = value;
		}

		static private System.Boolean get_queriesHitTriggers(Type type, string name)
		{
			return UnityEngine.Physics.queriesHitTriggers;
		}

		static private void set_queriesHitTriggers(Type type, string name, System.Boolean value)
		{
			UnityEngine.Physics.queriesHitTriggers = value;
		}

		static private System.Boolean get_queriesHitBackfaces(Type type, string name)
		{
			return UnityEngine.Physics.queriesHitBackfaces;
		}

		static private void set_queriesHitBackfaces(Type type, string name, System.Boolean value)
		{
			UnityEngine.Physics.queriesHitBackfaces = value;
		}

		static private System.Single get_bounceThreshold(Type type, string name)
		{
			return UnityEngine.Physics.bounceThreshold;
		}

		static private void set_bounceThreshold(Type type, string name, System.Single value)
		{
			UnityEngine.Physics.bounceThreshold = value;
		}

		static private System.Int32 get_defaultSolverIterations(Type type, string name)
		{
			return UnityEngine.Physics.defaultSolverIterations;
		}

		static private void set_defaultSolverIterations(Type type, string name, System.Int32 value)
		{
			UnityEngine.Physics.defaultSolverIterations = value;
		}

		static private System.Int32 get_defaultSolverVelocityIterations(Type type, string name)
		{
			return UnityEngine.Physics.defaultSolverVelocityIterations;
		}

		static private void set_defaultSolverVelocityIterations(Type type, string name, System.Int32 value)
		{
			UnityEngine.Physics.defaultSolverVelocityIterations = value;
		}

		static private UnityEngine.PhysicsScene get_defaultPhysicsScene(Type type, string name)
		{
			return UnityEngine.Physics.defaultPhysicsScene;
		}

		static private System.Boolean get_autoSimulation(Type type, string name)
		{
			return UnityEngine.Physics.autoSimulation;
		}

		static private void set_autoSimulation(Type type, string name, System.Boolean value)
		{
			UnityEngine.Physics.autoSimulation = value;
		}

		static private System.Boolean get_autoSyncTransforms(Type type, string name)
		{
			return UnityEngine.Physics.autoSyncTransforms;
		}

		static private void set_autoSyncTransforms(Type type, string name, System.Boolean value)
		{
			UnityEngine.Physics.autoSyncTransforms = value;
		}

		static private System.Boolean get_reuseCollisionCallbacks(Type type, string name)
		{
			return UnityEngine.Physics.reuseCollisionCallbacks;
		}

		static private void set_reuseCollisionCallbacks(Type type, string name, System.Boolean value)
		{
			UnityEngine.Physics.reuseCollisionCallbacks = value;
		}

		static private System.Single get_interCollisionDistance(Type type, string name)
		{
			return UnityEngine.Physics.interCollisionDistance;
		}

		static private void set_interCollisionDistance(Type type, string name, System.Single value)
		{
			UnityEngine.Physics.interCollisionDistance = value;
		}

		static private System.Single get_interCollisionStiffness(Type type, string name)
		{
			return UnityEngine.Physics.interCollisionStiffness;
		}

		static private void set_interCollisionStiffness(Type type, string name, System.Single value)
		{
			UnityEngine.Physics.interCollisionStiffness = value;
		}

		static private System.Boolean get_interCollisionSettingsToggle(Type type, string name)
		{
			return UnityEngine.Physics.interCollisionSettingsToggle;
		}

		static private void set_interCollisionSettingsToggle(Type type, string name, System.Boolean value)
		{
			UnityEngine.Physics.interCollisionSettingsToggle = value;
		}

	}
}
