using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineContactPoint
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.ContactPoint> self = space.DeclareClass<UnityEngine.ContactPoint>();
			self.BindConstructor();
			self.BindInstanceProperty("point", get_point, null);
			self.BindInstanceProperty("normal", get_normal, null);
			self.BindInstanceProperty("thisCollider", get_thisCollider, null);
			self.BindInstanceProperty("otherCollider", get_otherCollider, null);
			self.BindInstanceProperty("separation", get_separation, null);
		}

		static private UnityEngine.Vector3 get_point(UnityEngine.ContactPoint instance, string name)
		{
			return instance.point;
		}

		static private UnityEngine.Vector3 get_normal(UnityEngine.ContactPoint instance, string name)
		{
			return instance.normal;
		}

		static private UnityEngine.Collider get_thisCollider(UnityEngine.ContactPoint instance, string name)
		{
			return instance.thisCollider;
		}

		static private UnityEngine.Collider get_otherCollider(UnityEngine.ContactPoint instance, string name)
		{
			return instance.otherCollider;
		}

		static private System.Single get_separation(UnityEngine.ContactPoint instance, string name)
		{
			return instance.separation;
		}

	}
}
