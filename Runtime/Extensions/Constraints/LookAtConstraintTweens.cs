using UnityEngine;
using UnityEngine.Animations;

namespace Zigurous.TweenEngine
{
    public static class LookAtConstraintTweens
    {
        public static Tween TweenWeight(this LookAtConstraint constraint, float to, float duration) =>
            Tweening.To(getter: () => constraint.weight,
                        setter: weight => constraint.weight = weight,
                        to, duration).SetTarget(constraint);

        public static Tween TweenRoll(this LookAtConstraint constraint, float to, float duration) =>
            Tweening.To(getter: () => constraint.roll,
                        setter: roll => constraint.roll = roll,
                        to, duration).SetTarget(constraint);

        public static Tween TweenRotationOffset(this LookAtConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(getter: () => constraint.rotationOffset,
                        setter: rotationOffset => constraint.rotationOffset = rotationOffset,
                        to, duration).SetTarget(constraint);

        public static Tween TweenRotationAtRest(this LookAtConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(getter: () => constraint.rotationAtRest,
                        setter: rotationAtRest => constraint.rotationAtRest = rotationAtRest,
                        to, duration).SetTarget(constraint);

    }

}
