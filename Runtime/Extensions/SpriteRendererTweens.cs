using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class SpriteRendererTweens
    {
        public static Tween TweenColor(this SpriteRenderer spriteRenderer, Color to, float duration) =>
            Tweening.To(getter: () => spriteRenderer.color,
                        setter: color => spriteRenderer.color = color,
                        to, duration).SetTarget(spriteRenderer);

        public static Tween TweenAlpha(this SpriteRenderer spriteRenderer, float to, float duration) =>
            Tweening.To(getter: () => spriteRenderer.color.a,
                        setter: alpha => spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, alpha),
                        to, duration).SetTarget(spriteRenderer);

        public static Tween TweenSize(this SpriteRenderer spriteRenderer, Vector2 to, float duration) =>
            Tweening.To(getter: () => spriteRenderer.size,
                        setter: size => spriteRenderer.size = size,
                        to, duration).SetTarget(spriteRenderer);

        public static Tween TweenAdaptiveModeThreshold(this SpriteRenderer spriteRenderer, float to, float duration) =>
            Tweening.To(getter: () => spriteRenderer.adaptiveModeThreshold,
                        setter: adaptiveModeThreshold => spriteRenderer.adaptiveModeThreshold = adaptiveModeThreshold,
                        to, duration).SetTarget(spriteRenderer);

    }

}
