using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public static class SpriteRendererTweens
    {
        public static Tween TweenColor(this SpriteRenderer spriteRenderer, Color to, float duration)
        {
            Color from = spriteRenderer.color;
            return Tweener.To(
                getter: () => { from = spriteRenderer.color; return 0.0f; },
                setter: t => { spriteRenderer.color = Color.Lerp(from, to, t); },
                endValue: 1.0f, duration).SetTarget(spriteRenderer);
        }

        public static Tween TweenRed(this SpriteRenderer spriteRenderer, float to, float duration) =>
            Tweener.To(getter: () => spriteRenderer.color.r,
                       setter: red => spriteRenderer.color = new Color(red, spriteRenderer.color.g, spriteRenderer.color.b, spriteRenderer.color.a),
                       to, duration).SetTarget(spriteRenderer);

        public static Tween TweenGreen(this SpriteRenderer spriteRenderer, float to, float duration) =>
            Tweener.To(getter: () => spriteRenderer.color.g,
                       setter: green => spriteRenderer.color = new Color(spriteRenderer.color.r, green, spriteRenderer.color.b, spriteRenderer.color.a),
                       to, duration).SetTarget(spriteRenderer);

        public static Tween TweenBlue(this SpriteRenderer spriteRenderer, float to, float duration) =>
            Tweener.To(getter: () => spriteRenderer.color.b,
                       setter: blue => spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, blue, spriteRenderer.color.a),
                       to, duration).SetTarget(spriteRenderer);

        public static Tween TweenAlpha(this SpriteRenderer spriteRenderer, float to, float duration) =>
            Tweener.To(getter: () => spriteRenderer.color.a,
                       setter: alpha => spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, alpha),
                       to, duration).SetTarget(spriteRenderer);

    }

}
