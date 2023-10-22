using UnityEngine;

namespace Zigurous.Tweening
{
    public static class AudioEchoFilterTweens
    {
        public static Tween TweenDelay(this AudioEchoFilter filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.delay, (target, value) => target.delay = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenDecayRatio(this AudioEchoFilter filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.decayRatio, (target, value) => target.decayRatio = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenDryMix(this AudioEchoFilter filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.dryMix, (target, value) => target.dryMix = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenWetMix(this AudioEchoFilter filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.wetMix, (target, value) => target.wetMix = value, to, duration)
                    .SetReference(filter);
    }

}
