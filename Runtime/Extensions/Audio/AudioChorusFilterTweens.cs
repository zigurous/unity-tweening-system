using UnityEngine;

namespace Zigurous.Tweening
{
    public static class AudioChorusFilterTweens
    {
        public static Tween TweenDelay(this AudioChorusFilter filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.delay, (target, value) => target.delay = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenRate(this AudioChorusFilter filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.rate, (target, value) => target.rate = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenDepth(this AudioChorusFilter filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.depth, (target, value) => target.depth = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenDryMix(this AudioChorusFilter filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.dryMix, (target, value) => target.dryMix = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenWetMix1(this AudioChorusFilter filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.wetMix1, (target, value) => target.wetMix1 = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenWetMix2(this AudioChorusFilter filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.wetMix2, (target, value) => target.wetMix2 = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenWetMix3(this AudioChorusFilter filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.wetMix3, (target, value) => target.wetMix3 = value, to, duration)
                    .SetReference(filter);
    }

}
