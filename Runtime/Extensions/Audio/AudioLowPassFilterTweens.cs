using UnityEngine;

namespace Zigurous.Tweening
{
    public static class AudioLowPassFilterTweens
    {
        public static Tween TweenCutoffFrequency(this AudioLowPassFilter filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.cutoffFrequency, (source, value) => source.cutoffFrequency = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenLowpassResonanceQ(this AudioLowPassFilter filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.lowpassResonanceQ, (source, value) => source.lowpassResonanceQ = value, to, duration)
                    .SetTarget(filter);
    }

}
