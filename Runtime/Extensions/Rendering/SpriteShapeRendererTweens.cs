using UnityEngine;
using UnityEngine.U2D;

namespace Zigurous.TweenEngine
{
    public static class SpriteShapeRendererTweens
    {
        public static Tween TweenColor(this SpriteShapeRenderer renderer, Color to, float duration) =>
            Tweening.To(getter: () => renderer.color,
                        setter: color => renderer.color = color,
                        to, duration).SetTarget(renderer);

        public static Tween TweenAlpha(this SpriteShapeRenderer renderer, float to, float duration) =>
            Tweening.To(getter: () => renderer.color.a,
                        setter: alpha => renderer.color = new Color(renderer.color.r, renderer.color.g, renderer.color.b, alpha),
                        to, duration).SetTarget(renderer);

    }

}
