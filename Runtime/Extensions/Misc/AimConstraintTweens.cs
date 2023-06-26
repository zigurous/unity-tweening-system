using UnityEngine;
using UnityEngine.Animations;

namespace Zigurous.Tweening
{
    public static class AimConstraintTweens
    {
        public static Tween TweenWeight(this AimConstraint constraint, float to, float duration) =>
            Tweening.To(constraint, (source) => source.weight, (source, value) => source.weight = value, to, duration)
                    .SetTarget(constraint);

        public static Tween TweenUpVector(this AimConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(constraint, (source) => source.upVector, (source, value) => source.upVector = value, to, duration)
                    .SetTarget(constraint);

        public static Tween TweenWorldUpVector(this AimConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(constraint, (source) => source.worldUpVector, (source, value) => source.worldUpVector = value, to, duration)
                    .SetTarget(constraint);

        public static Tween TweenAimVector(this AimConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(constraint, (source) => source.aimVector, (source, value) => source.aimVector = value, to, duration)
                    .SetTarget(constraint);

        public static Tween TweenRotationOffset(this AimConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(constraint, (source) => source.rotationOffset, (source, value) => source.rotationOffset = value, to, duration)
                    .SetTarget(constraint);

        public static Tween TweenRotationAtRest(this AimConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(constraint, (source) => source.rotationAtRest, (source, value) => source.rotationAtRest = value, to, duration)
                    .SetTarget(constraint);
    }

}
