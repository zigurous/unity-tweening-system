using UnityEngine;
using UnityEngine.Animations;

namespace Zigurous.Tweening
{
    public static class PositionConstraintTweens
    {
        public static Tween TweenWeight(this PositionConstraint constraint, float to, float duration) =>
            Tweening.To(constraint, (source) => source.weight, (source, value) => source.weight = value, to, duration)
                    .SetTarget(constraint);

        public static Tween TweenTranslationAtRest(this PositionConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(constraint, (source) => source.translationAtRest, (source, value) => source.translationAtRest = value, to, duration)
                    .SetTarget(constraint);

        public static Tween TweenTranslationOffset(this PositionConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(constraint, (source) => source.translationOffset, (source, value) => source.translationOffset = value, to, duration)
                    .SetTarget(constraint);
    }

}
