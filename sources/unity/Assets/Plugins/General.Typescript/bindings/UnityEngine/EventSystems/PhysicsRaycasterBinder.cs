using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineEventSystemsPhysicsRaycaster
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.EventSystems.PhysicsRaycaster> self = space.DeclareClass<UnityEngine.EventSystems.PhysicsRaycaster, UnityEngine.EventSystems.BaseRaycaster>();
			self.BindConstructor();
			self.BindInstanceProperty("eventCamera", get_eventCamera, null);
			self.BindInstanceProperty("depth", get_depth, null);
			self.BindInstanceProperty("finalEventMask", get_finalEventMask, null);
			self.BindInstanceProperty("eventMask", get_eventMask, set_eventMask);
			self.BindInstanceProperty("maxRayIntersections", get_maxRayIntersections, set_maxRayIntersections);
		}

		static private UnityEngine.Camera get_eventCamera(UnityEngine.EventSystems.PhysicsRaycaster instance)
		{
			return instance.eventCamera;
		}

		static private System.Int32 get_depth(UnityEngine.EventSystems.PhysicsRaycaster instance)
		{
			return instance.depth;
		}

		static private System.Int32 get_finalEventMask(UnityEngine.EventSystems.PhysicsRaycaster instance)
		{
			return instance.finalEventMask;
		}

		static private UnityEngine.LayerMask get_eventMask(UnityEngine.EventSystems.PhysicsRaycaster instance)
		{
			return instance.eventMask;
		}

		static private void set_eventMask(UnityEngine.EventSystems.PhysicsRaycaster instance, UnityEngine.LayerMask value)
		{
			instance.eventMask = value;
		}

		static private System.Int32 get_maxRayIntersections(UnityEngine.EventSystems.PhysicsRaycaster instance)
		{
			return instance.maxRayIntersections;
		}

		static private void set_maxRayIntersections(UnityEngine.EventSystems.PhysicsRaycaster instance, System.Int32 value)
		{
			instance.maxRayIntersections = value;
		}

	}
}
