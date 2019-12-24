using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimationsConstraintSource
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Animations.ConstraintSource> self = space.DeclareClass<UnityEngine.Animations.ConstraintSource>();
			self.BindConstructor();
			self.BindInstanceProperty("sourceTransform", get_sourceTransform, set_sourceTransform);
			self.BindInstanceProperty("weight", get_weight, set_weight);
		}

		static private UnityEngine.Transform get_sourceTransform(UnityEngine.Animations.ConstraintSource instance, string name)
		{
			return instance.sourceTransform;
		}

		static private void set_sourceTransform(UnityEngine.Animations.ConstraintSource instance, string name, UnityEngine.Transform value)
		{
			instance.sourceTransform = value;
		}

		static private System.Single get_weight(UnityEngine.Animations.ConstraintSource instance, string name)
		{
			return instance.weight;
		}

		static private void set_weight(UnityEngine.Animations.ConstraintSource instance, string name, System.Single value)
		{
			instance.weight = value;
		}

	}
}
