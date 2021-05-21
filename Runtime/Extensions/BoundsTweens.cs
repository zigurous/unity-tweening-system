using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public static class BoundsTweens
    {
        public static Tween TweenExtents(this Bounds bounds, Vector3 to, float duration) =>
            Tweener.To(getter: () => bounds.extents,
                       setter: extents => bounds.extents = extents,
                       to, duration).SetId(bounds.GetHashCode());

        public static Tween TweenSize(this Bounds bounds, Vector3 to, float duration) =>
            Tweener.To(getter: () => bounds.size,
                       setter: size => bounds.size = size,
                       to, duration).SetId(bounds.GetHashCode());

        public static Tween TweenCenter(this Bounds bounds, Vector3 to, float duration) =>
            Tweener.To(getter: () => bounds.center,
                       setter: center => bounds.center = center,
                       to, duration).SetId(bounds.GetHashCode());

        public static Tween TweenMin(this Bounds bounds, Vector3 to, float duration) =>
            Tweener.To(getter: () => bounds.min,
                       setter: min => bounds.min = min,
                       to, duration).SetId(bounds.GetHashCode());

        public static Tween TweenMax(this Bounds bounds, Vector3 to, float duration) =>
            Tweener.To(getter: () => bounds.max,
                       setter: max => bounds.max = max,
                       to, duration).SetId(bounds.GetHashCode());

    }

}
