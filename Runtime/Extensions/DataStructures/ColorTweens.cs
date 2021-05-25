using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class ColorTweens
    {
        public static Tween TweenRed(this Color color, float to, float duration) =>
            Tweening.To(getter: () => color.r,
                        setter: red => color.r = red,
                        to, duration).SetTarget(color);

        public static Tween TweenGreen(this Color color, float to, float duration) =>
            Tweening.To(getter: () => color.g,
                        setter: green => color.g = green,
                        to, duration).SetTarget(color);

        public static Tween TweenBlue(this Color color, float to, float duration) =>
            Tweening.To(getter: () => color.b,
                        setter: blue => color.b = blue,
                        to, duration).SetTarget(color);

        public static Tween TweenAlpha(this Color color, float to, float duration) =>
            Tweening.To(getter: () => color.a,
                        setter: alpha => color.a = alpha,
                        to, duration).SetTarget(color);

    }

}
