using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class SoftJointLimitTweens
    {
        public static Tween TweenLimit(this SoftJointLimit jointLimit, float to, float duration) =>
            Tweening.To(getter: () => jointLimit.limit,
                        setter: limit => jointLimit.limit = limit,
                        to, duration).SetTarget(jointLimit);

        public static Tween TweenBounciness(this SoftJointLimit jointLimit, float to, float duration) =>
            Tweening.To(getter: () => jointLimit.bounciness,
                        setter: bounciness => jointLimit.bounciness = bounciness,
                        to, duration).SetTarget(jointLimit);

        public static Tween TweenContactDistance(this SoftJointLimit jointLimit, float to, float duration) =>
            Tweening.To(getter: () => jointLimit.contactDistance,
                        setter: contactDistance => jointLimit.contactDistance = contactDistance,
                        to, duration).SetTarget(jointLimit);

    }

}
