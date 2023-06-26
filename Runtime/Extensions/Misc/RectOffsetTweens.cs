using UnityEngine;

namespace Zigurous.Tweening
{
    public static class RectOffsetTweens
    {
        public static Tween TweenLeft(this RectOffset offset, int to, float duration) =>
            Tweening.To(offset, (source) => source.left, (source, value) => source.left = value, to, duration)
                    .SetId(offset.GetHashCode());

        public static Tween TweenRight(this RectOffset offset, int to, float duration) =>
            Tweening.To(offset, (source) => source.right, (source, value) => source.right = value, to, duration)
                    .SetId(offset.GetHashCode());

        public static Tween TweenTop(this RectOffset offset, int to, float duration) =>
            Tweening.To(offset, (source) => source.top, (source, value) => source.top = value, to, duration)
                    .SetId(offset.GetHashCode());

        public static Tween TweenBottom(this RectOffset offset, int to, float duration) =>
            Tweening.To(offset, (source) => source.bottom, (source, value) => source.bottom = value, to, duration)
                    .SetId(offset.GetHashCode());
    }

}
