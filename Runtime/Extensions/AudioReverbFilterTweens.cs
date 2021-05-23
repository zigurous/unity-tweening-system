using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public static class AudioReverbFilterTweens
    {
        public static Tween TweenDensity(this AudioReverbFilter filter, float to, float duration) =>
            Tweener.To(getter: () => filter.density,
                       setter: density => filter.density = density,
                       to, duration).SetTarget(filter);

        public static Tween TweenDiffusion(this AudioReverbFilter filter, float to, float duration) =>
            Tweener.To(getter: () => filter.diffusion,
                       setter: diffusion => filter.diffusion = diffusion,
                       to, duration).SetTarget(filter);

        public static Tween TweenReverbDelay(this AudioReverbFilter filter, float to, float duration) =>
            Tweener.To(getter: () => filter.reverbDelay,
                       setter: reverbDelay => filter.reverbDelay = reverbDelay,
                       to, duration).SetTarget(filter);

        public static Tween TweenReverbLevel(this AudioReverbFilter filter, float to, float duration) =>
            Tweener.To(getter: () => filter.reverbLevel,
                       setter: reverbLevel => filter.reverbLevel = reverbLevel,
                       to, duration).SetTarget(filter);

        public static Tween TweenReflectionsDelay(this AudioReverbFilter filter, float to, float duration) =>
            Tweener.To(getter: () => filter.reflectionsDelay,
                       setter: reflectionsDelay => filter.reflectionsDelay = reflectionsDelay,
                       to, duration).SetTarget(filter);

        public static Tween TweenReflectionsLevel(this AudioReverbFilter filter, float to, float duration) =>
            Tweener.To(getter: () => filter.reflectionsLevel,
                       setter: reflectionsLevel => filter.reflectionsLevel = reflectionsLevel,
                       to, duration).SetTarget(filter);

        public static Tween TweenDecayHFRatio(this AudioReverbFilter filter, float to, float duration) =>
            Tweener.To(getter: () => filter.decayHFRatio,
                       setter: decayHFRatio => filter.decayHFRatio = decayHFRatio,
                       to, duration).SetTarget(filter);

        public static Tween TweenDecayTime(this AudioReverbFilter filter, float to, float duration) =>
            Tweener.To(getter: () => filter.decayTime,
                       setter: decayTime => filter.decayTime = decayTime,
                       to, duration).SetTarget(filter);

        public static Tween TweenRoom(this AudioReverbFilter filter, float to, float duration) =>
            Tweener.To(getter: () => filter.room,
                       setter: room => filter.room = room,
                       to, duration).SetTarget(filter);

        public static Tween TweenRoomHF(this AudioReverbFilter filter, float to, float duration) =>
            Tweener.To(getter: () => filter.roomHF,
                       setter: roomHF => filter.roomHF = roomHF,
                       to, duration).SetTarget(filter);

        public static Tween TweenRoomLF(this AudioReverbFilter filter, float to, float duration) =>
            Tweener.To(getter: () => filter.roomLF,
                       setter: roomLF => filter.roomLF = roomLF,
                       to, duration).SetTarget(filter);

        public static Tween TweenDryLevel(this AudioReverbFilter filter, float to, float duration) =>
            Tweener.To(getter: () => filter.dryLevel,
                       setter: dryLevel => filter.dryLevel = dryLevel,
                       to, duration).SetTarget(filter);

        public static Tween TweenHFReference(this AudioReverbFilter filter, float to, float duration) =>
            Tweener.To(getter: () => filter.hfReference,
                       setter: hfReference => filter.hfReference = hfReference,
                       to, duration).SetTarget(filter);

        public static Tween TweenLFReference(this AudioReverbFilter filter, float to, float duration) =>
            Tweener.To(getter: () => filter.lfReference,
                       setter: lfReference => filter.lfReference = lfReference,
                       to, duration).SetTarget(filter);

    }

}
