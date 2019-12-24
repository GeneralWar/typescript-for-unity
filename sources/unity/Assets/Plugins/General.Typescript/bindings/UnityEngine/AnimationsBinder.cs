using System;

namespace General.Typescript
{
    public class AnimationsBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("Animations");

			UnityEngineAnimationsAimConstraint.Bind(self);
			UnityEngineAnimationsAnimationClipPlayable.Bind(self);
			UnityEngineAnimationsAnimationLayerMixerPlayable.Bind(self);
			UnityEngineAnimationsAnimationMixerPlayable.Bind(self);
			UnityEngineAnimationsAnimationPlayableOutput.Bind(self);
			UnityEngineAnimationsAnimatorControllerPlayable.Bind(self);
			UnityEngineAnimationsAxis.Bind(self);
			UnityEngineAnimationsConstraintSource.Bind(self);
			UnityEngineAnimationsLookAtConstraint.Bind(self);
			UnityEngineAnimationsParentConstraint.Bind(self);
			UnityEngineAnimationsPositionConstraint.Bind(self);
			UnityEngineAnimationsRotationConstraint.Bind(self);
			UnityEngineAnimationsScaleConstraint.Bind(self);
        }
    }
}