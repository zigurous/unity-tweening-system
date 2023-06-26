using UnityEngine;

namespace Zigurous.Tweening
{
    public static class AreaEffector2DTweens
    {
        public static Tween TweenForceAngle(this AreaEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (source) => source.forceAngle, (source, value) => source.forceAngle = value, to, duration)
                    .SetTarget(effector);

        public static Tween TweenForceMagnitude(this AreaEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (source) => source.forceMagnitude, (source, value) => source.forceMagnitude = value, to, duration)
                    .SetTarget(effector);

        public static Tween TweenForceVariation(this AreaEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (source) => source.forceVariation, (source, value) => source.forceVariation = value, to, duration)
                    .SetTarget(effector);

        public static Tween TweenDrag(this AreaEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (source) => source.drag, (source, value) => source.drag = value, to, duration)
                    .SetTarget(effector);

        public static Tween TweenAngularDrag(this AreaEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (source) => source.angularDrag, (source, value) => source.angularDrag = value, to, duration)
                    .SetTarget(effector);
    }

}
