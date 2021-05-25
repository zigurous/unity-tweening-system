using UnityEngine;

namespace Zigurous.Tweening
{
    public static class CharacterJointTweens
    {
        public static Tween TweenSwingAxis(this CharacterJoint joint, Vector3 to, float duration) =>
            Tweening.To(getter: () => joint.swingAxis,
                        setter: swingAxis => joint.swingAxis = swingAxis,
                        to, duration).SetTarget(joint);

        public static Tween TweenProjectionDistance(this CharacterJoint joint, float to, float duration) =>
            Tweening.To(getter: () => joint.projectionDistance,
                        setter: projectionDistance => joint.projectionDistance = projectionDistance,
                        to, duration).SetTarget(joint);

        public static Tween TweenProjectionAngle(this CharacterJoint joint, float to, float duration) =>
            Tweening.To(getter: () => joint.projectionAngle,
                        setter: projectionAngle => joint.projectionAngle = projectionAngle,
                        to, duration).SetTarget(joint);

    }

}
