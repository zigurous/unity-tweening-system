using UnityEngine;

namespace Zigurous.Tweening
{
    public static class ParticleSystemTweens
    {
        public static Tween TweenTime(this ParticleSystem particleSystem, float to, float duration) =>
            Tweening.To(particleSystem, (source) => source.time, (source, value) => source.time = value, to, duration)
                    .SetTarget(particleSystem);
    }

}
