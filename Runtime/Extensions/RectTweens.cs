using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class RectTweens
    {
        public static Tween TweenWidth(this Rect rect, float to, float duration) =>
            Tweening.To(getter: () => rect.width,
                        setter: width => rect.width = width,
                        to, duration).SetTarget(rect);

        public static Tween TweenHeight(this Rect rect, float to, float duration) =>
            Tweening.To(getter: () => rect.height,
                        setter: height => rect.height = height,
                        to, duration).SetTarget(rect);

        public static Tween TweenSize(this Rect rect, Vector2 to, float duration) =>
            Tweening.To(getter: () => rect.size,
                        setter: size => rect.size = size,
                        to, duration).SetTarget(rect);

        public static Tween TweenCenter(this Rect rect, Vector2 to, float duration) =>
            Tweening.To(getter: () => rect.center,
                        setter: center => rect.center = center,
                        to, duration).SetTarget(rect);

        public static Tween TweenPosition(this Rect rect, Vector2 to, float duration) =>
            Tweening.To(getter: () => rect.position,
                        setter: position => rect.position = position,
                        to, duration).SetTarget(rect);

        public static Tween TweenMin(this Rect rect, Vector2 to, float duration) =>
            Tweening.To(getter: () => rect.min,
                        setter: min => rect.min = min,
                        to, duration).SetTarget(rect);

        public static Tween TweenMax(this Rect rect, Vector2 to, float duration) =>
            Tweening.To(getter: () => rect.max,
                        setter: max => rect.max = max,
                        to, duration).SetTarget(rect);

        public static Tween TweenX(this Rect rect, int to, float duration) =>
            Tweening.To(getter: () => rect.x,
                        setter: x => rect.x = x,
                        to, duration).SetTarget(rect);

        public static Tween TweenXMin(this Rect rect, int to, float duration) =>
            Tweening.To(getter: () => rect.xMin,
                        setter: xMin => rect.xMin = xMin,
                        to, duration).SetTarget(rect);

        public static Tween TweenXMax(this Rect rect, int to, float duration) =>
            Tweening.To(getter: () => rect.xMax,
                        setter: xMax => rect.xMax = xMax,
                        to, duration).SetTarget(rect);

        public static Tween TweenY(this Rect rect, int to, float duration) =>
            Tweening.To(getter: () => rect.y,
                        setter: y => rect.y = y,
                        to, duration).SetTarget(rect);

        public static Tween TweenYMin(this Rect rect, int to, float duration) =>
            Tweening.To(getter: () => rect.yMin,
                        setter: yMin => rect.yMin = yMin,
                        to, duration).SetTarget(rect);

        public static Tween TweenYMax(this Rect rect, int to, float duration) =>
            Tweening.To(getter: () => rect.yMax,
                        setter: yMax => rect.yMax = yMax,
                        to, duration).SetTarget(rect);

    }

}
