using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class RectOffsetTweens
    {
        public static Tween TweenLeft(this RectOffset offset, int to, float duration) =>
            Tweening.To(getter: () => offset.left,
                        setter: left => offset.left = left,
                        to, duration).SetTarget(offset);

        public static Tween TweenRight(this RectOffset offset, int to, float duration) =>
            Tweening.To(getter: () => offset.right,
                        setter: right => offset.right = right,
                        to, duration).SetTarget(offset);

        public static Tween TweenTop(this RectOffset offset, int to, float duration) =>
            Tweening.To(getter: () => offset.top,
                        setter: top => offset.top = top,
                        to, duration).SetTarget(offset);

        public static Tween TweenBottom(this RectOffset offset, int to, float duration) =>
            Tweening.To(getter: () => offset.bottom,
                        setter: bottom => offset.bottom = bottom,
                        to, duration).SetTarget(offset);

    }

}
