using UnityEngine;

namespace Zigurous.Tweening
{
    public static class BuoyancyEffector2DTweens
    {
        public static Tween TweenSurfaceLevel(this BuoyancyEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (source) => source.surfaceLevel, (source, value) => source.surfaceLevel = value, to, duration)
                    .SetTarget(effector);

        public static Tween TweenDensity(this BuoyancyEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (source) => source.density, (source, value) => source.density = value, to, duration)
                    .SetTarget(effector);

        public static Tween TweenLinearDrag(this BuoyancyEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (source) => source.linearDrag, (source, value) => source.linearDrag = value, to, duration)
                    .SetTarget(effector);

        public static Tween TweenAngularDrag(this BuoyancyEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (source) => source.angularDrag, (source, value) => source.angularDrag = value, to, duration)
                    .SetTarget(effector);

        public static Tween TweenFlowAngle(this BuoyancyEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (source) => source.flowAngle, (source, value) => source.flowAngle = value, to, duration)
                    .SetTarget(effector);

        public static Tween TweenFlowMagnitude(this BuoyancyEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (source) => source.flowMagnitude, (source, value) => source.flowMagnitude = value, to, duration)
                    .SetTarget(effector);

        public static Tween TweenFlowVariation(this BuoyancyEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (source) => source.flowVariation, (source, value) => source.flowVariation = value, to, duration)
                    .SetTarget(effector);
    }

}
