using UnityEngine;
using UnityEngine.UI;

namespace Zigurous.Tweening
{
    public static class ShadowTweens
    {
        public static Tween TweenColor(this Shadow shadow, Color to, float duration) =>
            Tweening.To(getter: () => shadow.effectColor,
                        setter: effectColor => shadow.effectColor = effectColor,
                        to, duration).SetTarget(shadow);

        public static Tween TweenAlpha(this Shadow shadow, float to, float duration) =>
            Tweening.To(getter: () => shadow.effectColor.a,
                        setter: alpha => shadow.effectColor = new Color(shadow.effectColor.r, shadow.effectColor.g, shadow.effectColor.b, alpha),
                        to, duration).SetTarget(shadow);

        public static Tween TweenDistance(this Shadow shadow, Vector2 to, float duration) =>
            Tweening.To(getter: () => shadow.effectDistance,
                        setter: effectDistance => shadow.effectDistance = effectDistance,
                        to, duration).SetTarget(shadow);

    }

}
