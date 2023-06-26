using UnityEngine;
using UnityEngine.UI;

namespace Zigurous.Tweening
{
    public static class CanvasScalerTweens
    {
        public static Tween TweenScaleFactor(this CanvasScaler scaler, float to, float duration) =>
            Tweening.To(scaler, (source) => source.scaleFactor, (source, value) => source.scaleFactor = value, to, duration)
                    .SetTarget(scaler);

        public static Tween TweenReferenceResolution(this CanvasScaler scaler, Vector2 to, float duration) =>
            Tweening.To(scaler, (source) => source.referenceResolution, (source, value) => source.referenceResolution = value, to, duration)
                    .SetTarget(scaler);

        public static Tween TweenMatchWidthOrHeight(this CanvasScaler scaler, float to, float duration) =>
            Tweening.To(scaler, (source) => source.matchWidthOrHeight, (source, value) => source.matchWidthOrHeight = value, to, duration)
                    .SetTarget(scaler);

        public static Tween TweenDefaultSpriteDPI(this CanvasScaler scaler, float to, float duration) =>
            Tweening.To(scaler, (source) => source.defaultSpriteDPI, (source, value) => source.defaultSpriteDPI = value, to, duration)
                    .SetTarget(scaler);

        public static Tween TweenFallbackScreenDPI(this CanvasScaler scaler, float to, float duration) =>
            Tweening.To(scaler, (source) => source.fallbackScreenDPI, (source, value) => source.fallbackScreenDPI = value, to, duration)
                    .SetTarget(scaler);

        public static Tween TweenDynamicPixelsPerUnit(this CanvasScaler scaler, float to, float duration) =>
            Tweening.To(scaler, (source) => source.dynamicPixelsPerUnit, (source, value) => source.dynamicPixelsPerUnit = value, to, duration)
                    .SetTarget(scaler);

        public static Tween TweenReferencePixelsPerUnit(this CanvasScaler scaler, float to, float duration) =>
            Tweening.To(scaler, (source) => source.referencePixelsPerUnit, (source, value) => source.referencePixelsPerUnit = value, to, duration)
                    .SetTarget(scaler);
    }

}
