using UnityEngine;
using UnityEngine.Animations;

namespace Zigurous.Tweening
{
    public static class LookAtConstraintTweens
    {
        public static Tween TweenWeight(this LookAtConstraint constraint, float to, float duration) =>
            Tweening.To(constraint, (source) => source.weight, (source, value) => source.weight = value, to, duration)
                    .SetTarget(constraint);

        public static Tween TweenRoll(this LookAtConstraint constraint, float to, float duration) =>
            Tweening.To(constraint, (source) => source.roll, (source, value) => source.roll = value, to, duration)
                    .SetTarget(constraint);

        public static Tween TweenRotationOffset(this LookAtConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(constraint, (source) => source.rotationOffset, (source, value) => source.rotationOffset = value, to, duration)
                    .SetTarget(constraint);

        public static Tween TweenRotationAtRest(this LookAtConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(constraint, (source) => source.rotationAtRest, (source, value) => source.rotationAtRest = value, to, duration)
                    .SetTarget(constraint);
    }

}
