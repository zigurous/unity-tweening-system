using UnityEngine;

namespace Zigurous.Tweening
{
    public static class CharacterJointTweens
    {
        public static Tween TweenSwingAxis(this CharacterJoint joint, Vector3 to, float duration) =>
            Tweening.To(joint, (source) => source.swingAxis, (source, value) => source.swingAxis = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenProjectionDistance(this CharacterJoint joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.projectionDistance, (source, value) => source.projectionDistance = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenProjectionAngle(this CharacterJoint joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.projectionAngle, (source, value) => source.projectionAngle = value, to, duration)
                    .SetTarget(joint);
    }

}
