using UnityEngine;
using UnityEngine.Animations;

namespace Zigurous.Tweening
{
    public static class ScaleConstraintTweens
    {
        public static Tween TweenWeight(this ScaleConstraint constraint, float to, float duration) =>
            Tweening.To(getter: () => constraint.weight,
                        setter: weight => constraint.weight = weight,
                        to, duration).SetTarget(constraint);

        public static Tween TweenScaleAtRest(this ScaleConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(getter: () => constraint.scaleAtRest,
                        setter: scaleAtRest => constraint.scaleAtRest = scaleAtRest,
                        to, duration).SetTarget(constraint);

        public static Tween TweenScaleOffset(this ScaleConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(getter: () => constraint.scaleOffset,
                        setter: scaleOffset => constraint.scaleOffset = scaleOffset,
                        to, duration).SetTarget(constraint);

    }

}
