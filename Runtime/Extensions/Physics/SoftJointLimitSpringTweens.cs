using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class SoftJointLimitSpringTweens
    {
        public static Tween TweenSpring(this SoftJointLimitSpring jointLimitSpring, float to, float duration) =>
            Tweening.To(getter: () => jointLimitSpring.spring,
                        setter: spring => jointLimitSpring.spring = spring,
                        to, duration).SetTarget(jointLimitSpring);

        public static Tween TweenDamper(this SoftJointLimitSpring jointLimitSpring, float to, float duration) =>
            Tweening.To(getter: () => jointLimitSpring.damper,
                        setter: damper => jointLimitSpring.damper = damper,
                        to, duration).SetTarget(jointLimitSpring);

    }

}
