using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public static class AudioTweens
    {
        public static Tween TweenTime(this AudioSource audio, float to, float duration) =>
            Tweener.To(getter: () => audio.time,
                       setter: time => audio.time = time,
                       to, duration).SetTarget(audio);

        public static Tween TweenPitch(this AudioSource audio, float to, float duration) =>
            Tweener.To(getter: () => audio.pitch,
                       setter: pitch => audio.pitch = pitch,
                       to, duration).SetTarget(audio);

        public static Tween TweenVolume(this AudioSource audio, float to, float duration) =>
            Tweener.To(getter: () => audio.volume,
                       setter: volume => audio.volume = volume,
                       to, duration).SetTarget(audio);

        public static Tween TweenPanStereo(this AudioSource audio, float to, float duration) =>
            Tweener.To(getter: () => audio.panStereo,
                       setter: panStereo => audio.panStereo = panStereo,
                       to, duration).SetTarget(audio);

        public static Tween TweenSpatialBlend(this AudioSource audio, float to, float duration) =>
            Tweener.To(getter: () => audio.spatialBlend,
                       setter: spatialBlend => audio.spatialBlend = spatialBlend,
                       to, duration).SetTarget(audio);

        public static Tween TweenReverbZoneMix(this AudioSource audio, float to, float duration) =>
            Tweener.To(getter: () => audio.reverbZoneMix,
                       setter: reverbZoneMix => audio.reverbZoneMix = reverbZoneMix,
                       to, duration).SetTarget(audio);

        public static Tween TweenDopplerLevel(this AudioSource audio, float to, float duration) =>
            Tweener.To(getter: () => audio.dopplerLevel,
                       setter: dopplerLevel => audio.dopplerLevel = dopplerLevel,
                       to, duration).SetTarget(audio);

        public static Tween TweenSpread(this AudioSource audio, float to, float duration) =>
            Tweener.To(getter: () => audio.spread,
                       setter: spread => audio.spread = spread,
                       to, duration).SetTarget(audio);

        public static Tween TweenMinDistance(this AudioSource audio, float to, float duration) =>
            Tweener.To(getter: () => audio.minDistance,
                       setter: minDistance => audio.minDistance = minDistance,
                       to, duration).SetTarget(audio);

        public static Tween TweenMaxDistance(this AudioSource audio, float to, float duration) =>
            Tweener.To(getter: () => audio.maxDistance,
                       setter: maxDistance => audio.maxDistance = maxDistance,
                       to, duration).SetTarget(audio);

    }

}
