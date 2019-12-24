using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineGeometryUtility
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.GeometryUtility> self = space.DeclareClass<UnityEngine.GeometryUtility>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("CalculateBounds", CalculateBounds);
			self.BindStaticFunction("CalculateFrustumPlanes", CalculateFrustumPlanes);
			self.BindStaticFunction("TestPlanesAABB", TestPlanesAABB);
		}

		static private UnityEngine.GeometryUtility Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.GeometryUtility();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.GeometryUtility.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.GeometryUtility);
		}

		static private UnityEngine.Bounds CalculateBounds(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3[], UnityEngine.Matrix4x4>())
			{
				return UnityEngine.GeometryUtility.CalculateBounds(parameters[0].ToObject<UnityEngine.Vector3[]>(), parameters[1].ToObject<UnityEngine.Matrix4x4>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GeometryUtility.CalculateBounds has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GeometryUtility.CalculateBounds has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Bounds);
		}

		static private System.Object CalculateFrustumPlanes(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Camera>())
			{
				return UnityEngine.GeometryUtility.CalculateFrustumPlanes(parameters[0].ToObject<UnityEngine.Camera>());
			}
			if (parameters.CheckTypes<UnityEngine.Matrix4x4>())
			{
				return UnityEngine.GeometryUtility.CalculateFrustumPlanes(parameters[0].ToObject<UnityEngine.Matrix4x4>());
			}
			if (parameters.CheckTypes<UnityEngine.Camera, UnityEngine.Plane[]>())
			{
				UnityEngine.GeometryUtility.CalculateFrustumPlanes(parameters[0].ToObject<UnityEngine.Camera>(), parameters[1].ToObject<UnityEngine.Plane[]>());
				return default(System.Object);
			}
			if (parameters.CheckTypes<UnityEngine.Matrix4x4, UnityEngine.Plane[]>())
			{
				UnityEngine.GeometryUtility.CalculateFrustumPlanes(parameters[0].ToObject<UnityEngine.Matrix4x4>(), parameters[1].ToObject<UnityEngine.Plane[]>());
				return default(System.Object);
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GeometryUtility.CalculateFrustumPlanes has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GeometryUtility.CalculateFrustumPlanes has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Boolean TestPlanesAABB(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Plane[], UnityEngine.Bounds>())
			{
				return UnityEngine.GeometryUtility.TestPlanesAABB(parameters[0].ToObject<UnityEngine.Plane[]>(), parameters[1].ToObject<UnityEngine.Bounds>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GeometryUtility.TestPlanesAABB has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GeometryUtility.TestPlanesAABB has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

	}
}
