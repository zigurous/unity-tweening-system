using UnityEngine;
using UnityEngine.Animations;

namespace Zigurous.Tweening
{
    public static class ScaleConstraintTweens
    {
        public static Tween TweenWeight(this ScaleConstraint constraint, float to, float duration) =>
            Tweening.To(constraint, (source) => source.weight, (source, value) => source.weight = value, to, duration)
                    .SetTarget(constraint);

        public static Tween TweenScaleAtRest(this ScaleConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(constraint, (source) => source.scaleAtRest, (source, value) => source.scaleAtRest = value, to, duration)
                    .SetTarget(constraint);

        public static Tween TweenScaleOffset(this ScaleConstraint constraint, Vector3 to, float duration) =>
            Tweening.To(constraint, (source) => source.scaleOffset, (source, value) => source.scaleOffset = value, to, duration)
                    .SetTarget(constraint);
    }

}
