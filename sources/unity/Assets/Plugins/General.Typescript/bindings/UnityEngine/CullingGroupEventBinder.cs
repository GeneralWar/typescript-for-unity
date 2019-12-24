using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCullingGroupEvent
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.CullingGroupEvent> self = space.DeclareClass<UnityEngine.CullingGroupEvent>();
			self.BindConstructor();
			self.BindInstanceProperty("index", get_index, null);
			self.BindInstanceProperty("isVisible", get_isVisible, null);
			self.BindInstanceProperty("wasVisible", get_wasVisible, null);
			self.BindInstanceProperty("hasBecomeVisible", get_hasBecomeVisible, null);
			self.BindInstanceProperty("hasBecomeInvisible", get_hasBecomeInvisible, null);
			self.BindInstanceProperty("currentDistance", get_currentDistance, null);
			self.BindInstanceProperty("previousDistance", get_previousDistance, null);
		}

		static private System.Int32 get_index(UnityEngine.CullingGroupEvent instance, string name)
		{
			return instance.index;
		}

		static private System.Boolean get_isVisible(UnityEngine.CullingGroupEvent instance, string name)
		{
			return instance.isVisible;
		}

		static private System.Boolean get_wasVisible(UnityEngine.CullingGroupEvent instance, string name)
		{
			return instance.wasVisible;
		}

		static private System.Boolean get_hasBecomeVisible(UnityEngine.CullingGroupEvent instance, string name)
		{
			return instance.hasBecomeVisible;
		}

		static private System.Boolean get_hasBecomeInvisible(UnityEngine.CullingGroupEvent instance, string name)
		{
			return instance.hasBecomeInvisible;
		}

		static private System.Int32 get_currentDistance(UnityEngine.CullingGroupEvent instance, string name)
		{
			return instance.currentDistance;
		}

		static private System.Int32 get_previousDistance(UnityEngine.CullingGroupEvent instance, string name)
		{
			return instance.previousDistance;
		}

	}
}
