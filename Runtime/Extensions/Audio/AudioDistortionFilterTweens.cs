using UnityEngine;

namespace Zigurous.Tweening
{
    public static class AudioDistortionFilterTweens
    {
        public static Tween TweenDistortionLevel(this AudioDistortionFilter filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.distortionLevel, (target, value) => target.distortionLevel = value, to, duration)
                    .SetReference(filter);
    }

}
