using UnityEngine;
using UnityEngine.Animations;

namespace Zigurous.Tweening
{
    public static class RotationConstraintTweens
    {
        public static Tween TweenWeight(this RotationConstraint constraint, float to, float duration) =>
            Tweening.To(constraint, (source) => source.weight, (source, value) => source.weight = value, to, duration)
                    .SetTarget(constraint);

        public static Tween TweenRotationAtRest(this RotationConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(constraint, (source) => source.rotationAtRest, (source, value) => source.rotationAtRest = value, to, duration)
                    .SetTarget(constraint);

        public static Tween TweenRotationOffset(this RotationConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(constraint, (source) => source.rotationOffset, (source, value) => source.rotationOffset = value, to, duration)
                    .SetTarget(constraint);
    }

}
