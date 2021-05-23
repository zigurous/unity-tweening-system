using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class SpriteRendererTweens
    {
        public static Tween TweenColor(this SpriteRenderer renderer, Color to, float duration) =>
            Tweening.To(getter: () => renderer.color,
                        setter: color => renderer.color = color,
                        to, duration).SetTarget(renderer);

        public static Tween TweenAlpha(this SpriteRenderer renderer, float to, float duration) =>
            Tweening.To(getter: () => renderer.color.a,
                        setter: alpha => renderer.color = new Color(renderer.color.r, renderer.color.g, renderer.color.b, alpha),
                        to, duration).SetTarget(renderer);

        public static Tween TweenSize(this SpriteRenderer renderer, Vector2 to, float duration) =>
            Tweening.To(getter: () => renderer.size,
                        setter: size => renderer.size = size,
                        to, duration).SetTarget(renderer);

        public static Tween TweenAdaptiveModeThreshold(this SpriteRenderer renderer, float to, float duration) =>
            Tweening.To(getter: () => renderer.adaptiveModeThreshold,
                        setter: adaptiveModeThreshold => renderer.adaptiveModeThreshold = adaptiveModeThreshold,
                        to, duration).SetTarget(renderer);

    }

}
