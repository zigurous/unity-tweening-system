using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public static class AudioDistortionFilterTweens
    {
        public static Tween TweenDistortionLevel(this AudioDistortionFilter filter, float to, float duration) =>
            Tweener.To(getter: () => filter.distortionLevel,
                       setter: distortionLevel => filter.distortionLevel = distortionLevel,
                       to, duration).SetTarget(filter);

    }

}
