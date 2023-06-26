using UnityEngine;

namespace Zigurous.Tweening
{
    public static class AudioEchoFilterTweens
    {
        public static Tween TweenDelay(this AudioEchoFilter filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.delay, (source, value) => source.delay = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenDecayRatio(this AudioEchoFilter filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.decayRatio, (source, value) => source.decayRatio = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenDryMix(this AudioEchoFilter filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.dryMix, (source, value) => source.dryMix = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenWetMix(this AudioEchoFilter filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.wetMix, (source, value) => source.wetMix = value, to, duration)
                    .SetTarget(filter);
    }

}
