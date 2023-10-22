using UnityEngine;

namespace Zigurous.Tweening
{
    public static class ReflectionProbeTweens
    {
        public static Tween TweenCenter(this ReflectionProbe probe, Vector3 to, float duration) =>
            Tweening.To(probe, (target) => target.center, (target, value) => target.center = value, to, duration)
                    .SetReference(probe);

        public static Tween TweenSize(this ReflectionProbe probe, Vector3 to, float duration) =>
            Tweening.To(probe, (target) => target.size, (target, value) => target.size = value, to, duration)
                    .SetReference(probe);

        public static Tween TweenIntensity(this ReflectionProbe probe, float to, float duration) =>
            Tweening.To(probe, (target) => target.intensity, (target, value) => target.intensity = value, to, duration)
                    .SetReference(probe);

        public static Tween TweenFarClipPlane(this ReflectionProbe probe, float to, float duration) =>
            Tweening.To(probe, (target) => target.farClipPlane, (target, value) => target.farClipPlane = value, to, duration)
                    .SetReference(probe);

        public static Tween TweenNearClipPlane(this ReflectionProbe probe, float to, float duration) =>
            Tweening.To(probe, (target) => target.nearClipPlane, (target, value) => target.nearClipPlane = value, to, duration)
                    .SetReference(probe);

        public static Tween TweenBlendDistance(this ReflectionProbe probe, float to, float duration) =>
            Tweening.To(probe, (target) => target.blendDistance, (target, value) => target.blendDistance = value, to, duration)
                    .SetReference(probe);

        public static Tween TweenShadowDistance(this ReflectionProbe probe, float to, float duration) =>
            Tweening.To(probe, (target) => target.shadowDistance, (target, value) => target.shadowDistance = value, to, duration)
                    .SetReference(probe);

        public static Tween TweenBackgroundColor(this ReflectionProbe probe, Color to, float duration) =>
            Tweening.To(probe, (target) => target.backgroundColor, (target, value) => target.backgroundColor = value, to, duration)
                    .SetReference(probe);
    }

}
