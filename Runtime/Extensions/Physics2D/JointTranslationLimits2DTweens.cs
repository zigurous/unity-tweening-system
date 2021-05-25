using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class JointTranslationLimits2DTweens
    {
        public static Tween TweenMin(this JointTranslationLimits2D limits, float to, float duration) =>
            Tweening.To(getter: () => limits.min,
                        setter: min => limits.min = min,
                        to, duration).SetTarget(limits);

        public static Tween TweenMax(this JointTranslationLimits2D limits, float to, float duration) =>
            Tweening.To(getter: () => limits.max,
                        setter: max => limits.max = max,
                        to, duration).SetTarget(limits);

    }

}
