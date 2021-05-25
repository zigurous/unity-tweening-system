using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class SpringJointTweens
    {
        public static Tween TweenSpring(this SpringJoint joint, float to, float duration) =>
            Tweening.To(getter: () => joint.spring,
                        setter: spring => joint.spring = spring,
                        to, duration).SetTarget(joint);

        public static Tween TweenDamper(this SpringJoint joint, float to, float duration) =>
            Tweening.To(getter: () => joint.damper,
                        setter: damper => joint.damper = damper,
                        to, duration).SetTarget(joint);

        public static Tween TweenMinDistance(this SpringJoint joint, float to, float duration) =>
            Tweening.To(getter: () => joint.minDistance,
                        setter: minDistance => joint.minDistance = minDistance,
                        to, duration).SetTarget(joint);

        public static Tween TweenMaxDistance(this SpringJoint joint, float to, float duration) =>
            Tweening.To(getter: () => joint.maxDistance,
                        setter: maxDistance => joint.maxDistance = maxDistance,
                        to, duration).SetTarget(joint);

        public static Tween TweenTolerance(this SpringJoint joint, float to, float duration) =>
            Tweening.To(getter: () => joint.tolerance,
                        setter: tolerance => joint.tolerance = tolerance,
                        to, duration).SetTarget(joint);

    }

}
