using UnityEngine;
using UnityEngine.UI;

namespace Zigurous.Tweening
{
    public static class GraphicTweens
    {
        public static Tween TweenColor(this Graphic graphic, Color to, float duration) =>
            Tweening.To(graphic, (source) => source.color, (source, value) => source.color = value, to, duration)
                    .SetTarget(graphic);

        public static Tween TweenAlpha(this Graphic graphic, float to, float duration) =>
            Tweening.To(graphic, (source) => source.color.a, (source, value) => source.color = new Color(source.color.r, source.color.g, source.color.b, value), to, duration)
                    .SetTarget(graphic);
    }

}
