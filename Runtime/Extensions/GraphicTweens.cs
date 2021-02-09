using UnityEngine;
using UnityEngine.UI;

namespace Zigurous.Animation.Tweening
{
    public static class GraphicTweens
    {
        public static Tween TweenColor(this Graphic graphic, Color to, float duration)
        {
            Color from = graphic.color;
            return Tweener.To(
                getter: () => { from = graphic.color; return 0.0f; },
                setter: t => { graphic.color = Color.Lerp(from, to, t); },
                endValue: 1.0f, duration).SetTarget(graphic);
        }

        public static Tween TweenRed(this Graphic graphic, float to, float duration) =>
            Tweener.To(getter: () => graphic.color.r,
                       setter: red => graphic.color = new Color(red, graphic.color.g, graphic.color.b, graphic.color.a),
                       to, duration).SetTarget(graphic);

        public static Tween TweenGreen(this Graphic graphic, float to, float duration) =>
            Tweener.To(getter: () => graphic.color.g,
                       setter: green => graphic.color = new Color(graphic.color.r, green, graphic.color.b, graphic.color.a),
                       to, duration).SetTarget(graphic);

        public static Tween TweenBlue(this Graphic graphic, float to, float duration) =>
            Tweener.To(getter: () => graphic.color.b,
                       setter: blue => graphic.color = new Color(graphic.color.r, graphic.color.g, blue, graphic.color.a),
                       to, duration).SetTarget(graphic);

        public static Tween TweenAlpha(this Graphic graphic, float to, float duration) =>
            Tweener.To(getter: () => graphic.color.a,
                       setter: alpha => graphic.color = new Color(graphic.color.r, graphic.color.g, graphic.color.b, alpha),
                       to, duration).SetTarget(graphic);

    }

}
