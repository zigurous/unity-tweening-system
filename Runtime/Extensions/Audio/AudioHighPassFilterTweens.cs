using UnityEngine;

namespace Zigurous.Tweening
{
    public static class AudioHighPassFilterTweens
    {
        public static Tween TweenCutoffFrequency(this AudioHighPassFilter filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.cutoffFrequency, (source, value) => source.cutoffFrequency = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenHighpassResonanceQ(this AudioHighPassFilter filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.highpassResonanceQ, (source, value) => source.highpassResonanceQ = value, to, duration)
                    .SetTarget(filter);
    }

}
