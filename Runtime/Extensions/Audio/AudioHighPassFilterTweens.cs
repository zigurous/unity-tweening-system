using UnityEngine;

namespace Zigurous.Tweening
{
    public static class AudioHighPassFilterTweens
    {
        public static Tween TweenCutoffFrequency(this AudioHighPassFilter filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.cutoffFrequency, (target, value) => target.cutoffFrequency = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenHighpassResonanceQ(this AudioHighPassFilter filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.highpassResonanceQ, (target, value) => target.highpassResonanceQ = value, to, duration)
                    .SetReference(filter);
    }

}
