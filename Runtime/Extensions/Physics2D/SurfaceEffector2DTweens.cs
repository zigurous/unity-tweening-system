using UnityEngine;

namespace Zigurous.Tweening
{
    public static class SurfaceEffector2DTweens
    {
        public static Tween TweenSpeed(this SurfaceEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (source) => source.speed, (source, value) => source.speed = value, to, duration)
                    .SetTarget(effector);

        public static Tween TweenSpeedVariation(this SurfaceEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (source) => source.speedVariation, (source, value) => source.speedVariation = value, to, duration)
                    .SetTarget(effector);

        public static Tween TweenForceScale(this SurfaceEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (source) => source.forceScale, (source, value) => source.forceScale = value, to, duration)
                    .SetTarget(effector);
    }

}
