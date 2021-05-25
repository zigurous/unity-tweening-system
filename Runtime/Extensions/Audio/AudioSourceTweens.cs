using UnityEngine;

namespace Zigurous.Tweening
{
    public static class AudioSourceTweens
    {
        public static Tween TweenTime(this AudioSource source, float to, float duration) =>
            Tweening.To(getter: () => source.time,
                        setter: time => source.time = time,
                        to, duration).SetTarget(source);

        public static Tween TweenPitch(this AudioSource source, float to, float duration) =>
            Tweening.To(getter: () => source.pitch,
                        setter: pitch => source.pitch = pitch,
                        to, duration).SetTarget(source);

        public static Tween TweenVolume(this AudioSource source, float to, float duration) =>
            Tweening.To(getter: () => source.volume,
                        setter: volume => source.volume = volume,
                        to, duration).SetTarget(source);

        public static Tween TweenPanStereo(this AudioSource source, float to, float duration) =>
            Tweening.To(getter: () => source.panStereo,
                        setter: panStereo => source.panStereo = panStereo,
                        to, duration).SetTarget(source);

        public static Tween TweenSpatialBlend(this AudioSource source, float to, float duration) =>
            Tweening.To(getter: () => source.spatialBlend,
                        setter: spatialBlend => source.spatialBlend = spatialBlend,
                        to, duration).SetTarget(source);

        public static Tween TweenReverbZoneMix(this AudioSource source, float to, float duration) =>
            Tweening.To(getter: () => source.reverbZoneMix,
                        setter: reverbZoneMix => source.reverbZoneMix = reverbZoneMix,
                        to, duration).SetTarget(source);

        public static Tween TweenDopplerLevel(this AudioSource source, float to, float duration) =>
            Tweening.To(getter: () => source.dopplerLevel,
                        setter: dopplerLevel => source.dopplerLevel = dopplerLevel,
                        to, duration).SetTarget(source);

        public static Tween TweenSpread(this AudioSource source, float to, float duration) =>
            Tweening.To(getter: () => source.spread,
                        setter: spread => source.spread = spread,
                        to, duration).SetTarget(source);

        public static Tween TweenMinDistance(this AudioSource source, float to, float duration) =>
            Tweening.To(getter: () => source.minDistance,
                        setter: minDistance => source.minDistance = minDistance,
                        to, duration).SetTarget(source);

        public static Tween TweenMaxDistance(this AudioSource source, float to, float duration) =>
            Tweening.To(getter: () => source.maxDistance,
                        setter: maxDistance => source.maxDistance = maxDistance,
                        to, duration).SetTarget(source);

    }

}
