using UnityEngine;
using UnityEngine.Animations;

namespace Zigurous.Tweening
{
    public static class ParentConstraintTweens
    {
        public static Tween TweenWeight(this ParentConstraint constraint, float to, float duration) =>
            Tweening.To(getter: () => constraint.weight,
                        setter: weight => constraint.weight = weight,
                        to, duration).SetTarget(constraint);

        public static Tween TweenRotationAtRest(this ParentConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(getter: () => constraint.rotationAtRest,
                        setter: rotationAtRest => constraint.rotationAtRest = rotationAtRest,
                        to, duration).SetTarget(constraint);

        public static Tween TweenTranslationAtRest(this ParentConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(getter: () => constraint.translationAtRest,
                        setter: translationAtRest => constraint.translationAtRest = translationAtRest,
                        to, duration).SetTarget(constraint);

    }

}
