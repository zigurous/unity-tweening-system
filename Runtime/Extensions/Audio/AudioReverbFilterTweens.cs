using UnityEngine;

namespace Zigurous.Tweening
{
    public static class AudioReverbFilterTweens
    {
        public static Tween TweenDensity(this AudioReverbFilter filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.density, (source, value) => source.density = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenDiffusion(this AudioReverbFilter filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.diffusion, (source, value) => source.diffusion = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenReverbDelay(this AudioReverbFilter filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.reverbDelay, (source, value) => source.reverbDelay = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenReverbLevel(this AudioReverbFilter filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.reverbLevel, (source, value) => source.reverbLevel = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenReflectionsDelay(this AudioReverbFilter filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.reflectionsDelay, (source, value) => source.reflectionsDelay = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenReflectionsLevel(this AudioReverbFilter filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.reflectionsLevel, (source, value) => source.reflectionsLevel = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenDecayHFRatio(this AudioReverbFilter filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.decayHFRatio, (source, value) => source.decayHFRatio = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenDecayTime(this AudioReverbFilter filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.decayTime, (source, value) => source.decayTime = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenRoom(this AudioReverbFilter filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.room, (source, value) => source.room = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenRoomHF(this AudioReverbFilter filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.roomHF, (source, value) => source.roomHF = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenRoomLF(this AudioReverbFilter filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.roomLF, (source, value) => source.roomLF = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenDryLevel(this AudioReverbFilter filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.dryLevel, (source, value) => source.dryLevel = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenHFReference(this AudioReverbFilter filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.hfReference, (source, value) => source.hfReference = value, to, duration)
                    .SetTarget(filter);

        public static Tween TweenLFReference(this AudioReverbFilter filter, float to, float duration) =>
            Tweening.To(filter, (source) => source.lfReference, (source, value) => source.lfReference = value, to, duration)
                    .SetTarget(filter);
    }

}
