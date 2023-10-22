using UnityEngine;

namespace Zigurous.Tweening
{
    public static class AreaEffector2DTweens
    {
        public static Tween TweenForceAngle(this AreaEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (target) => target.forceAngle, (target, value) => target.forceAngle = value, to, duration)
                    .SetReference(effector);

        public static Tween TweenForceMagnitude(this AreaEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (target) => target.forceMagnitude, (target, value) => target.forceMagnitude = value, to, duration)
                    .SetReference(effector);

        public static Tween TweenForceVariation(this AreaEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (target) => target.forceVariation, (target, value) => target.forceVariation = value, to, duration)
                    .SetReference(effector);

        public static Tween TweenDrag(this AreaEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (target) => target.drag, (target, value) => target.drag = value, to, duration)
                    .SetReference(effector);

        public static Tween TweenAngularDrag(this AreaEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (target) => target.angularDrag, (target, value) => target.angularDrag = value, to, duration)
                    .SetReference(effector);
    }

}
