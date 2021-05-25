using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class PointEffector2DTweens
    {
        public static Tween TweenDrag(this PointEffector2D effector, float to, float duration) =>
            Tweening.To(getter: () => effector.drag,
                        setter: drag => effector.drag = drag,
                        to, duration).SetTarget(effector);

        public static Tween TweenAngularDrag(this PointEffector2D effector, float to, float duration) =>
            Tweening.To(getter: () => effector.angularDrag,
                        setter: angularDrag => effector.angularDrag = angularDrag,
                        to, duration).SetTarget(effector);

        public static Tween TweenForceMagnitude(this PointEffector2D effector, float to, float duration) =>
            Tweening.To(getter: () => effector.forceMagnitude,
                        setter: forceMagnitude => effector.forceMagnitude = forceMagnitude,
                        to, duration).SetTarget(effector);

        public static Tween TweenForceVariation(this PointEffector2D effector, float to, float duration) =>
            Tweening.To(getter: () => effector.forceVariation,
                        setter: forceVariation => effector.forceVariation = forceVariation,
                        to, duration).SetTarget(effector);

        public static Tween TweenDistanceScale(this PointEffector2D effector, float to, float duration) =>
            Tweening.To(getter: () => effector.distanceScale,
                        setter: distanceScale => effector.distanceScale = distanceScale,
                        to, duration).SetTarget(effector);

    }

}
