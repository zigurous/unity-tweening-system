using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class BoundsIntTweens
     {
         public static Tween TweenSize(this BoundsInt bounds, Vector3Int to, float duration) =>
            Tweening.To(getter: () => bounds.size,
                        setter: size => bounds.size = size,
                        to, duration).SetTarget(bounds);

        public static Tween TweenPosition(this BoundsInt bounds, Vector3Int to, float duration) =>
            Tweening.To(getter: () => bounds.position,
                        setter: position => bounds.position = position,
                        to, duration).SetTarget(bounds);

        public static Tween TweenMin(this BoundsInt bounds, Vector3Int to, float duration) =>
            Tweening.To(getter: () => bounds.min,
                        setter: min => bounds.min = min,
                        to, duration).SetTarget(bounds);

        public static Tween TweenMax(this BoundsInt bounds, Vector3Int to, float duration) =>
            Tweening.To(getter: () => bounds.max,
                        setter: max => bounds.max = max,
                        to, duration).SetTarget(bounds);

        public static Tween TweenX(this BoundsInt bounds, int to, float duration) =>
            Tweening.To(getter: () => bounds.x,
                        setter: x => bounds.x = x,
                        to, duration).SetTarget(bounds);

        public static Tween TweenXMin(this BoundsInt bounds, int to, float duration) =>
            Tweening.To(getter: () => bounds.xMin,
                        setter: xMin => bounds.xMin = xMin,
                        to, duration).SetTarget(bounds);

        public static Tween TweenXMax(this BoundsInt bounds, int to, float duration) =>
            Tweening.To(getter: () => bounds.xMax,
                        setter: xMax => bounds.xMax = xMax,
                        to, duration).SetTarget(bounds);

        public static Tween TweenY(this BoundsInt bounds, int to, float duration) =>
            Tweening.To(getter: () => bounds.y,
                        setter: y => bounds.y = y,
                        to, duration).SetTarget(bounds);

        public static Tween TweenYMin(this BoundsInt bounds, int to, float duration) =>
            Tweening.To(getter: () => bounds.yMin,
                        setter: yMin => bounds.yMin = yMin,
                        to, duration).SetTarget(bounds);

        public static Tween TweenYMax(this BoundsInt bounds, int to, float duration) =>
            Tweening.To(getter: () => bounds.yMax,
                        setter: yMax => bounds.yMax = yMax,
                        to, duration).SetTarget(bounds);

        public static Tween TweenZ(this BoundsInt bounds, int to, float duration) =>
            Tweening.To(getter: () => bounds.z,
                        setter: z => bounds.z = z,
                        to, duration).SetTarget(bounds);

        public static Tween TweenZMin(this BoundsInt bounds, int to, float duration) =>
            Tweening.To(getter: () => bounds.zMin,
                        setter: zMin => bounds.zMin = zMin,
                        to, duration).SetTarget(bounds);

        public static Tween TweenZMax(this BoundsInt bounds, int to, float duration) =>
            Tweening.To(getter: () => bounds.zMax,
                        setter: zMax => bounds.zMax = zMax,
                        to, duration).SetTarget(bounds);

    }

}
