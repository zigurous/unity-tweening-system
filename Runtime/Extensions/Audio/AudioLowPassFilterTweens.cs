using UnityEngine;

namespace Zigurous.Tweening
{
    public static class AudioLowPassFilterTweens
    {
        public static Tween TweenCutoffFrequency(this AudioLowPassFilter filter, float to, float duration) =>
            Tweening.To(getter: () => filter.cutoffFrequency,
                        setter: cutoffFrequency => filter.cutoffFrequency = cutoffFrequency,
                        to, duration).SetTarget(filter);

        public static Tween TweenLowpassResonanceQ(this AudioLowPassFilter filter, float to, float duration) =>
            Tweening.To(getter: () => filter.lowpassResonanceQ,
                        setter: lowpassResonanceQ => filter.lowpassResonanceQ = lowpassResonanceQ,
                        to, duration).SetTarget(filter);

    }

}
