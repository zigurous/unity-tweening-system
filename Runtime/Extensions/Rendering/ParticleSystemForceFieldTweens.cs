using UnityEngine;

namespace Zigurous.Tweening
{
    public static class ParticleSystemForceFieldTweens
    {
        public static Tween TweenRotationRandomness(this ParticleSystemForceField forceField, Vector2 to, float duration) =>
            Tweening.To(forceField, (source) => source.rotationRandomness, (source, value) => source.rotationRandomness = value, to, duration)
                    .SetTarget(forceField);

        public static Tween TweenGravityFocus(this ParticleSystemForceField forceField, float to, float duration) =>
            Tweening.To(forceField, (source) => source.gravityFocus, (source, value) => source.gravityFocus = value, to, duration)
                    .SetTarget(forceField);

        public static Tween TweenLength(this ParticleSystemForceField forceField, float to, float duration) =>
            Tweening.To(forceField, (source) => source.length, (source, value) => source.length = value, to, duration)
                    .SetTarget(forceField);

        public static Tween TweenStartRange(this ParticleSystemForceField forceField, float to, float duration) =>
            Tweening.To(forceField, (source) => source.startRange, (source, value) => source.startRange = value, to, duration)
                    .SetTarget(forceField);

        public static Tween TweenEndRange(this ParticleSystemForceField forceField, float to, float duration) =>
            Tweening.To(forceField, (source) => source.endRange, (source, value) => source.endRange = value, to, duration)
                    .SetTarget(forceField);
    }

}
