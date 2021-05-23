using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public static class AudioHighPassFilterTweens
    {
        public static Tween TweenCutoffFrequency(this AudioHighPassFilter filter, float to, float duration) =>
            Tweener.To(getter: () => filter.cutoffFrequency,
                       setter: cutoffFrequency => filter.cutoffFrequency = cutoffFrequency,
                       to, duration).SetTarget(filter);

        public static Tween TweenHighpassResonanceQ(this AudioHighPassFilter filter, float to, float duration) =>
            Tweener.To(getter: () => filter.highpassResonanceQ,
                       setter: highpassResonanceQ => filter.highpassResonanceQ = highpassResonanceQ,
                       to, duration).SetTarget(filter);

    }

}
