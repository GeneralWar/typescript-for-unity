using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineHumanBone
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.HumanBone> self = space.DeclareClass<UnityEngine.HumanBone>();
			self.BindConstructor();
			self.BindInstanceProperty("boneName", get_boneName, set_boneName);
			self.BindInstanceProperty("humanName", get_humanName, set_humanName);
		}

		static private System.String get_boneName(UnityEngine.HumanBone instance)
		{
			return instance.boneName;
		}

		static private void set_boneName(UnityEngine.HumanBone instance, System.String value)
		{
			instance.boneName = value;
		}

		static private System.String get_humanName(UnityEngine.HumanBone instance)
		{
			return instance.humanName;
		}

		static private void set_humanName(UnityEngine.HumanBone instance, System.String value)
		{
			instance.humanName = value;
		}

	}
}
