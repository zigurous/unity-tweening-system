using UnityEngine;
using UnityEngine.Animations;

namespace Zigurous.Tweening
{
    public static class ParentConstraintTweens
    {
        public static Tween TweenWeight(this ParentConstraint constraint, float to, float duration) =>
            Tweening.To(constraint, (source) => source.weight, (source, value) => source.weight = value, to, duration)
                    .SetTarget(constraint);

        public static Tween TweenRotationAtRest(this ParentConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(constraint, (source) => source.rotationAtRest, (source, value) => source.rotationAtRest = value, to, duration)
                    .SetTarget(constraint);

        public static Tween TweenTranslationAtRest(this ParentConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(constraint, (source) => source.translationAtRest, (source, value) => source.translationAtRest = value, to, duration)
                    .SetTarget(constraint);
    }

}
