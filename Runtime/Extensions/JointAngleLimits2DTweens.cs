using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class JointAngleLimits2DTweens
    {
        public static Tween TweenMin(this JointAngleLimits2D angleLimits, float to, float duration) =>
            Tweening.To(getter: () => angleLimits.min,
                        setter: min => angleLimits.min = min,
                        to, duration).SetTarget(angleLimits);

        public static Tween TweenMax(this JointAngleLimits2D angleLimits, float to, float duration) =>
            Tweening.To(getter: () => angleLimits.max,
                        setter: max => angleLimits.max = max,
                        to, duration).SetTarget(angleLimits);

    }

}
