using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class JointLimitsTweens
    {
        public static Tween TweenMin(this JointLimits jointLimits, float to, float duration) =>
            Tweening.To(getter: () => jointLimits.min,
                        setter: min => jointLimits.min = min,
                        to, duration).SetTarget(jointLimits);

        public static Tween TweenMax(this JointLimits jointLimits, float to, float duration) =>
            Tweening.To(getter: () => jointLimits.max,
                        setter: max => jointLimits.max = max,
                        to, duration).SetTarget(jointLimits);

        public static Tween TweenBounciness(this JointLimits jointLimits, float to, float duration) =>
            Tweening.To(getter: () => jointLimits.bounciness,
                        setter: bounciness => jointLimits.bounciness = bounciness,
                        to, duration).SetTarget(jointLimits);

        public static Tween TweenBounceMinVelocity(this JointLimits jointLimits, float to, float duration) =>
            Tweening.To(getter: () => jointLimits.bounceMinVelocity,
                        setter: bounceMinVelocity => jointLimits.bounceMinVelocity = bounceMinVelocity,
                        to, duration).SetTarget(jointLimits);

        public static Tween TweenContactDistance(this JointLimits jointLimits, float to, float duration) =>
            Tweening.To(getter: () => jointLimits.contactDistance,
                        setter: contactDistance => jointLimits.contactDistance = contactDistance,
                        to, duration).SetTarget(jointLimits);

    }

}
