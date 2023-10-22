using UnityEngine;
using UnityEngine.UI;

namespace Zigurous.Tweening
{
    public static class CanvasScalerTweens
    {
        public static Tween TweenScaleFactor(this CanvasScaler scaler, float to, float duration) =>
            Tweening.To(scaler, (target) => target.scaleFactor, (target, value) => target.scaleFactor = value, to, duration)
                    .SetReference(scaler);

        public static Tween TweenReferenceResolution(this CanvasScaler scaler, Vector2 to, float duration) =>
            Tweening.To(scaler, (target) => target.referenceResolution, (target, value) => target.referenceResolution = value, to, duration)
                    .SetReference(scaler);

        public static Tween TweenMatchWidthOrHeight(this CanvasScaler scaler, float to, float duration) =>
            Tweening.To(scaler, (target) => target.matchWidthOrHeight, (target, value) => target.matchWidthOrHeight = value, to, duration)
                    .SetReference(scaler);

        public static Tween TweenDefaultSpriteDPI(this CanvasScaler scaler, float to, float duration) =>
            Tweening.To(scaler, (target) => target.defaultSpriteDPI, (target, value) => target.defaultSpriteDPI = value, to, duration)
                    .SetReference(scaler);

        public static Tween TweenFallbackScreenDPI(this CanvasScaler scaler, float to, float duration) =>
            Tweening.To(scaler, (target) => target.fallbackScreenDPI, (target, value) => target.fallbackScreenDPI = value, to, duration)
                    .SetReference(scaler);

        public static Tween TweenDynamicPixelsPerUnit(this CanvasScaler scaler, float to, float duration) =>
            Tweening.To(scaler, (target) => target.dynamicPixelsPerUnit, (target, value) => target.dynamicPixelsPerUnit = value, to, duration)
                    .SetReference(scaler);

        public static Tween TweenReferencePixelsPerUnit(this CanvasScaler scaler, float to, float duration) =>
            Tweening.To(scaler, (target) => target.referencePixelsPerUnit, (target, value) => target.referencePixelsPerUnit = value, to, duration)
                    .SetReference(scaler);
    }

}
