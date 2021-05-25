using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class JointSpringTweens
    {
        public static Tween TweenSpring(this JointSpring jointSpring, float to, float duration) =>
            Tweening.To(getter: () => jointSpring.spring,
                        setter: spring => jointSpring.spring = spring,
                        to, duration).SetTarget(jointSpring);

        public static Tween TweenDamper(this JointSpring jointSpring, float to, float duration) =>
            Tweening.To(getter: () => jointSpring.damper,
                        setter: damper => jointSpring.damper = damper,
                        to, duration).SetTarget(jointSpring);

        public static Tween TweenTargetPosition(this JointSpring jointSpring, float to, float duration) =>
            Tweening.To(getter: () => jointSpring.targetPosition,
                        setter: targetPosition => jointSpring.targetPosition = targetPosition,
                        to, duration).SetTarget(jointSpring);

    }

}
