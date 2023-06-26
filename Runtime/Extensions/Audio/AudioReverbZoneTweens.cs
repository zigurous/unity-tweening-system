using UnityEngine;

namespace Zigurous.Tweening
{
    public static class AudioReverbZoneTweens
    {
        public static Tween TweenMaxDistance(this AudioReverbZone filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.maxDistance, (source, value) => source.maxDistance = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenMinDistance(this AudioReverbZone filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.minDistance, (source, value) => source.minDistance = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenDiffusion(this AudioReverbZone filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.diffusion, (source, value) => source.diffusion = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenDensity(this AudioReverbZone filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.density, (source, value) => source.density = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenReverbDelay(this AudioReverbZone filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.reverbDelay, (source, value) => source.reverbDelay = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenReflectionsDelay(this AudioReverbZone filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.reflectionsDelay, (source, value) => source.reflectionsDelay = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenDecayHFRatio(this AudioReverbZone filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.decayHFRatio, (source, value) => source.decayHFRatio = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenDecayTime(this AudioReverbZone filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.decayTime, (source, value) => source.decayTime = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenHFReference(this AudioReverbZone filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.HFReference, (source, value) => source.HFReference = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenLFReference(this AudioReverbZone filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.LFReference, (source, value) => source.LFReference = value, to, duration)
                    .SetTarget(filter);
    }

}
