using UnityEngine;
using UnityEngine.UI;

namespace Zigurous.Animation.Tweening
{
    public static class GraphicTweens
    {
        public static Tween TweenColor(this Graphic graphic, Color to, float duration) =>
            Tweener.To(getter: () => graphic.color,
                       setter: color => graphic.color = color,
                       to, duration).SetTarget(graphic);

        public static Tween TweenAlpha(this Graphic graphic, float to, float duration) =>
            Tweener.To(getter: () => graphic.color.a,
                       setter: alpha => graphic.color = new Color(graphic.color.r, graphic.color.g, graphic.color.b, alpha),
                       to, duration).SetTarget(graphic);

    }

}
