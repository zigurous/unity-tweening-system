using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class LightTweens
    {
        public static Tween TweenColor(this Light light, Color to, float duration) =>
            Tweening.To(getter: () => light.color,
                        setter: color => light.color = color,
                        to, duration).SetTarget(light);

        public static Tween TweenColorTemperature(this Light light, float to, float duration) =>
            Tweening.To(getter: () => light.colorTemperature,
                        setter: colorTemperature => light.colorTemperature = colorTemperature,
                        to, duration).SetTarget(light);

        public static Tween TweenIntensity(this Light light, float to, float duration) =>
            Tweening.To(getter: () => light.intensity,
                        setter: intensity => light.intensity = intensity,
                        to, duration).SetTarget(light);

        public static Tween TweenBounceIntensity(this Light light, float to, float duration) =>
            Tweening.To(getter: () => light.bounceIntensity,
                        setter: bounceIntensity => light.bounceIntensity = bounceIntensity,
                        to, duration).SetTarget(light);

        public static Tween TweenRange(this Light light, float to, float duration) =>
            Tweening.To(getter: () => light.range,
                        setter: range => light.range = range,
                        to, duration).SetTarget(light);

        public static Tween TweenShadowRadius(this Light light, float to, float duration) =>
            Tweening.To(getter: () => light.shadowRadius,
                        setter: shadowRadius => light.shadowRadius = shadowRadius,
                        to, duration).SetTarget(light);

        public static Tween TweenShadowStrength(this Light light, float to, float duration) =>
            Tweening.To(getter: () => light.shadowStrength,
                        setter: shadowStrength => light.shadowStrength = shadowStrength,
                        to, duration).SetTarget(light);

        public static Tween TweenShadowBias(this Light light, float to, float duration) =>
            Tweening.To(getter: () => light.shadowBias,
                        setter: shadowBias => light.shadowBias = shadowBias,
                        to, duration).SetTarget(light);

        public static Tween TweenShadowNormalBias(this Light light, float to, float duration) =>
            Tweening.To(getter: () => light.shadowNormalBias,
                        setter: shadowNormalBias => light.shadowNormalBias = shadowNormalBias,
                        to, duration).SetTarget(light);

        public static Tween TweenShadowNearPlane(this Light light, float to, float duration) =>
            Tweening.To(getter: () => light.shadowNearPlane,
                        setter: shadowNearPlane => light.shadowNearPlane = shadowNearPlane,
                        to, duration).SetTarget(light);

        public static Tween TweenShadowAngle(this Light light, float to, float duration) =>
            Tweening.To(getter: () => light.shadowAngle,
                        setter: shadowAngle => light.shadowAngle = shadowAngle,
                        to, duration).SetTarget(light);

        public static Tween TweenSpotAngle(this Light light, float to, float duration) =>
            Tweening.To(getter: () => light.spotAngle,
                        setter: spotAngle => light.spotAngle = spotAngle,
                        to, duration).SetTarget(light);

        public static Tween TweenInnerSpotAngle(this Light light, float to, float duration) =>
            Tweening.To(getter: () => light.innerSpotAngle,
                        setter: innerSpotAngle => light.innerSpotAngle = innerSpotAngle,
                        to, duration).SetTarget(light);

        public static Tween TweenAreaSize(this Light light, Vector2 to, float duration) =>
            Tweening.To(getter: () => light.areaSize,
                        setter: areaSize => light.areaSize = areaSize,
                        to, duration).SetTarget(light);

        public static Tween TweenCookieSize(this Light light, float to, float duration) =>
            Tweening.To(getter: () => light.cookieSize,
                        setter: cookieSize => light.cookieSize = cookieSize,
                        to, duration).SetTarget(light);

        public static Tween TweenBoundingSphereOverride(this Light light, Vector4 to, float duration) =>
            Tweening.To(getter: () => light.boundingSphereOverride,
                        setter: boundingSphereOverride => light.boundingSphereOverride = boundingSphereOverride,
                        to, duration).SetTarget(light);

    }

}
