using UnityEngine;

namespace Zigurous.Tweening
{
    public static class AudioLowPassFilterTweens
    {
        public static Tween TweenCutoffFrequency(this AudioLowPassFilter filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.cutoffFrequency, (target, value) => target.cutoffFrequency = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenLowpassResonanceQ(this AudioLowPassFilter filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.lowpassResonanceQ, (target, value) => target.lowpassResonanceQ = value, to, duration)
                    .SetReference(filter);
    }

}
