using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public static class ColorTweens
    {
        public static Tween TweenRed(this Color color, float to, float duration) =>
            Tweener.To(getter: () => color.r,
                       setter: red => color.r = red,
                       to, duration).SetId(color.GetHashCode());

        public static Tween TweenGreen(this Color color, float to, float duration) =>
            Tweener.To(getter: () => color.g,
                       setter: green => color.g = green,
                       to, duration).SetId(color.GetHashCode());

        public static Tween TweenBlue(this Color color, float to, float duration) =>
            Tweener.To(getter: () => color.b,
                       setter: blue => color.b = blue,
                       to, duration).SetId(color.GetHashCode());

        public static Tween TweenAlpha(this Color color, float to, float duration) =>
            Tweener.To(getter: () => color.a,
                       setter: alpha => color.a = alpha,
                       to, duration).SetId(color.GetHashCode());

    }

}
