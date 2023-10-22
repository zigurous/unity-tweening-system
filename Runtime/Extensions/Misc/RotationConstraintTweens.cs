using UnityEngine;
using UnityEngine.Animations;

namespace Zigurous.Tweening
{
    public static class RotationConstraintTweens
    {
        public static Tween TweenWeight(this RotationConstraint constraint, float to, float duration) =>
            Tweening.To(constraint, (target) => target.weight, (target, value) => target.weight = value, to, duration)
                    .SetReference(constraint);

        public static Tween TweenRotationAtRest(this RotationConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(constraint, (target) => target.rotationAtRest, (target, value) => target.rotationAtRest = value, to, duration)
                    .SetReference(constraint);

        public static Tween TweenRotationOffset(this RotationConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(constraint, (target) => target.rotationOffset, (target, value) => target.rotationOffset = value, to, duration)
                    .SetReference(constraint);
    }

}
