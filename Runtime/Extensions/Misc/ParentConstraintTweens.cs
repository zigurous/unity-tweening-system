using UnityEngine;
using UnityEngine.Animations;

namespace Zigurous.Tweening
{
    public static class ParentConstraintTweens
    {
        public static Tween TweenWeight(this ParentConstraint constraint, float to, float duration) =>
            Tweening.To(constraint, (target) => target.weight, (target, value) => target.weight = value, to, duration)
                    .SetReference(constraint);

        public static Tween TweenRotationAtRest(this ParentConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(constraint, (target) => target.rotationAtRest, (target, value) => target.rotationAtRest = value, to, duration)
                    .SetReference(constraint);

        public static Tween TweenTranslationAtRest(this ParentConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(constraint, (target) => target.translationAtRest, (target, value) => target.translationAtRest = value, to, duration)
                    .SetReference(constraint);
    }

}
