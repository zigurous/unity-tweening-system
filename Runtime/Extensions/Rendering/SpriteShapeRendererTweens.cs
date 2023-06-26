using UnityEngine;
using UnityEngine.U2D;

namespace Zigurous.Tweening
{
    public static class SpriteShapeRendererTweens
    {
        public static Tween TweenColor(this SpriteShapeRenderer renderer, Color to, float duration) =>
            Tweening.To(renderer, (source) => source.color, (source, value) => source.color = value, to, duration)
                    .SetTarget(renderer);

        public static Tween TweenAlpha(this SpriteShapeRenderer renderer, float to, float duration) =>
            Tweening.To(renderer, (source) => source.color.a, (source, value) => source.color = new Color(source.color.r, source.color.g, source.color.b, value), to, duration)
                    .SetTarget(renderer);
    }

}
