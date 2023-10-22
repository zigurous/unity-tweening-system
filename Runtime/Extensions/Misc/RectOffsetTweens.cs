using UnityEngine;

namespace Zigurous.Tweening
{
    public static class RectOffsetTweens
    {
        public static Tween TweenLeft(this RectOffset offset, int to, float duration) =>
            Tweening.To(offset, (target) => target.left, (target, value) => target.left = value, to, duration)
                    .SetId(offset.GetHashCode());

        public static Tween TweenRight(this RectOffset offset, int to, float duration) =>
            Tweening.To(offset, (target) => target.right, (target, value) => target.right = value, to, duration)
                    .SetId(offset.GetHashCode());

        public static Tween TweenTop(this RectOffset offset, int to, float duration) =>
            Tweening.To(offset, (target) => target.top, (target, value) => target.top = value, to, duration)
                    .SetId(offset.GetHashCode());

        public static Tween TweenBottom(this RectOffset offset, int to, float duration) =>
            Tweening.To(offset, (target) => target.bottom, (target, value) => target.bottom = value, to, duration)
                    .SetId(offset.GetHashCode());
    }

}
