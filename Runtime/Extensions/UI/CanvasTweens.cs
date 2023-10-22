using UnityEngine;

namespace Zigurous.Tweening
{
    public static class CanvasTweens
    {
        public static Tween TweenScaleFactor(this Canvas canvas, float to, float duration) =>
            Tweening.To(canvas, (target) => target.scaleFactor, (target, value) => target.scaleFactor = value, to, duration)
                    .SetReference(canvas);

        public static Tween TweenPlaneDistance(this Canvas canvas, float to, float duration) =>
            Tweening.To(canvas, (target) => target.planeDistance, (target, value) => target.planeDistance = value, to, duration)
                    .SetReference(canvas);

        public static Tween TweenReferencePixelsPerUnit(this Canvas canvas, float to, float duration) =>
            Tweening.To(canvas, (target) => target.referencePixelsPerUnit, (target, value) => target.referencePixelsPerUnit = value, to, duration)
                    .SetReference(canvas);

        public static Tween TweenNormalizedSortingGridSize(this Canvas canvas, float to, float duration) =>
            Tweening.To(canvas, (target) => target.normalizedSortingGridSize, (target, value) => target.normalizedSortingGridSize = value, to, duration)
                    .SetReference(canvas);
    }

}
