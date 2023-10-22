using UnityEngine;
using UnityEngine.UI;

namespace Zigurous.Tweening
{
    public static class ShadowTweens
    {
        public static Tween TweenColor(this Shadow shadow, Color to, float duration) =>
            Tweening.To(shadow, (target) => target.effectColor, (target, value) => target.effectColor = value, to, duration)
                    .SetReference(shadow);

        public static Tween TweenAlpha(this Shadow shadow, float to, float duration) =>
            Tweening.To(shadow, (target) => target.effectColor.a, (target, value) => target.effectColor = new Color(target.effectColor.r, target.effectColor.g, target.effectColor.b, value), to, duration)
                    .SetReference(shadow);

        public static Tween TweenDistance(this Shadow shadow, Vector2 to, float duration) =>
            Tweening.To(shadow, (target) => target.effectDistance, (target, value) => target.effectDistance = value, to, duration)
                    .SetReference(shadow);
    }

}
