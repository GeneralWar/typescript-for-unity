using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineMotion
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Motion> self = space.DeclareClass<UnityEngine.Motion, UnityEngine.Object>();
			self.BindConstructor();
			self.BindInstanceProperty("averageDuration", get_averageDuration, null);
			self.BindInstanceProperty("averageAngularSpeed", get_averageAngularSpeed, null);
			self.BindInstanceProperty("averageSpeed", get_averageSpeed, null);
			self.BindInstanceProperty("apparentSpeed", get_apparentSpeed, null);
			self.BindInstanceProperty("isLooping", get_isLooping, null);
			self.BindInstanceProperty("legacy", get_legacy, null);
			self.BindInstanceProperty("isHumanMotion", get_isHumanMotion, null);
		}

		static private System.Single get_averageDuration(UnityEngine.Motion instance)
		{
			return instance.averageDuration;
		}

		static private System.Single get_averageAngularSpeed(UnityEngine.Motion instance)
		{
			return instance.averageAngularSpeed;
		}

		static private UnityEngine.Vector3 get_averageSpeed(UnityEngine.Motion instance)
		{
			return instance.averageSpeed;
		}

		static private System.Single get_apparentSpeed(UnityEngine.Motion instance)
		{
			return instance.apparentSpeed;
		}

		static private System.Boolean get_isLooping(UnityEngine.Motion instance)
		{
			return instance.isLooping;
		}

		static private System.Boolean get_legacy(UnityEngine.Motion instance)
		{
			return instance.legacy;
		}

		static private System.Boolean get_isHumanMotion(UnityEngine.Motion instance)
		{
			return instance.isHumanMotion;
		}

	}
}
