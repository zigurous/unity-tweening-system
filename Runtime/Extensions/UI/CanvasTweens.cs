using UnityEngine;

namespace Zigurous.Tweening
{
    public static class CanvasTweens
    {
        public static Tween TweenScaleFactor(this Canvas canvas, float to, float duration) =>
            Tweening.To(canvas, (source) => source.scaleFactor, (source, value) => source.scaleFactor = value, to, duration)
                    .SetTarget(canvas);

        public static Tween TweenPlaneDistance(this Canvas canvas, float to, float duration) =>
            Tweening.To(canvas, (source) => source.planeDistance, (source, value) => source.planeDistance = value, to, duration)
                    .SetTarget(canvas);

        public static Tween TweenReferencePixelsPerUnit(this Canvas canvas, float to, float duration) =>
            Tweening.To(canvas, (source) => source.referencePixelsPerUnit, (source, value) => source.referencePixelsPerUnit = value, to, duration)
                    .SetTarget(canvas);

        public static Tween TweenNormalizedSortingGridSize(this Canvas canvas, float to, float duration) =>
            Tweening.To(canvas, (source) => source.normalizedSortingGridSize, (source, value) => source.normalizedSortingGridSize = value, to, duration)
                    .SetTarget(canvas);
    }

}
