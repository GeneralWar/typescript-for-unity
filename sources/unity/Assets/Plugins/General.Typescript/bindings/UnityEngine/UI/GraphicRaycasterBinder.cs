using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIGraphicRaycaster
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.GraphicRaycaster> self = space.DeclareClass<UnityEngine.UI.GraphicRaycaster, UnityEngine.EventSystems.BaseRaycaster>();
			UnityEngineUIGraphicRaycasterBlockingObjects.Bind(self);
			self.BindConstructor();
			self.BindInstanceProperty("sortOrderPriority", get_sortOrderPriority, null);
			self.BindInstanceProperty("renderOrderPriority", get_renderOrderPriority, null);
			self.BindInstanceProperty("ignoreReversedGraphics", get_ignoreReversedGraphics, set_ignoreReversedGraphics);
			self.BindInstanceProperty("eventCamera", get_eventCamera, null);
		}

		static private System.Int32 get_sortOrderPriority(UnityEngine.UI.GraphicRaycaster instance)
		{
			return instance.sortOrderPriority;
		}

		static private System.Int32 get_renderOrderPriority(UnityEngine.UI.GraphicRaycaster instance)
		{
			return instance.renderOrderPriority;
		}

		static private System.Boolean get_ignoreReversedGraphics(UnityEngine.UI.GraphicRaycaster instance)
		{
			return instance.ignoreReversedGraphics;
		}

		static private void set_ignoreReversedGraphics(UnityEngine.UI.GraphicRaycaster instance, System.Boolean value)
		{
			instance.ignoreReversedGraphics = value;
		}

		static private UnityEngine.Camera get_eventCamera(UnityEngine.UI.GraphicRaycaster instance)
		{
			return instance.eventCamera;
		}

	}
}
