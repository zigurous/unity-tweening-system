using UnityEngine;
using UnityEngine.U2D;

namespace Zigurous.Tweening
{
    public static class SpriteShapeRendererTweens
    {
        public static Tween TweenColor(this SpriteShapeRenderer renderer, Color to, float duration) =>
            Tweening.To(renderer, (target) => target.color, (target, value) => target.color = value, to, duration)
                    .SetReference(renderer);

        public static Tween TweenAlpha(this SpriteShapeRenderer renderer, float to, float duration) =>
            Tweening.To(renderer, (target) => target.color.a, (target, value) => target.color = new Color(target.color.r, target.color.g, target.color.b, value), to, duration)
                    .SetReference(renderer);
    }

}
