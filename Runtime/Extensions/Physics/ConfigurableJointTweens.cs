using UnityEngine;

namespace Zigurous.Tweening
{
    public static class ConfigurableJointTweens
    {
        public static Tween TweenProjectionAngle(this ConfigurableJoint joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.projectionAngle, (source, value) => source.projectionAngle = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenProjectionDistance(this ConfigurableJoint joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.projectionDistance, (source, value) => source.projectionDistance = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenTargetVelocity(this ConfigurableJoint joint, Vector3 to, float duration) =>
            Tweening.To(joint, (source) => source.targetVelocity, (source, value) => source.targetVelocity = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenTargetAngularVelocity(this ConfigurableJoint joint, Vector3 to, float duration) =>
            Tweening.To(joint, (source) => source.targetAngularVelocity, (source, value) => source.targetAngularVelocity = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenTargetPosition(this ConfigurableJoint joint, Vector3 to, float duration) =>
            Tweening.To(joint, (source) => source.targetPosition, (source, value) => source.targetPosition = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenTargetRotation(this ConfigurableJoint joint, Quaternion to, float duration) =>
            Tweening.To(joint, (source) => source.targetRotation, (source, value) => source.targetRotation = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenSecondaryAxis(this ConfigurableJoint joint, Vector3 to, float duration) =>
            Tweening.To(joint, (source) => source.secondaryAxis, (source, value) => source.secondaryAxis = value, to, duration)
                    .SetTarget(joint);
    }

}
