using UnityEngine;

namespace Zigurous.Tweening
{
    public static class SpringJointTweens
    {
        public static Tween TweenSpring(this SpringJoint joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.spring, (source, value) => source.spring = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenDamper(this SpringJoint joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.damper, (source, value) => source.damper = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenMinDistance(this SpringJoint joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.minDistance, (source, value) => source.minDistance = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenMaxDistance(this SpringJoint joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.maxDistance, (source, value) => source.maxDistance = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenTolerance(this SpringJoint joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.tolerance, (source, value) => source.tolerance = value, to, duration)
                    .SetTarget(joint);
    }

}
