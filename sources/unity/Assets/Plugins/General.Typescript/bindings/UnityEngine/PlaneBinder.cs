using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEnginePlane
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Plane> self = space.DeclareClass<UnityEngine.Plane>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("Translate", Translate);
			self.BindInstanceFunction("ClosestPointOnPlane", ClosestPointOnPlane);
			self.BindInstanceFunction("Flip", Flip);
			self.BindInstanceFunction("GetDistanceToPoint", GetDistanceToPoint);
			self.BindInstanceFunction("GetSide", GetSide);
			self.BindInstanceFunction("SameSide", SameSide);
			self.BindInstanceFunction("Set3Points", Set3Points);
			self.BindInstanceFunction("SetNormalAndPosition", SetNormalAndPosition);
			self.BindInstanceFunction("ToString", ToString);
			self.BindInstanceFunction("Translate", Translate);
			self.BindInstanceProperty("normal", get_normal, set_normal);
			self.BindInstanceProperty("distance", get_distance, set_distance);
			self.BindInstanceProperty("flipped", get_flipped, null);
		}

		static private UnityEngine.Plane Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3>())
			{
				return new UnityEngine.Plane(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, System.Single>())
			{
				return new UnityEngine.Plane(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3>())
			{
				return new UnityEngine.Plane(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Plane.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Plane.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Plane);
		}

		static private UnityEngine.Plane Translate(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Plane, UnityEngine.Vector3>())
			{
				return UnityEngine.Plane.Translate(parameters[0].ToObject<UnityEngine.Plane>(), parameters[1].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Plane.Translate has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Plane.Translate has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Plane);
		}

		static private UnityEngine.Vector3 ClosestPointOnPlane(UnityEngine.Plane instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.ClosestPointOnPlane(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Plane.ClosestPointOnPlane has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Plane.ClosestPointOnPlane has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private void Flip(UnityEngine.Plane instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Flip();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Plane.Flip has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Single GetDistanceToPoint(UnityEngine.Plane instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.GetDistanceToPoint(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Plane.GetDistanceToPoint has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Plane.GetDistanceToPoint has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Boolean GetSide(UnityEngine.Plane instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.GetSide(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Plane.GetSide has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Plane.GetSide has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean SameSide(UnityEngine.Plane instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3>())
			{
				return instance.SameSide(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Plane.SameSide has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Plane.SameSide has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void Set3Points(UnityEngine.Plane instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3>())
			{
				instance.Set3Points(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Plane.Set3Points has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Plane.Set3Points has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetNormalAndPosition(UnityEngine.Plane instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3>())
			{
				instance.SetNormalAndPosition(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Plane.SetNormalAndPosition has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Plane.SetNormalAndPosition has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.String ToString(UnityEngine.Plane instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ToString();
			}
			if (parameters.CheckTypes<System.String>())
			{
				return instance.ToString(parameters[0].ToObject<System.String>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Plane.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private void Translate(UnityEngine.Plane instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				instance.Translate(parameters[0].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Plane.Translate has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Plane.Translate has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Vector3 get_normal(UnityEngine.Plane instance, string name)
		{
			return instance.normal;
		}

		static private void set_normal(UnityEngine.Plane instance, string name, UnityEngine.Vector3 value)
		{
			instance.normal = value;
		}

		static private System.Single get_distance(UnityEngine.Plane instance, string name)
		{
			return instance.distance;
		}

		static private void set_distance(UnityEngine.Plane instance, string name, System.Single value)
		{
			instance.distance = value;
		}

		static private UnityEngine.Plane get_flipped(UnityEngine.Plane instance, string name)
		{
			return instance.flipped;
		}

	}
}
