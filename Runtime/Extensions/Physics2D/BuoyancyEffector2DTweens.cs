using UnityEngine;

namespace Zigurous.Tweening
{
    public static class BuoyancyEffector2DTweens
    {
        public static Tween TweenSurfaceLevel(this BuoyancyEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (target) => target.surfaceLevel, (target, value) => target.surfaceLevel = value, to, duration)
                    .SetReference(effector);

        public static Tween TweenDensity(this BuoyancyEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (target) => target.density, (target, value) => target.density = value, to, duration)
                    .SetReference(effector);

        public static Tween TweenLinearDrag(this BuoyancyEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (target) => target.linearDrag, (target, value) => target.linearDrag = value, to, duration)
                    .SetReference(effector);

        public static Tween TweenAngularDrag(this BuoyancyEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (target) => target.angularDrag, (target, value) => target.angularDrag = value, to, duration)
                    .SetReference(effector);

        public static Tween TweenFlowAngle(this BuoyancyEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (target) => target.flowAngle, (target, value) => target.flowAngle = value, to, duration)
                    .SetReference(effector);

        public static Tween TweenFlowMagnitude(this BuoyancyEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (target) => target.flowMagnitude, (target, value) => target.flowMagnitude = value, to, duration)
                    .SetReference(effector);

        public static Tween TweenFlowVariation(this BuoyancyEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (target) => target.flowVariation, (target, value) => target.flowVariation = value, to, duration)
                    .SetReference(effector);
    }

}
