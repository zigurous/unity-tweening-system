using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class CanvasTweens
    {
        public static Tween TweenScaleFactor(this Canvas canvas, float to, float duration) =>
            Tweening.To(getter: () => canvas.scaleFactor,
                        setter: scaleFactor => canvas.scaleFactor = scaleFactor,
                        to, duration).SetTarget(canvas);

        public static Tween TweenPlaneDistance(this Canvas canvas, float to, float duration) =>
            Tweening.To(getter: () => canvas.planeDistance,
                        setter: planeDistance => canvas.planeDistance = planeDistance,
                        to, duration).SetTarget(canvas);

        public static Tween TweenReferencePixelsPerUnit(this Canvas canvas, float to, float duration) =>
            Tweening.To(getter: () => canvas.referencePixelsPerUnit,
                        setter: referencePixelsPerUnit => canvas.referencePixelsPerUnit = referencePixelsPerUnit,
                        to, duration).SetTarget(canvas);

        public static Tween TweenNormalizedSortingGridSize(this Canvas canvas, float to, float duration) =>
            Tweening.To(getter: () => canvas.normalizedSortingGridSize,
                        setter: normalizedSortingGridSize => canvas.normalizedSortingGridSize = normalizedSortingGridSize,
                        to, duration).SetTarget(canvas);

    }

}
