using UnityEngine;
using UnityEngine.Animations;

namespace Zigurous.Tweening
{
    public static class PositionConstraintTweens
    {
        public static Tween TweenWeight(this PositionConstraint constraint, float to, float duration) =>
            Tweening.To(getter: () => constraint.weight,
                        setter: weight => constraint.weight = weight,
                        to, duration).SetTarget(constraint);

        public static Tween TweenTranslationAtRest(this PositionConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(getter: () => constraint.translationAtRest,
                        setter: translationAtRest => constraint.translationAtRest = translationAtRest,
                        to, duration).SetTarget(constraint);

        public static Tween TweenTranslationOffset(this PositionConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(getter: () => constraint.translationOffset,
                        setter: translationOffset => constraint.translationOffset = translationOffset,
                        to, duration).SetTarget(constraint);

    }

}
