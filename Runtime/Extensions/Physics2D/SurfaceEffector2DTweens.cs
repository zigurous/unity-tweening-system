using UnityEngine;

namespace Zigurous.Tweening
{
    public static class SurfaceEffector2DTweens
    {
        public static Tween TweenSpeed(this SurfaceEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (target) => target.speed, (target, value) => target.speed = value, to, duration)
                    .SetReference(effector);

        public static Tween TweenSpeedVariation(this SurfaceEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (target) => target.speedVariation, (target, value) => target.speedVariation = value, to, duration)
                    .SetReference(effector);

        public static Tween TweenForceScale(this SurfaceEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (target) => target.forceScale, (target, value) => target.forceScale = value, to, duration)
                    .SetReference(effector);
    }

}
