using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class AudioDistortionFilterTweens
    {
        public static Tween TweenDistortionLevel(this AudioDistortionFilter filter, float to, float duration) =>
            Tweening.To(getter: () => filter.distortionLevel,
                        setter: distortionLevel => filter.distortionLevel = distortionLevel,
                        to, duration).SetTarget(filter);

    }

}
