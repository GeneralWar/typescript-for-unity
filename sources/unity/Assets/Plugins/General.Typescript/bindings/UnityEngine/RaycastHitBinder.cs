using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRaycastHit
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.RaycastHit> self = space.DeclareClass<UnityEngine.RaycastHit>();
			self.BindConstructor();
			self.BindInstanceProperty("collider", get_collider, null);
			self.BindInstanceProperty("point", get_point, set_point);
			self.BindInstanceProperty("normal", get_normal, set_normal);
			self.BindInstanceProperty("barycentricCoordinate", get_barycentricCoordinate, set_barycentricCoordinate);
			self.BindInstanceProperty("distance", get_distance, set_distance);
			self.BindInstanceProperty("triangleIndex", get_triangleIndex, null);
			self.BindInstanceProperty("textureCoord", get_textureCoord, null);
			self.BindInstanceProperty("textureCoord2", get_textureCoord2, null);
			self.BindInstanceProperty("transform", get_transform, null);
			self.BindInstanceProperty("rigidbody", get_rigidbody, null);
			self.BindInstanceProperty("lightmapCoord", get_lightmapCoord, null);
		}

		static private UnityEngine.Collider get_collider(UnityEngine.RaycastHit instance, string name)
		{
			return instance.collider;
		}

		static private UnityEngine.Vector3 get_point(UnityEngine.RaycastHit instance, string name)
		{
			return instance.point;
		}

		static private void set_point(UnityEngine.RaycastHit instance, string name, UnityEngine.Vector3 value)
		{
			instance.point = value;
		}

		static private UnityEngine.Vector3 get_normal(UnityEngine.RaycastHit instance, string name)
		{
			return instance.normal;
		}

		static private void set_normal(UnityEngine.RaycastHit instance, string name, UnityEngine.Vector3 value)
		{
			instance.normal = value;
		}

		static private UnityEngine.Vector3 get_barycentricCoordinate(UnityEngine.RaycastHit instance, string name)
		{
			return instance.barycentricCoordinate;
		}

		static private void set_barycentricCoordinate(UnityEngine.RaycastHit instance, string name, UnityEngine.Vector3 value)
		{
			instance.barycentricCoordinate = value;
		}

		static private System.Single get_distance(UnityEngine.RaycastHit instance, string name)
		{
			return instance.distance;
		}

		static private void set_distance(UnityEngine.RaycastHit instance, string name, System.Single value)
		{
			instance.distance = value;
		}

		static private System.Int32 get_triangleIndex(UnityEngine.RaycastHit instance, string name)
		{
			return instance.triangleIndex;
		}

		static private UnityEngine.Vector2 get_textureCoord(UnityEngine.RaycastHit instance, string name)
		{
			return instance.textureCoord;
		}

		static private UnityEngine.Vector2 get_textureCoord2(UnityEngine.RaycastHit instance, string name)
		{
			return instance.textureCoord2;
		}

		static private UnityEngine.Transform get_transform(UnityEngine.RaycastHit instance, string name)
		{
			return instance.transform;
		}

		static private UnityEngine.Rigidbody get_rigidbody(UnityEngine.RaycastHit instance, string name)
		{
			return instance.rigidbody;
		}

		static private UnityEngine.Vector2 get_lightmapCoord(UnityEngine.RaycastHit instance, string name)
		{
			return instance.lightmapCoord;
		}

	}
}
