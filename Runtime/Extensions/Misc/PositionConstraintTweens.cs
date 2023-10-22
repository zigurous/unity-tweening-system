using UnityEngine;
using UnityEngine.Animations;

namespace Zigurous.Tweening
{
    public static class PositionConstraintTweens
    {
        public static Tween TweenWeight(this PositionConstraint constraint, float to, float duration) =>
            Tweening.To(constraint, (target) => target.weight, (target, value) => target.weight = value, to, duration)
                    .SetReference(constraint);

        public static Tween TweenTranslationAtRest(this PositionConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(constraint, (target) => target.translationAtRest, (target, value) => target.translationAtRest = value, to, duration)
                    .SetReference(constraint);

        public static Tween TweenTranslationOffset(this PositionConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(constraint, (target) => target.translationOffset, (target, value) => target.translationOffset = value, to, duration)
                    .SetReference(constraint);
    }

}
