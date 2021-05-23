using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class DetailPrototypeTweens
    {
        public static Tween TweenMinWidth(this DetailPrototype prototype, float to, float duration) =>
            Tweening.To(getter: () => prototype.minWidth,
                        setter: minWidth => prototype.minWidth = minWidth,
                        to, duration).SetTarget(prototype);

        public static Tween TweenMaxWidth(this DetailPrototype prototype, float to, float duration) =>
            Tweening.To(getter: () => prototype.maxWidth,
                        setter: maxWidth => prototype.maxWidth = maxWidth,
                        to, duration).SetTarget(prototype);

        public static Tween TweenMinHeight(this DetailPrototype prototype, float to, float duration) =>
            Tweening.To(getter: () => prototype.minHeight,
                        setter: minHeight => prototype.minHeight = minHeight,
                        to, duration).SetTarget(prototype);

        public static Tween TweenMaxHeight(this DetailPrototype prototype, float to, float duration) =>
            Tweening.To(getter: () => prototype.maxHeight,
                        setter: maxHeight => prototype.maxHeight = maxHeight,
                        to, duration).SetTarget(prototype);

        public static Tween TweenNoiseSpread(this DetailPrototype prototype, float to, float duration) =>
            Tweening.To(getter: () => prototype.noiseSpread,
                        setter: noiseSpread => prototype.noiseSpread = noiseSpread,
                        to, duration).SetTarget(prototype);

        public static Tween TweenBendFactor(this DetailPrototype prototype, float to, float duration) =>
            Tweening.To(getter: () => prototype.bendFactor,
                        setter: bendFactor => prototype.bendFactor = bendFactor,
                        to, duration).SetTarget(prototype);

        public static Tween TweenHealthyColor(this DetailPrototype prototype, Color to, float duration) =>
            Tweening.To(getter: () => prototype.healthyColor,
                        setter: healthyColor => prototype.healthyColor = healthyColor,
                        to, duration).SetTarget(prototype);

        public static Tween TweenDryColor(this DetailPrototype prototype, Color to, float duration) =>
            Tweening.To(getter: () => prototype.dryColor,
                        setter: dryColor => prototype.dryColor = dryColor,
                        to, duration).SetTarget(prototype);

    }

}
