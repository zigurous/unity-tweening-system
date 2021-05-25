using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class DetailPrototypeTweens
    {
        public static Tween TweenMinWidth(this DetailPrototype detail, float to, float duration) =>
            Tweening.To(getter: () => detail.minWidth,
                        setter: minWidth => detail.minWidth = minWidth,
                        to, duration).SetTarget(detail);

        public static Tween TweenMaxWidth(this DetailPrototype detail, float to, float duration) =>
            Tweening.To(getter: () => detail.maxWidth,
                        setter: maxWidth => detail.maxWidth = maxWidth,
                        to, duration).SetTarget(detail);

        public static Tween TweenMinHeight(this DetailPrototype detail, float to, float duration) =>
            Tweening.To(getter: () => detail.minHeight,
                        setter: minHeight => detail.minHeight = minHeight,
                        to, duration).SetTarget(detail);

        public static Tween TweenMaxHeight(this DetailPrototype detail, float to, float duration) =>
            Tweening.To(getter: () => detail.maxHeight,
                        setter: maxHeight => detail.maxHeight = maxHeight,
                        to, duration).SetTarget(detail);

        public static Tween TweenNoiseSpread(this DetailPrototype detail, float to, float duration) =>
            Tweening.To(getter: () => detail.noiseSpread,
                        setter: noiseSpread => detail.noiseSpread = noiseSpread,
                        to, duration).SetTarget(detail);

        public static Tween TweenBendFactor(this DetailPrototype detail, float to, float duration) =>
            Tweening.To(getter: () => detail.bendFactor,
                        setter: bendFactor => detail.bendFactor = bendFactor,
                        to, duration).SetTarget(detail);

        public static Tween TweenHealthyColor(this DetailPrototype detail, Color to, float duration) =>
            Tweening.To(getter: () => detail.healthyColor,
                        setter: healthyColor => detail.healthyColor = healthyColor,
                        to, duration).SetTarget(detail);

        public static Tween TweenDryColor(this DetailPrototype detail, Color to, float duration) =>
            Tweening.To(getter: () => detail.dryColor,
                        setter: dryColor => detail.dryColor = dryColor,
                        to, duration).SetTarget(detail);

    }

}
