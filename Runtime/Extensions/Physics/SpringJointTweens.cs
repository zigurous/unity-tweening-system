using UnityEngine;

namespace Zigurous.Tweening
{
    public static class SpringJointTweens
    {
        public static Tween TweenSpring(this SpringJoint joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.spring, (target, value) => target.spring = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenDamper(this SpringJoint joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.damper, (target, value) => target.damper = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenMinDistance(this SpringJoint joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.minDistance, (target, value) => target.minDistance = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenMaxDistance(this SpringJoint joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.maxDistance, (target, value) => target.maxDistance = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenTolerance(this SpringJoint joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.tolerance, (target, value) => target.tolerance = value, to, duration)
                    .SetReference(joint);
    }

}
