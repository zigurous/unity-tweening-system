using UnityEngine;
using UnityEngine.Animations;

namespace Zigurous.Tweening
{
    public static class ScaleConstraintTweens
    {
        public static Tween TweenWeight(this ScaleConstraint constraint, float to, float duration) =>
            Tweening.To(constraint, (target) => target.weight, (target, value) => target.weight = value, to, duration)
                    .SetReference(constraint);

        public static Tween TweenScaleAtRest(this ScaleConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(constraint, (target) => target.scaleAtRest, (target, value) => target.scaleAtRest = value, to, duration)
                    .SetReference(constraint);

        public static Tween TweenScaleOffset(this ScaleConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(constraint, (target) => target.scaleOffset, (target, value) => target.scaleOffset = value, to, duration)
                    .SetReference(constraint);
    }

}
