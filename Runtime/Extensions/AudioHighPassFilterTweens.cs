using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class AudioHighPassFilterTweens
    {
        public static Tween TweenCutoffFrequency(this AudioHighPassFilter filter, float to, float duration) =>
            Tweening.To(getter: () => filter.cutoffFrequency,
                        setter: cutoffFrequency => filter.cutoffFrequency = cutoffFrequency,
                        to, duration).SetTarget(filter);

        public static Tween TweenHighpassResonanceQ(this AudioHighPassFilter filter, float to, float duration) =>
            Tweening.To(getter: () => filter.highpassResonanceQ,
                        setter: highpassResonanceQ => filter.highpassResonanceQ = highpassResonanceQ,
                        to, duration).SetTarget(filter);

    }

}
