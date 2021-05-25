using UnityEngine;
using UnityEngine.Animations;

namespace Zigurous.TweenEngine
{
    public static class AimConstraintTweens
    {
        public static Tween TweenWeight(this AimConstraint constraint, float to, float duration) =>
            Tweening.To(getter: () => constraint.weight,
                        setter: weight => constraint.weight = weight,
                        to, duration).SetTarget(constraint);

        public static Tween TweenUpVector(this AimConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(getter: () => constraint.upVector,
                        setter: upVector => constraint.upVector = upVector,
                        to, duration).SetTarget(constraint);

        public static Tween TweenWorldUpVector(this AimConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(getter: () => constraint.worldUpVector,
                        setter: worldUpVector => constraint.worldUpVector = worldUpVector,
                        to, duration).SetTarget(constraint);

        public static Tween TweenAimVector(this AimConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(getter: () => constraint.aimVector,
                        setter: aimVector => constraint.aimVector = aimVector,
                        to, duration).SetTarget(constraint);

        public static Tween TweenRotationOffset(this AimConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(getter: () => constraint.rotationOffset,
                        setter: rotationOffset => constraint.rotationOffset = rotationOffset,
                        to, duration).SetTarget(constraint);

        public static Tween TweenRotationAtRest(this AimConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(getter: () => constraint.rotationAtRest,
                        setter: rotationAtRest => constraint.rotationAtRest = rotationAtRest,
                        to, duration).SetTarget(constraint);

    }

}
