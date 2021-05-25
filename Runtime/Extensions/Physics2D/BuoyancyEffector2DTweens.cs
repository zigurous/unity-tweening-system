using UnityEngine;

namespace Zigurous.Tweening
{
    public static class BuoyancyEffector2DTweens
    {
        public static Tween TweenSurfaceLevel(this BuoyancyEffector2D effector, float to, float duration) =>
            Tweening.To(getter: () => effector.surfaceLevel,
                        setter: surfaceLevel => effector.surfaceLevel = surfaceLevel,
                        to, duration).SetTarget(effector);

        public static Tween TweenDensity(this BuoyancyEffector2D effector, float to, float duration) =>
            Tweening.To(getter: () => effector.density,
                        setter: density => effector.density = density,
                        to, duration).SetTarget(effector);

        public static Tween TweenLinearDrag(this BuoyancyEffector2D effector, float to, float duration) =>
            Tweening.To(getter: () => effector.linearDrag,
                        setter: linearDrag => effector.linearDrag = linearDrag,
                        to, duration).SetTarget(effector);

        public static Tween TweenAngularDrag(this BuoyancyEffector2D effector, float to, float duration) =>
            Tweening.To(getter: () => effector.angularDrag,
                        setter: angularDrag => effector.angularDrag = angularDrag,
                        to, duration).SetTarget(effector);

        public static Tween TweenFlowAngle(this BuoyancyEffector2D effector, float to, float duration) =>
            Tweening.To(getter: () => effector.flowAngle,
                        setter: flowAngle => effector.flowAngle = flowAngle,
                        to, duration).SetTarget(effector);

        public static Tween TweenFlowMagnitude(this BuoyancyEffector2D effector, float to, float duration) =>
            Tweening.To(getter: () => effector.flowMagnitude,
                        setter: flowMagnitude => effector.flowMagnitude = flowMagnitude,
                        to, duration).SetTarget(effector);

        public static Tween TweenFlowVariation(this BuoyancyEffector2D effector, float to, float duration) =>
            Tweening.To(getter: () => effector.flowVariation,
                        setter: flowVariation => effector.flowVariation = flowVariation,
                        to, duration).SetTarget(effector);

    }

}
