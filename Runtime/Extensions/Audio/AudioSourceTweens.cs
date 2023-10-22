using UnityEngine;

namespace Zigurous.Tweening
{
    public static class AudioSourceTweens
    {
        public static Tween TweenTime(this AudioSource audioSource, float to, float duration) =>
            Tweening.To(audioSource, (target) => target.time, (target, value) => target.time = value, to, duration)
                    .SetReference(audioSource);

        public static Tween TweenPitch(this AudioSource audioSource, float to, float duration) =>
            Tweening.To(audioSource, (target) => target.pitch, (target, value) => target.pitch = value, to, duration)
                    .SetReference(audioSource);

        public static Tween TweenVolume(this AudioSource audioSource, float to, float duration) =>
            Tweening.To(audioSource, (target) => target.volume, (target, value) => target.volume = value, to, duration)
                    .SetReference(audioSource);

        public static Tween TweenPanStereo(this AudioSource audioSource, float to, float duration) =>
            Tweening.To(audioSource, (target) => target.panStereo, (target, value) => target.panStereo = value, to, duration)
                    .SetReference(audioSource);

        public static Tween TweenSpatialBlend(this AudioSource audioSource, float to, float duration) =>
            Tweening.To(audioSource, (target) => target.spatialBlend, (target, value) => target.spatialBlend = value, to, duration)
                    .SetReference(audioSource);

        public static Tween TweenReverbZoneMix(this AudioSource audioSource, float to, float duration) =>
            Tweening.To(audioSource, (target) => target.reverbZoneMix, (target, value) => target.reverbZoneMix = value, to, duration)
                    .SetReference(audioSource);

        public static Tween TweenDopplerLevel(this AudioSource audioSource, float to, float duration) =>
            Tweening.To(audioSource, (target) => target.dopplerLevel, (target, value) => target.dopplerLevel = value, to, duration)
                    .SetReference(audioSource);

        public static Tween TweenSpread(this AudioSource audioSource, float to, float duration) =>
            Tweening.To(audioSource, (target) => target.spread, (target, value) => target.spread = value, to, duration)
                    .SetReference(audioSource);

        public static Tween TweenMinDistance(this AudioSource audioSource, float to, float duration) =>
            Tweening.To(audioSource, (target) => target.minDistance, (target, value) => target.minDistance = value, to, duration)
                    .SetReference(audioSource);

        public static Tween TweenMaxDistance(this AudioSource audioSource, float to, float duration) =>
            Tweening.To(audioSource, (target) => target.maxDistance, (target, value) => target.maxDistance = value, to, duration)
                    .SetReference(audioSource);
    }

}
