using UnityEngine;
using UnityEngine.UI;

namespace Zigurous.TweenEngine
{
    public static class CanvasScalerTweens
    {
        public static Tween TweenScaleFactor(this CanvasScaler scaler, float to, float duration) =>
            Tweening.To(getter: () => scaler.scaleFactor,
                        setter: scaleFactor => scaler.scaleFactor = scaleFactor,
                        to, duration).SetTarget(scaler);

        public static Tween TweenReferenceResolution(this CanvasScaler scaler, Vector2 to, float duration) =>
            Tweening.To(getter: () => scaler.referenceResolution,
                        setter: referenceResolution => scaler.referenceResolution = referenceResolution,
                        to, duration).SetTarget(scaler);

        public static Tween TweenMatchWidthOrHeight(this CanvasScaler scaler, float to, float duration) =>
            Tweening.To(getter: () => scaler.matchWidthOrHeight,
                        setter: matchWidthOrHeight => scaler.matchWidthOrHeight = matchWidthOrHeight,
                        to, duration).SetTarget(scaler);

        public static Tween TweenDefaultSpriteDPI(this CanvasScaler scaler, float to, float duration) =>
            Tweening.To(getter: () => scaler.defaultSpriteDPI,
                        setter: defaultSpriteDPI => scaler.defaultSpriteDPI = defaultSpriteDPI,
                        to, duration).SetTarget(scaler);

        public static Tween TweenFallbackScreenDPI(this CanvasScaler scaler, float to, float duration) =>
            Tweening.To(getter: () => scaler.fallbackScreenDPI,
                        setter: fallbackScreenDPI => scaler.fallbackScreenDPI = fallbackScreenDPI,
                        to, duration).SetTarget(scaler);

        public static Tween TweenDynamicPixelsPerUnit(this CanvasScaler scaler, float to, float duration) =>
            Tweening.To(getter: () => scaler.dynamicPixelsPerUnit,
                        setter: dynamicPixelsPerUnit => scaler.dynamicPixelsPerUnit = dynamicPixelsPerUnit,
                        to, duration).SetTarget(scaler);

        public static Tween TweenReferencePixelsPerUnit(this CanvasScaler scaler, float to, float duration) =>
            Tweening.To(getter: () => scaler.referencePixelsPerUnit,
                        setter: referencePixelsPerUnit => scaler.referencePixelsPerUnit = referencePixelsPerUnit,
                        to, duration).SetTarget(scaler);

    }

}
