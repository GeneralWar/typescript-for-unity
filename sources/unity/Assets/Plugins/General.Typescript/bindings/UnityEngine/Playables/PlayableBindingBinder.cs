using UnityEngine;

namespace General.Typescript
{
	public class UnityEnginePlayablesPlayableBinding
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Playables.PlayableBinding> self = space.DeclareClass<UnityEngine.Playables.PlayableBinding>();
			self.BindConstructor();
			self.BindInstanceProperty("streamName", get_streamName, set_streamName);
			self.BindInstanceProperty("sourceObject", get_sourceObject, set_sourceObject);
			self.BindInstanceProperty("outputTargetType", get_outputTargetType, null);
		}

		static private System.String get_streamName(UnityEngine.Playables.PlayableBinding instance)
		{
			return instance.streamName;
		}

		static private void set_streamName(UnityEngine.Playables.PlayableBinding instance, System.String value)
		{
			instance.streamName = value;
		}

		static private UnityEngine.Object get_sourceObject(UnityEngine.Playables.PlayableBinding instance)
		{
			return instance.sourceObject;
		}

		static private void set_sourceObject(UnityEngine.Playables.PlayableBinding instance, UnityEngine.Object value)
		{
			instance.sourceObject = value;
		}

		static private System.Type get_outputTargetType(UnityEngine.Playables.PlayableBinding instance)
		{
			return instance.outputTargetType;
		}

	}
}
