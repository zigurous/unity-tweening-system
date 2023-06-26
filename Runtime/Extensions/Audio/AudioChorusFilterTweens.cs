using UnityEngine;

namespace Zigurous.Tweening
{
    public static class AudioChorusFilterTweens
    {
        public static Tween TweenDelay(this AudioChorusFilter filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.delay, (source, value) => source.delay = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenRate(this AudioChorusFilter filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.rate, (source, value) => source.rate = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenDepth(this AudioChorusFilter filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.depth, (source, value) => source.depth = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenDryMix(this AudioChorusFilter filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.dryMix, (source, value) => source.dryMix = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenWetMix1(this AudioChorusFilter filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.wetMix1, (source, value) => source.wetMix1 = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenWetMix2(this AudioChorusFilter filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.wetMix2, (source, value) => source.wetMix2 = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenWetMix3(this AudioChorusFilter filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.wetMix3, (source, value) => source.wetMix3 = value, to, duration)
                    .SetTarget(filter);
    }

}
