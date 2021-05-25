using UnityEngine;

namespace Zigurous.Tweening
{
    public static class ConfigurableJointTweens
    {
        public static Tween TweenProjectionAngle(this ConfigurableJoint joint, float to, float duration) =>
            Tweening.To(getter: () => joint.projectionAngle,
                        setter: projectionAngle => joint.projectionAngle = projectionAngle,
                        to, duration).SetTarget(joint);

        public static Tween TweenProjectionDistance(this ConfigurableJoint joint, float to, float duration) =>
            Tweening.To(getter: () => joint.projectionDistance,
                        setter: projectionDistance => joint.projectionDistance = projectionDistance,
                        to, duration).SetTarget(joint);

        public static Tween TweenTargetVelocity(this ConfigurableJoint joint, Vector3 to, float duration) =>
            Tweening.To(getter: () => joint.targetVelocity,
                        setter: targetVelocity => joint.targetVelocity = targetVelocity,
                        to, duration).SetTarget(joint);

        public static Tween TweenTargetAngularVelocity(this ConfigurableJoint joint, Vector3 to, float duration) =>
            Tweening.To(getter: () => joint.targetAngularVelocity,
                        setter: targetAngularVelocity => joint.targetAngularVelocity = targetAngularVelocity,
                        to, duration).SetTarget(joint);

        public static Tween TweenTargetPosition(this ConfigurableJoint joint, Vector3 to, float duration) =>
            Tweening.To(getter: () => joint.targetPosition,
                        setter: targetPosition => joint.targetPosition = targetPosition,
                        to, duration).SetTarget(joint);

        public static Tween TweenTargetRotation(this ConfigurableJoint joint, Quaternion to, float duration) =>
            Tweening.To(getter: () => joint.targetRotation,
                        setter: targetRotation => joint.targetRotation = targetRotation,
                        to, duration).SetTarget(joint);

        public static Tween TweenSecondaryAxis(this ConfigurableJoint joint, Vector3 to, float duration) =>
            Tweening.To(getter: () => joint.secondaryAxis,
                        setter: secondaryAxis => joint.secondaryAxis = secondaryAxis,
                        to, duration).SetTarget(joint);

    }

}
