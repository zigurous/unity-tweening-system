using UnityEngine;

namespace Zigurous.Tweening
{
    public static class ConfigurableJointTweens
    {
        public static Tween TweenProjectionAngle(this ConfigurableJoint joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.projectionAngle, (target, value) => target.projectionAngle = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenProjectionDistance(this ConfigurableJoint joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.projectionDistance, (target, value) => target.projectionDistance = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenTargetVelocity(this ConfigurableJoint joint, Vector3 to, float duration) =>
            Tweening.To(joint, (target) => target.targetVelocity, (target, value) => target.targetVelocity = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenTargetAngularVelocity(this ConfigurableJoint joint, Vector3 to, float duration) =>
            Tweening.To(joint, (target) => target.targetAngularVelocity, (target, value) => target.targetAngularVelocity = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenTargetPosition(this ConfigurableJoint joint, Vector3 to, float duration) =>
            Tweening.To(joint, (target) => target.targetPosition, (target, value) => target.targetPosition = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenTargetRotation(this ConfigurableJoint joint, Quaternion to, float duration) =>
            Tweening.To(joint, (target) => target.targetRotation, (target, value) => target.targetRotation = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenSecondaryAxis(this ConfigurableJoint joint, Vector3 to, float duration) =>
            Tweening.To(joint, (target) => target.secondaryAxis, (target, value) => target.secondaryAxis = value, to, duration)
                    .SetReference(joint);
    }

}
