using UnityEngine;

namespace Zigurous.Tweening
{
    public static class AudioReverbFilterTweens
    {
        public static Tween TweenDensity(this AudioReverbFilter filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.density, (target, value) => target.density = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenDiffusion(this AudioReverbFilter filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.diffusion, (target, value) => target.diffusion = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenReverbDelay(this AudioReverbFilter filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.reverbDelay, (target, value) => target.reverbDelay = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenReverbLevel(this AudioReverbFilter filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.reverbLevel, (target, value) => target.reverbLevel = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenReflectionsDelay(this AudioReverbFilter filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.reflectionsDelay, (target, value) => target.reflectionsDelay = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenReflectionsLevel(this AudioReverbFilter filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.reflectionsLevel, (target, value) => target.reflectionsLevel = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenDecayHFRatio(this AudioReverbFilter filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.decayHFRatio, (target, value) => target.decayHFRatio = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenDecayTime(this AudioReverbFilter filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.decayTime, (target, value) => target.decayTime = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenRoom(this AudioReverbFilter filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.room, (target, value) => target.room = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenRoomHF(this AudioReverbFilter filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.roomHF, (target, value) => target.roomHF = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenRoomLF(this AudioReverbFilter filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.roomLF, (target, value) => target.roomLF = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenDryLevel(this AudioReverbFilter filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.dryLevel, (target, value) => target.dryLevel = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenHFReference(this AudioReverbFilter filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.hfReference, (target, value) => target.hfReference = value, to, duration)
                    .SetReference(filter);

        public static Tween TweenLFReference(this AudioReverbFilter filter, float to, float duration) =>
            Tweening.To(filter, (target) => target.lfReference, (target, value) => target.lfReference = value, to, duration)
                    .SetReference(filter);
    }

}
