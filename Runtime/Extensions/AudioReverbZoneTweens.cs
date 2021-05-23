using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public static class AudioReverbZoneTweens
    {
        public static Tween TweenMaxDistance(this AudioReverbZone filter, float to, float duration) =>
            Tweener.To(getter: () => filter.maxDistance,
                       setter: maxDistance => filter.maxDistance = maxDistance,
                       to, duration).SetTarget(filter);

        public static Tween TweenMinDistance(this AudioReverbZone filter, float to, float duration) =>
            Tweener.To(getter: () => filter.minDistance,
                       setter: minDistance => filter.minDistance = minDistance,
                       to, duration).SetTarget(filter);

        public static Tween TweenDiffusion(this AudioReverbZone filter, float to, float duration) =>
            Tweener.To(getter: () => filter.diffusion,
                       setter: diffusion => filter.diffusion = diffusion,
                       to, duration).SetTarget(filter);

        public static Tween TweenDensity(this AudioReverbZone filter, float to, float duration) =>
            Tweener.To(getter: () => filter.density,
                       setter: density => filter.density = density,
                       to, duration).SetTarget(filter);

        public static Tween TweenReverbDelay(this AudioReverbZone filter, float to, float duration) =>
            Tweener.To(getter: () => filter.reverbDelay,
                       setter: reverbDelay => filter.reverbDelay = reverbDelay,
                       to, duration).SetTarget(filter);

        public static Tween TweenReflectionsDelay(this AudioReverbZone filter, float to, float duration) =>
            Tweener.To(getter: () => filter.reflectionsDelay,
                       setter: reflectionsDelay => filter.reflectionsDelay = reflectionsDelay,
                       to, duration).SetTarget(filter);

        public static Tween TweenDecayHFRatio(this AudioReverbZone filter, float to, float duration) =>
            Tweener.To(getter: () => filter.decayHFRatio,
                       setter: decayHFRatio => filter.decayHFRatio = decayHFRatio,
                       to, duration).SetTarget(filter);

        public static Tween TweenDecayTime(this AudioReverbZone filter, float to, float duration) =>
            Tweener.To(getter: () => filter.decayTime,
                       setter: decayTime => filter.decayTime = decayTime,
                       to, duration).SetTarget(filter);

        public static Tween TweenHFReference(this AudioReverbZone filter, float to, float duration) =>
            Tweener.To(getter: () => filter.HFReference,
                       setter: HFReference => filter.HFReference = HFReference,
                       to, duration).SetTarget(filter);

        public static Tween TweenLFReference(this AudioReverbZone filter, float to, float duration) =>
            Tweener.To(getter: () => filter.LFReference,
                       setter: LFReference => filter.LFReference = LFReference,
                       to, duration).SetTarget(filter);

    }

}
