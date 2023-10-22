using UnityEngine;

namespace Zigurous.Tweening
{
    public static class ParticleSystemTweens
    {
        public static Tween TweenTime(this ParticleSystem particleSystem, float to, float duration) =>
            Tweening.To(particleSystem, (target) => target.time, (target, value) => target.time = value, to, duration)
                    .SetReference(particleSystem);
    }

}
