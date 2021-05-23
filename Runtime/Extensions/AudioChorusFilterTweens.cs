using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public static class AudioChorusFilterTweens
    {
        public static Tween TweenDelay(this AudioChorusFilter filter, float to, float duration) =>
            Tweener.To(getter: () => filter.delay,
                       setter: delay => filter.delay = delay,
                       to, duration).SetTarget(filter);

        public static Tween TweenRate(this AudioChorusFilter filter, float to, float duration) =>
            Tweener.To(getter: () => filter.rate,
                       setter: rate => filter.rate = rate,
                       to, duration).SetTarget(filter);

        public static Tween TweenDepth(this AudioChorusFilter filter, float to, float duration) =>
            Tweener.To(getter: () => filter.depth,
                       setter: depth => filter.depth = depth,
                       to, duration).SetTarget(filter);

        public static Tween TweenDryMix(this AudioChorusFilter filter, float to, float duration) =>
            Tweener.To(getter: () => filter.dryMix,
                       setter: dryMix => filter.dryMix = dryMix,
                       to, duration).SetTarget(filter);

        public static Tween TweenWetMix1(this AudioChorusFilter filter, float to, float duration) =>
            Tweener.To(getter: () => filter.wetMix1,
                       setter: wetMix1 => filter.wetMix1 = wetMix1,
                       to, duration).SetTarget(filter);

        public static Tween TweenWetMix2(this AudioChorusFilter filter, float to, float duration) =>
            Tweener.To(getter: () => filter.wetMix2,
                       setter: wetMix2 => filter.wetMix2 = wetMix2,
                       to, duration).SetTarget(filter);

        public static Tween TweenWetMix3(this AudioChorusFilter filter, float to, float duration) =>
            Tweener.To(getter: () => filter.wetMix3,
                       setter: wetMix3 => filter.wetMix3 = wetMix3,
                       to, duration).SetTarget(filter);

    }

}
