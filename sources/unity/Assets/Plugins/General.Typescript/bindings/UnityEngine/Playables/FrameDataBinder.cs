using UnityEngine;

namespace General.Typescript
{
	public class UnityEnginePlayablesFrameData
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Playables.FrameData> self = space.DeclareClass<UnityEngine.Playables.FrameData>();
			UnityEnginePlayablesFrameDataEvaluationType.Bind(self);
			self.BindConstructor();
			self.BindInstanceProperty("frameId", get_frameId, null);
			self.BindInstanceProperty("deltaTime", get_deltaTime, null);
			self.BindInstanceProperty("weight", get_weight, null);
			self.BindInstanceProperty("effectiveWeight", get_effectiveWeight, null);
			self.BindInstanceProperty("effectiveParentDelay", get_effectiveParentDelay, null);
			self.BindInstanceProperty("effectiveParentSpeed", get_effectiveParentSpeed, null);
			self.BindInstanceProperty("effectiveSpeed", get_effectiveSpeed, null);
			self.BindInstanceProperty("seekOccurred", get_seekOccurred, null);
			self.BindInstanceProperty("timeLooped", get_timeLooped, null);
			self.BindInstanceProperty("timeHeld", get_timeHeld, null);
			self.BindInstanceProperty("output", get_output, null);
			self.BindInstanceProperty("effectivePlayState", get_effectivePlayState, null);
		}

		static private System.UInt64 get_frameId(UnityEngine.Playables.FrameData instance)
		{
			return instance.frameId;
		}

		static private System.Single get_deltaTime(UnityEngine.Playables.FrameData instance)
		{
			return instance.deltaTime;
		}

		static private System.Single get_weight(UnityEngine.Playables.FrameData instance)
		{
			return instance.weight;
		}

		static private System.Single get_effectiveWeight(UnityEngine.Playables.FrameData instance)
		{
			return instance.effectiveWeight;
		}

		static private System.Double get_effectiveParentDelay(UnityEngine.Playables.FrameData instance)
		{
			return instance.effectiveParentDelay;
		}

		static private System.Single get_effectiveParentSpeed(UnityEngine.Playables.FrameData instance)
		{
			return instance.effectiveParentSpeed;
		}

		static private System.Single get_effectiveSpeed(UnityEngine.Playables.FrameData instance)
		{
			return instance.effectiveSpeed;
		}

		static private System.Boolean get_seekOccurred(UnityEngine.Playables.FrameData instance)
		{
			return instance.seekOccurred;
		}

		static private System.Boolean get_timeLooped(UnityEngine.Playables.FrameData instance)
		{
			return instance.timeLooped;
		}

		static private System.Boolean get_timeHeld(UnityEngine.Playables.FrameData instance)
		{
			return instance.timeHeld;
		}

		static private UnityEngine.Playables.PlayableOutput get_output(UnityEngine.Playables.FrameData instance)
		{
			return instance.output;
		}

		static private UnityEngine.Playables.PlayState get_effectivePlayState(UnityEngine.Playables.FrameData instance)
		{
			return instance.effectivePlayState;
		}

	}
}
