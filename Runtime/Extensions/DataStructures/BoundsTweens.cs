using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class BoundsTweens
    {
        public static Tween TweenExtents(this Bounds bounds, Vector3 to, float duration) =>
            Tweening.To(getter: () => bounds.extents,
                        setter: extents => bounds.extents = extents,
                        to, duration).SetTarget(bounds);

        public static Tween TweenSize(this Bounds bounds, Vector3 to, float duration) =>
            Tweening.To(getter: () => bounds.size,
                        setter: size => bounds.size = size,
                        to, duration).SetTarget(bounds);

        public static Tween TweenCenter(this Bounds bounds, Vector3 to, float duration) =>
            Tweening.To(getter: () => bounds.center,
                        setter: center => bounds.center = center,
                        to, duration).SetTarget(bounds);

        public static Tween TweenMin(this Bounds bounds, Vector3 to, float duration) =>
            Tweening.To(getter: () => bounds.min,
                        setter: min => bounds.min = min,
                        to, duration).SetTarget(bounds);

        public static Tween TweenMax(this Bounds bounds, Vector3 to, float duration) =>
            Tweening.To(getter: () => bounds.max,
                        setter: max => bounds.max = max,
                        to, duration).SetTarget(bounds);

    }

}
