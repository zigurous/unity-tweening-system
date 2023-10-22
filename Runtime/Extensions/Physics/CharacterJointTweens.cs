using UnityEngine;

namespace Zigurous.Tweening
{
    public static class CharacterJointTweens
    {
        public static Tween TweenSwingAxis(this CharacterJoint joint, Vector3 to, float duration) =>
            Tweening.To(joint, (target) => target.swingAxis, (target, value) => target.swingAxis = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenProjectionDistance(this CharacterJoint joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.projectionDistance, (target, value) => target.projectionDistance = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenProjectionAngle(this CharacterJoint joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.projectionAngle, (target, value) => target.projectionAngle = value, to, duration)
                    .SetReference(joint);
    }

}
