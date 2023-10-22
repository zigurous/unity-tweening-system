using UnityEngine;
using UnityEngine.UI;

namespace Zigurous.Tweening
{
    public static class GraphicTweens
    {
        public static Tween TweenColor(this Graphic graphic, Color to, float duration) =>
            Tweening.To(graphic, (target) => target.color, (target, value) => target.color = value, to, duration)
                    .SetReference(graphic);

        public static Tween TweenAlpha(this Graphic graphic, float to, float duration) =>
            Tweening.To(graphic, (target) => target.color.a, (target, value) => target.color = new Color(target.color.r, target.color.g, target.color.b, value), to, duration)
                    .SetReference(graphic);
    }

}
