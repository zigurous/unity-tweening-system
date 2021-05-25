using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class ParticleSystemForceFieldTweens
    {
        public static Tween TweenRotationRandomness(this ParticleSystemForceField forceField, Vector2 to, float duration) =>
            Tweening.To(getter: () => forceField.rotationRandomness,
                        setter: rotationRandomness => forceField.rotationRandomness = rotationRandomness,
                        to, duration).SetTarget(forceField);

        public static Tween TweenGravityFocus(this ParticleSystemForceField forceField, float to, float duration) =>
            Tweening.To(getter: () => forceField.gravityFocus,
                        setter: gravityFocus => forceField.gravityFocus = gravityFocus,
                        to, duration).SetTarget(forceField);

        public static Tween TweenLength(this ParticleSystemForceField forceField, float to, float duration) =>
            Tweening.To(getter: () => forceField.length,
                        setter: length => forceField.length = length,
                        to, duration).SetTarget(forceField);

        public static Tween TweenStartRange(this ParticleSystemForceField forceField, float to, float duration) =>
            Tweening.To(getter: () => forceField.startRange,
                        setter: startRange => forceField.startRange = startRange,
                        to, duration).SetTarget(forceField);

        public static Tween TweenEndRange(this ParticleSystemForceField forceField, float to, float duration) =>
            Tweening.To(getter: () => forceField.endRange,
                        setter: endRange => forceField.endRange = endRange,
                        to, duration).SetTarget(forceField);

    }

}
