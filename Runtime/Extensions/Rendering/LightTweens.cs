using UnityEngine;

namespace Zigurous.Tweening
{
    public static class LightTweens
    {
        public static Tween TweenColor(this Light light, Color to, float duration) =>
            Tweening.To(light, (target) => target.color, (target, value) => target.color = value, to, duration)
                    .SetReference(light);

        public static Tween TweenColorTemperature(this Light light, float to, float duration) =>
            Tweening.To(light, (target) => target.colorTemperature, (target, value) => target.colorTemperature = value, to, duration)
                    .SetReference(light);

        public static Tween TweenIntensity(this Light light, float to, float duration) =>
            Tweening.To(light, (target) => target.intensity, (target, value) => target.intensity = value, to, duration)
                    .SetReference(light);

        public static Tween TweenBounceIntensity(this Light light, float to, float duration) =>
            Tweening.To(light, (target) => target.bounceIntensity, (target, value) => target.bounceIntensity = value, to, duration)
                    .SetReference(light);

        public static Tween TweenRange(this Light light, float to, float duration) =>
            Tweening.To(light, (target) => target.range, (target, value) => target.range = value, to, duration)
                    .SetReference(light);

        public static Tween TweenShadowStrength(this Light light, float to, float duration) =>
            Tweening.To(light, (target) => target.shadowStrength, (target, value) => target.shadowStrength = value, to, duration)
                    .SetReference(light);

        public static Tween TweenShadowBias(this Light light, float to, float duration) =>
            Tweening.To(light, (target) => target.shadowBias, (target, value) => target.shadowBias = value, to, duration)
                    .SetReference(light);

        public static Tween TweenShadowNormalBias(this Light light, float to, float duration) =>
            Tweening.To(light, (target) => target.shadowNormalBias, (target, value) => target.shadowNormalBias = value, to, duration)
                    .SetReference(light);

        public static Tween TweenShadowNearPlane(this Light light, float to, float duration) =>
            Tweening.To(light, (target) => target.shadowNearPlane, (target, value) => target.shadowNearPlane = value, to, duration)
                    .SetReference(light);

        public static Tween TweenSpotAngle(this Light light, float to, float duration) =>
            Tweening.To(light, (target) => target.spotAngle, (target, value) => target.spotAngle = value, to, duration)
                    .SetReference(light);

        public static Tween TweenInnerSpotAngle(this Light light, float to, float duration) =>
            Tweening.To(light, (target) => target.innerSpotAngle, (target, value) => target.innerSpotAngle = value, to, duration)
                    .SetReference(light);

        public static Tween TweenCookieSize(this Light light, float to, float duration) =>
            Tweening.To(light, (target) => target.cookieSize, (target, value) => target.cookieSize = value, to, duration)
                    .SetReference(light);

        public static Tween TweenBoundingSphereOverride(this Light light, Vector4 to, float duration) =>
            Tweening.To(light, (target) => target.boundingSphereOverride, (target, value) => target.boundingSphereOverride = value, to, duration)
                    .SetReference(light);
    }

}
