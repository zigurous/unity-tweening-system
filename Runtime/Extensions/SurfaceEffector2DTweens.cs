using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class SurfaceEffector2DTweens
    {
        public static Tween TweenSpeed(this SurfaceEffector2D effector, float to, float duration) =>
            Tweening.To(getter: () => effector.speed,
                        setter: speed => effector.speed = speed,
                        to, duration).SetTarget(effector);

        public static Tween TweenSpeedVariation(this SurfaceEffector2D effector, float to, float duration) =>
            Tweening.To(getter: () => effector.speedVariation,
                        setter: speedVariation => effector.speedVariation = speedVariation,
                        to, duration).SetTarget(effector);

        public static Tween TweenForceScale(this SurfaceEffector2D effector, float to, float duration) =>
            Tweening.To(getter: () => effector.forceScale,
                        setter: forceScale => effector.forceScale = forceScale,
                        to, duration).SetTarget(effector);

    }

}
