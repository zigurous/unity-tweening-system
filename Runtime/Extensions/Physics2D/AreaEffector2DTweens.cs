using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class AreaEffector2DTweens
    {
        public static Tween TweenForceAngle(this AreaEffector2D effector, float to, float duration) =>
            Tweening.To(getter: () => effector.forceAngle,
                        setter: forceAngle => effector.forceAngle = forceAngle,
                        to, duration).SetTarget(effector);

        public static Tween TweenForceMagnitude(this AreaEffector2D effector, float to, float duration) =>
            Tweening.To(getter: () => effector.forceMagnitude,
                        setter: forceMagnitude => effector.forceMagnitude = forceMagnitude,
                        to, duration).SetTarget(effector);

        public static Tween TweenForceVariation(this AreaEffector2D effector, float to, float duration) =>
            Tweening.To(getter: () => effector.forceVariation,
                        setter: forceVariation => effector.forceVariation = forceVariation,
                        to, duration).SetTarget(effector);

        public static Tween TweenDrag(this AreaEffector2D effector, float to, float duration) =>
            Tweening.To(getter: () => effector.drag,
                        setter: drag => effector.drag = drag,
                        to, duration).SetTarget(effector);

        public static Tween TweenAngularDrag(this AreaEffector2D effector, float to, float duration) =>
            Tweening.To(getter: () => effector.angularDrag,
                        setter: angularDrag => effector.angularDrag = angularDrag,
                        to, duration).SetTarget(effector);

    }

}
