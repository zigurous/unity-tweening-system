using UnityEngine;
using UnityEngine.Animations;

namespace Zigurous.Tweening
{
    public static class AimConstraintTweens
    {
        public static Tween TweenWeight(this AimConstraint constraint, float to, float duration) =>
            Tweening.To(constraint, (target) => target.weight, (target, value) => target.weight = value, to, duration)
                    .SetReference(constraint);

        public static Tween TweenUpVector(this AimConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(constraint, (target) => target.upVector, (target, value) => target.upVector = value, to, duration)
                    .SetReference(constraint);

        public static Tween TweenWorldUpVector(this AimConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(constraint, (target) => target.worldUpVector, (target, value) => target.worldUpVector = value, to, duration)
                    .SetReference(constraint);

        public static Tween TweenAimVector(this AimConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(constraint, (target) => target.aimVector, (target, value) => target.aimVector = value, to, duration)
                    .SetReference(constraint);

        public static Tween TweenRotationOffset(this AimConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(constraint, (target) => target.rotationOffset, (target, value) => target.rotationOffset = value, to, duration)
                    .SetReference(constraint);

        public static Tween TweenRotationAtRest(this AimConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(constraint, (target) => target.rotationAtRest, (target, value) => target.rotationAtRest = value, to, duration)
                    .SetReference(constraint);
    }

}
