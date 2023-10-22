using UnityEngine;

namespace Zigurous.Tweening
{
    public static class AudioReverbZoneTweens
    {
        public static Tween TweenMaxDistance(this AudioReverbZone filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.maxDistance, (target, value) => target.maxDistance = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenMinDistance(this AudioReverbZone filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.minDistance, (target, value) => target.minDistance = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenDiffusion(this AudioReverbZone filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.diffusion, (target, value) => target.diffusion = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenDensity(this AudioReverbZone filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.density, (target, value) => target.density = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenReverbDelay(this AudioReverbZone filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.reverbDelay, (target, value) => target.reverbDelay = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenReflectionsDelay(this AudioReverbZone filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.reflectionsDelay, (target, value) => target.reflectionsDelay = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenDecayHFRatio(this AudioReverbZone filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.decayHFRatio, (target, value) => target.decayHFRatio = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenDecayTime(this AudioReverbZone filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.decayTime, (target, value) => target.decayTime = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenHFReference(this AudioReverbZone filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.HFReference, (target, value) => target.HFReference = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenLFReference(this AudioReverbZone filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.LFReference, (target, value) => target.LFReference = value, to, duration)
                    .SetReference(filter);
    }

}
