using UnityEngine;

namespace Zigurous.Tweening
{
    public static class ParticleSystemForceFieldTweens
    {
        public static Tween TweenRotationRandomness(this ParticleSystemForceField forceField, Vector2 to, float duration) =>
            Tweening.To(forceField, (target) => target.rotationRandomness, (target, value) => target.rotationRandomness = value, to, duration)
                    .SetReference(forceField);

        public static Tween TweenGravityFocus(this ParticleSystemForceField forceField, float to, float duration) =>
            Tweening.To(forceField, (target) => target.gravityFocus, (target, value) => target.gravityFocus = value, to, duration)
                    .SetReference(forceField);

        public static Tween TweenLength(this ParticleSystemForceField forceField, float to, float duration) =>
            Tweening.To(forceField, (target) => target.length, (target, value) => target.length = value, to, duration)
                    .SetReference(forceField);

        public static Tween TweenStartRange(this ParticleSystemForceField forceField, float to, float duration) =>
            Tweening.To(forceField, (target) => target.startRange, (target, value) => target.startRange = value, to, duration)
                    .SetReference(forceField);

        public static Tween TweenEndRange(this ParticleSystemForceField forceField, float to, float duration) =>
            Tweening.To(forceField, (target) => target.endRange, (target, value) => target.endRange = value, to, duration)
                    .SetReference(forceField);
    }

}
