using UnityEngine;

namespace Zigurous.Tweening
{
    public static class LightTweens
    {
        public static Tween TweenColor(this Light light, Color to, float duration) =>
            Tweening.To(light, (source) => source.color, (source, value) => source.color = value, to, duration)
                    .SetTarget(light);

        public static Tween TweenColorTemperature(this Light light, float to, float duration) =>
            Tweening.To(light, (source) => source.colorTemperature, (source, value) => source.colorTemperature = value, to, duration)
                    .SetTarget(light);

        public static Tween TweenIntensity(this Light light, float to, float duration) =>
            Tweening.To(light, (source) => source.intensity, (source, value) => source.intensity = value, to, duration)
                    .SetTarget(light);

        public static Tween TweenBounceIntensity(this Light light, float to, float duration) =>
            Tweening.To(light, (source) => source.bounceIntensity, (source, value) => source.bounceIntensity = value, to, duration)
                    .SetTarget(light);

        public static Tween TweenRange(this Light light, float to, float duration) =>
            Tweening.To(light, (source) => source.range, (source, value) => source.range = value, to, duration)
                    .SetTarget(light);

        public static Tween TweenShadowStrength(this Light light, float to, float duration) =>
            Tweening.To(light, (source) => source.shadowStrength, (source, value) => source.shadowStrength = value, to, duration)
                    .SetTarget(light);

        public static Tween TweenShadowBias(this Light light, float to, float duration) =>
            Tweening.To(light, (source) => source.shadowBias, (source, value) => source.shadowBias = value, to, duration)
                    .SetTarget(light);

        public static Tween TweenShadowNormalBias(this Light light, float to, float duration) =>
            Tweening.To(light, (source) => source.shadowNormalBias, (source, value) => source.shadowNormalBias = value, to, duration)
                    .SetTarget(light);

        public static Tween TweenShadowNearPlane(this Light light, float to, float duration) =>
            Tweening.To(light, (source) => source.shadowNearPlane, (source, value) => source.shadowNearPlane = value, to, duration)
                    .SetTarget(light);

        public static Tween TweenSpotAngle(this Light light, float to, float duration) =>
            Tweening.To(light, (source) => source.spotAngle, (source, value) => source.spotAngle = value, to, duration)
                    .SetTarget(light);

        public static Tween TweenInnerSpotAngle(this Light light, float to, float duration) =>
            Tweening.To(light, (source) => source.innerSpotAngle, (source, value) => source.innerSpotAngle = value, to, duration)
                    .SetTarget(light);

        public static Tween TweenCookieSize(this Light light, float to, float duration) =>
            Tweening.To(light, (source) => source.cookieSize, (source, value) => source.cookieSize = value, to, duration)
                    .SetTarget(light);

        public static Tween TweenBoundingSphereOverride(this Light light, Vector4 to, float duration) =>
            Tweening.To(light, (source) => source.boundingSphereOverride, (source, value) => source.boundingSphereOverride = value, to, duration)
                    .SetTarget(light);
    }

}
