using UnityEngine;

namespace Zigurous.Tweening
{
    public static class AudioSourceTweens
    {
        public static Tween TweenTime(this AudioSource audioSource, float to, float duration) =>
            Tweening.To(audioSource, (source) => source.time, (source, value) => source.time = value, to, duration)
                    .SetTarget(audioSource);

        public static Tween TweenPitch(this AudioSource audioSource, float to, float duration) =>
            Tweening.To(audioSource, (source) => source.pitch, (source, value) => source.pitch = value, to, duration)
                    .SetTarget(audioSource);

        public static Tween TweenVolume(this AudioSource audioSource, float to, float duration) =>
            Tweening.To(audioSource, (source) => source.volume, (source, value) => source.volume = value, to, duration)
                    .SetTarget(audioSource);

        public static Tween TweenPanStereo(this AudioSource audioSource, float to, float duration) =>
            Tweening.To(audioSource, (source) => source.panStereo, (source, value) => source.panStereo = value, to, duration)
                    .SetTarget(audioSource);

        public static Tween TweenSpatialBlend(this AudioSource audioSource, float to, float duration) =>
            Tweening.To(audioSource, (source) => source.spatialBlend, (source, value) => source.spatialBlend = value, to, duration)
                    .SetTarget(audioSource);

        public static Tween TweenReverbZoneMix(this AudioSource audioSource, float to, float duration) =>
            Tweening.To(audioSource, (source) => source.reverbZoneMix, (source, value) => source.reverbZoneMix = value, to, duration)
                    .SetTarget(audioSource);

        public static Tween TweenDopplerLevel(this AudioSource audioSource, float to, float duration) =>
            Tweening.To(audioSource, (source) => source.dopplerLevel, (source, value) => source.dopplerLevel = value, to, duration)
                    .SetTarget(audioSource);

        public static Tween TweenSpread(this AudioSource audioSource, float to, float duration) =>
            Tweening.To(audioSource, (source) => source.spread, (source, value) => source.spread = value, to, duration)
                    .SetTarget(audioSource);

        public static Tween TweenMinDistance(this AudioSource audioSource, float to, float duration) =>
            Tweening.To(audioSource, (source) => source.minDistance, (source, value) => source.minDistance = value, to, duration)
                    .SetTarget(audioSource);

        public static Tween TweenMaxDistance(this AudioSource audioSource, float to, float duration) =>
            Tweening.To(audioSource, (source) => source.maxDistance, (source, value) => source.maxDistance = value, to, duration)
                    .SetTarget(audioSource);
    }

}
