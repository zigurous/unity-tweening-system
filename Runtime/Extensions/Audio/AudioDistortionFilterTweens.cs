using UnityEngine;

namespace Zigurous.Tweening
{
    public static class AudioDistortionFilterTweens
    {
        public static Tween TweenDistortionLevel(this AudioDistortionFilter filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.distortionLevel, (source, value) => source.distortionLevel = value, to, duration)
                    .SetTarget(filter);
    }

}
