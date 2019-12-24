using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineHumanDescription
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.HumanDescription> self = space.DeclareClass<UnityEngine.HumanDescription>();
			self.BindConstructor();
			self.BindInstanceProperty("upperArmTwist", get_upperArmTwist, set_upperArmTwist);
			self.BindInstanceProperty("lowerArmTwist", get_lowerArmTwist, set_lowerArmTwist);
			self.BindInstanceProperty("upperLegTwist", get_upperLegTwist, set_upperLegTwist);
			self.BindInstanceProperty("lowerLegTwist", get_lowerLegTwist, set_lowerLegTwist);
			self.BindInstanceProperty("armStretch", get_armStretch, set_armStretch);
			self.BindInstanceProperty("legStretch", get_legStretch, set_legStretch);
			self.BindInstanceProperty("feetSpacing", get_feetSpacing, set_feetSpacing);
			self.BindInstanceProperty("hasTranslationDoF", get_hasTranslationDoF, set_hasTranslationDoF);
		}

		static private System.Single get_upperArmTwist(UnityEngine.HumanDescription instance, string name)
		{
			return instance.upperArmTwist;
		}

		static private void set_upperArmTwist(UnityEngine.HumanDescription instance, string name, System.Single value)
		{
			instance.upperArmTwist = value;
		}

		static private System.Single get_lowerArmTwist(UnityEngine.HumanDescription instance, string name)
		{
			return instance.lowerArmTwist;
		}

		static private void set_lowerArmTwist(UnityEngine.HumanDescription instance, string name, System.Single value)
		{
			instance.lowerArmTwist = value;
		}

		static private System.Single get_upperLegTwist(UnityEngine.HumanDescription instance, string name)
		{
			return instance.upperLegTwist;
		}

		static private void set_upperLegTwist(UnityEngine.HumanDescription instance, string name, System.Single value)
		{
			instance.upperLegTwist = value;
		}

		static private System.Single get_lowerLegTwist(UnityEngine.HumanDescription instance, string name)
		{
			return instance.lowerLegTwist;
		}

		static private void set_lowerLegTwist(UnityEngine.HumanDescription instance, string name, System.Single value)
		{
			instance.lowerLegTwist = value;
		}

		static private System.Single get_armStretch(UnityEngine.HumanDescription instance, string name)
		{
			return instance.armStretch;
		}

		static private void set_armStretch(UnityEngine.HumanDescription instance, string name, System.Single value)
		{
			instance.armStretch = value;
		}

		static private System.Single get_legStretch(UnityEngine.HumanDescription instance, string name)
		{
			return instance.legStretch;
		}

		static private void set_legStretch(UnityEngine.HumanDescription instance, string name, System.Single value)
		{
			instance.legStretch = value;
		}

		static private System.Single get_feetSpacing(UnityEngine.HumanDescription instance, string name)
		{
			return instance.feetSpacing;
		}

		static private void set_feetSpacing(UnityEngine.HumanDescription instance, string name, System.Single value)
		{
			instance.feetSpacing = value;
		}

		static private System.Boolean get_hasTranslationDoF(UnityEngine.HumanDescription instance, string name)
		{
			return instance.hasTranslationDoF;
		}

		static private void set_hasTranslationDoF(UnityEngine.HumanDescription instance, string name, System.Boolean value)
		{
			instance.hasTranslationDoF = value;
		}

	}
}
