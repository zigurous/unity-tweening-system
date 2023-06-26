using UnityEngine;

namespace Zigurous.Tweening
{
    public static class ReflectionProbeTweens
    {
        public static Tween TweenCenter(this ReflectionProbe probe, Vector3 to, float duration) =>
            Tweening.To(probe, (source) => source.center, (source, value) => source.center = value, to, duration)
                    .SetTarget(probe);

        public static Tween TweenSize(this ReflectionProbe probe, Vector3 to, float duration) =>
            Tweening.To(probe, (source) => source.size, (source, value) => source.size = value, to, duration)
                    .SetTarget(probe);

        public static Tween TweenIntensity(this ReflectionProbe probe, float to, float duration) =>
            Tweening.To(probe, (source) => source.intensity, (source, value) => source.intensity = value, to, duration)
                    .SetTarget(probe);

        public static Tween TweenFarClipPlane(this ReflectionProbe probe, float to, float duration) =>
            Tweening.To(probe, (source) => source.farClipPlane, (source, value) => source.farClipPlane = value, to, duration)
                    .SetTarget(probe);

        public static Tween TweenNearClipPlane(this ReflectionProbe probe, float to, float duration) =>
            Tweening.To(probe, (source) => source.nearClipPlane, (source, value) => source.nearClipPlane = value, to, duration)
                    .SetTarget(probe);

        public static Tween TweenBlendDistance(this ReflectionProbe probe, float to, float duration) =>
            Tweening.To(probe, (source) => source.blendDistance, (source, value) => source.blendDistance = value, to, duration)
                    .SetTarget(probe);

        public static Tween TweenShadowDistance(this ReflectionProbe probe, float to, float duration) =>
            Tweening.To(probe, (source) => source.shadowDistance, (source, value) => source.shadowDistance = value, to, duration)
                    .SetTarget(probe);

        public static Tween TweenBackgroundColor(this ReflectionProbe probe, Color to, float duration) =>
            Tweening.To(probe, (source) => source.backgroundColor, (source, value) => source.backgroundColor = value, to, duration)
                    .SetTarget(probe);
    }

}
