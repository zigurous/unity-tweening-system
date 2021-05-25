using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class JointAngleLimits2DTweens
    {
        public static Tween TweenMin(this JointAngleLimits2D limits, float to, float duration) =>
            Tweening.To(getter: () => limits.min,
                        setter: min => limits.min = min,
                        to, duration).SetTarget(limits);

        public static Tween TweenMax(this JointAngleLimits2D limits, float to, float duration) =>
            Tweening.To(getter: () => limits.max,
                        setter: max => limits.max = max,
                        to, duration).SetTarget(limits);

    }

}
