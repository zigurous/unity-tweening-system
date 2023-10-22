using UnityEngine;
using UnityEngine.Animations;

namespace Zigurous.Tweening
{
    public static class LookAtConstraintTweens
    {
        public static Tween TweenWeight(this LookAtConstraint constraint, float to, float duration) =>
            Tweening.To(constraint, (target) => target.weight, (target, value) => target.weight = value, to, duration)
                    .SetReference(constraint);

        public static Tween TweenRoll(this LookAtConstraint constraint, float to, float duration) =>
            Tweening.To(constraint, (target) => target.roll, (target, value) => target.roll = value, to, duration)
                    .SetReference(constraint);

        public static Tween TweenRotationOffset(this LookAtConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(constraint, (target) => target.rotationOffset, (target, value) => target.rotationOffset = value, to, duration)
                    .SetReference(constraint);

        public static Tween TweenRotationAtRest(this LookAtConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(constraint, (target) => target.rotationAtRest, (target, value) => target.rotationAtRest = value, to, duration)
                    .SetReference(constraint);
    }

}
