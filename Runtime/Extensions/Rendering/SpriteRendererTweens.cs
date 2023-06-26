using UnityEngine;

namespace Zigurous.Tweening
{
    public static class SpriteRendererTweens
    {
        public static Tween TweenColor(this SpriteRenderer renderer, Color to, float duration) =>
            Tweening.To(renderer, (source) => source.color, (source, value) => source.color = value, to, duration)
                    .SetTarget(renderer);

        public static Tween TweenAlpha(this SpriteRenderer renderer, float to, float duration) =>
            Tweening.To(renderer, (source) => source.color.a, (source, value) => source.color = new Color(source.color.r, source.color.g, source.color.b, value), to, duration)
                    .SetTarget(renderer);

        public static Tween TweenSize(this SpriteRenderer renderer, Vector2 to, float duration) =>
            Tweening.To(renderer, (source) => source.size, (source, value) => source.size = value, to, duration)
                    .SetTarget(renderer);

        public static Tween TweenAdaptiveModeThreshold(this SpriteRenderer renderer, float to, float duration) =>
            Tweening.To(renderer, (source) => source.adaptiveModeThreshold, (source, value) => source.adaptiveModeThreshold = value, to, duration)
                    .SetTarget(renderer);
    }

}
