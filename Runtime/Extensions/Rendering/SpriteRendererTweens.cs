using UnityEngine;

namespace Zigurous.Tweening
{
    public static class SpriteRendererTweens
    {
        public static Tween TweenColor(this SpriteRenderer renderer, Color to, float duration) =>
            Tweening.To(renderer, (target) => target.color, (target, value) => target.color = value, to, duration)
                    .SetReference(renderer);

        public static Tween TweenAlpha(this SpriteRenderer renderer, float to, float duration) =>
            Tweening.To(renderer, (target) => target.color.a, (target, value) => target.color = new Color(target.color.r, target.color.g, target.color.b, value), to, duration)
                    .SetReference(renderer);

        public static Tween TweenSize(this SpriteRenderer renderer, Vector2 to, float duration) =>
            Tweening.To(renderer, (target) => target.size, (target, value) => target.size = value, to, duration)
                    .SetReference(renderer);

        public static Tween TweenAdaptiveModeThreshold(this SpriteRenderer renderer, float to, float duration) =>
            Tweening.To(renderer, (target) => target.adaptiveModeThreshold, (target, value) => target.adaptiveModeThreshold = value, to, duration)
                    .SetReference(renderer);
    }

}
