using UnityEngine;

namespace Zigurous.Tweening
{
    public static class ReflectionProbeTweens
    {
        public static Tween TweenCenter(this ReflectionProbe probe, Vector3 to, float duration) =>
            Tweening.To(getter: () => probe.center,
                        setter: center => probe.center = center,
                        to, duration).SetTarget(probe);

        public static Tween TweenSize(this ReflectionProbe probe, Vector3 to, float duration) =>
            Tweening.To(getter: () => probe.size,
                        setter: size => probe.size = size,
                        to, duration).SetTarget(probe);

        public static Tween TweenIntensity(this ReflectionProbe probe, float to, float duration) =>
            Tweening.To(getter: () => probe.intensity,
                        setter: intensity => probe.intensity = intensity,
                        to, duration).SetTarget(probe);

        public static Tween TweenFarClipPlane(this ReflectionProbe probe, float to, float duration) =>
            Tweening.To(getter: () => probe.farClipPlane,
                        setter: farClipPlane => probe.farClipPlane = farClipPlane,
                        to, duration).SetTarget(probe);

        public static Tween TweenNearClipPlane(this ReflectionProbe probe, float to, float duration) =>
            Tweening.To(getter: () => probe.nearClipPlane,
                        setter: nearClipPlane => probe.nearClipPlane = nearClipPlane,
                        to, duration).SetTarget(probe);

        public static Tween TweenBlendDistance(this ReflectionProbe probe, float to, float duration) =>
            Tweening.To(getter: () => probe.blendDistance,
                        setter: blendDistance => probe.blendDistance = blendDistance,
                        to, duration).SetTarget(probe);

        public static Tween TweenShadowDistance(this ReflectionProbe probe, float to, float duration) =>
            Tweening.To(getter: () => probe.shadowDistance,
                        setter: shadowDistance => probe.shadowDistance = shadowDistance,
                        to, duration).SetTarget(probe);

        public static Tween TweenBackgroundColor(this ReflectionProbe probe, Color to, float duration) =>
            Tweening.To(getter: () => probe.backgroundColor,
                        setter: backgroundColor => probe.backgroundColor = backgroundColor,
                        to, duration).SetTarget(probe);

    }

}
