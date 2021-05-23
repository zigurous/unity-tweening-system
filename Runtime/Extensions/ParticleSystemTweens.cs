using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class ParticleSystemTweens
    {
        public static Tween TweenTime(this ParticleSystem particleSystem, float to, float duration) =>
            Tweening.To(getter: () => particleSystem.time,
                        setter: time => particleSystem.time = time,
                        to, duration).SetTarget(particleSystem);

    }

}
