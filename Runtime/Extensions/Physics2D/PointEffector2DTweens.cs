using UnityEngine;

namespace Zigurous.Tweening
{
    public static class PointEffector2DTweens
    {
        public static Tween TweenDrag(this PointEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (source) => source.drag, (source, value) => source.drag = value, to, duration)
                    .SetTarget(effector);

        public static Tween TweenAngularDrag(this PointEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (source) => source.angularDrag, (source, value) => source.angularDrag = value, to, duration)
                    .SetTarget(effector);

        public static Tween TweenForceMagnitude(this PointEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (source) => source.forceMagnitude, (source, value) => source.forceMagnitude = value, to, duration)
                    .SetTarget(effector);

        public static Tween TweenForceVariation(this PointEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (source) => source.forceVariation, (source, value) => source.forceVariation = value, to, duration)
                    .SetTarget(effector);

        public static Tween TweenDistanceScale(this PointEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (source) => source.distanceScale, (source, value) => source.distanceScale = value, to, duration)
                    .SetTarget(effector);
    }

}
