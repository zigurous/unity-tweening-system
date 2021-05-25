using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class AudioEchoFilterTweens
    {
        public static Tween TweenDelay(this AudioEchoFilter filter, float to, float duration) =>
            Tweening.To(getter: () => filter.delay,
                        setter: delay => filter.delay = delay,
                        to, duration).SetTarget(filter);

        public static Tween TweenDecayRatio(this AudioEchoFilter filter, float to, float duration) =>
            Tweening.To(getter: () => filter.decayRatio,
                        setter: decayRatio => filter.decayRatio = decayRatio,
                        to, duration).SetTarget(filter);

        public static Tween TweenDryMix(this AudioEchoFilter filter, float to, float duration) =>
            Tweening.To(getter: () => filter.dryMix,
                        setter: dryMix => filter.dryMix = dryMix,
                        to, duration).SetTarget(filter);

        public static Tween TweenWetMix(this AudioEchoFilter filter, float to, float duration) =>
            Tweening.To(getter: () => filter.wetMix,
                        setter: wetMix => filter.wetMix = wetMix,
                        to, duration).SetTarget(filter);

    }

}
