using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public static class LightTweens
    {
        public static Tween TweenColor(this Light light, Color to, float duration)
        {
            Color from = light.color;
            return Tweener.To(
                getter: () => { from = light.color; return 0.0f; },
                setter: t => { light.color = Color.Lerp(from, to, t); },
                endValue: 1.0f, duration).SetTarget(light);
        }

        public static Tween TweenIntensity(this Light light, float to, float duration) =>
            Tweener.To(getter: () => light.intensity,
                       setter: intensity => light.intensity = intensity,
                       to, duration).SetTarget(light);

        public static Tween TweenShadowStrength(this Light light, float to, float duration) =>
            Tweener.To(getter: () => light.shadowStrength,
                       setter: strength => light.shadowStrength = strength,
                       to, duration).SetTarget(light);

    }

}
