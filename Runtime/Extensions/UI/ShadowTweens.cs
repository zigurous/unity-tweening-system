using UnityEngine;
using UnityEngine.UI;

namespace Zigurous.Tweening
{
    public static class ShadowTweens
    {
        public static Tween TweenColor(this Shadow shadow, Color to, float duration) =>
            Tweening.To(shadow, (source) => source.effectColor, (source, value) => source.effectColor = value, to, duration)
                    .SetTarget(shadow);

        public static Tween TweenAlpha(this Shadow shadow, float to, float duration) =>
            Tweening.To(shadow, (source) => source.effectColor.a, (source, value) => source.effectColor = new Color(source.effectColor.r, source.effectColor.g, source.effectColor.b, value), to, duration)
                    .SetTarget(shadow);

        public static Tween TweenDistance(this Shadow shadow, Vector2 to, float duration) =>
            Tweening.To(shadow, (source) => source.effectDistance, (source, value) => source.effectDistance = value, to, duration)
                    .SetTarget(shadow);
    }

}
