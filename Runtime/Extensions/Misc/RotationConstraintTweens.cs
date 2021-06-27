using UnityEngine;
using UnityEngine.Animations;

namespace Zigurous.Tweening
{
    public static class RotationConstraintTweens
    {
        public static Tween TweenWeight(this RotationConstraint constraint, float to, float duration) =>
            Tweening.To(getter: () => constraint.weight,
                        setter: weight => constraint.weight = weight,
                        to, duration).SetTarget(constraint);

        public static Tween TweenRotationAtRest(this RotationConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(getter: () => constraint.rotationAtRest,
                        setter: rotationAtRest => constraint.rotationAtRest = rotationAtRest,
                        to, duration).SetTarget(constraint);

        public static Tween TweenRotationOffset(this RotationConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(getter: () => constraint.rotationOffset,
                        setter: rotationOffset => constraint.rotationOffset = rotationOffset,
                        to, duration).SetTarget(constraint);

    }

}
