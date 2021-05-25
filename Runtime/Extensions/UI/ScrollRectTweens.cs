using UnityEngine;
using UnityEngine.UI;

namespace Zigurous.Tweening
{
    public static class ScrollRectTweens
    {
        public static Tween TweenElasticity(this ScrollRect scrollRect, float to, float duration) =>
            Tweening.To(getter: () => scrollRect.elasticity,
                        setter: elasticity => scrollRect.elasticity = elasticity,
                        to, duration).SetTarget(scrollRect);

        public static Tween TweenDecelerationRate(this ScrollRect scrollRect, float to, float duration) =>
            Tweening.To(getter: () => scrollRect.decelerationRate,
                        setter: decelerationRate => scrollRect.decelerationRate = decelerationRate,
                        to, duration).SetTarget(scrollRect);

        public static Tween TweenScrollSensitivity(this ScrollRect scrollRect, float to, float duration) =>
            Tweening.To(getter: () => scrollRect.scrollSensitivity,
                        setter: scrollSensitivity => scrollRect.scrollSensitivity = scrollSensitivity,
                        to, duration).SetTarget(scrollRect);

        public static Tween TweenVelocity(this ScrollRect scrollRect, Vector2 to, float duration) =>
            Tweening.To(getter: () => scrollRect.velocity,
                        setter: velocity => scrollRect.velocity = velocity,
                        to, duration).SetTarget(scrollRect);

        public static Tween TweenNormalizedPosition(this ScrollRect scrollRect, Vector2 to, float duration) =>
            Tweening.To(getter: () => scrollRect.normalizedPosition,
                        setter: normalizedPosition => scrollRect.normalizedPosition = normalizedPosition,
                        to, duration).SetTarget(scrollRect);

        public static Tween TweenHorizontalNormalizedPosition(this ScrollRect scrollRect, float to, float duration) =>
            Tweening.To(getter: () => scrollRect.horizontalNormalizedPosition,
                        setter: position => scrollRect.horizontalNormalizedPosition = position,
                        to, duration).SetTarget(scrollRect);

        public static Tween TweenVerticalNormalizedPosition(this ScrollRect scrollRect, float to, float duration) =>
            Tweening.To(getter: () => scrollRect.verticalNormalizedPosition,
                        setter: position => scrollRect.verticalNormalizedPosition = position,
                        to, duration).SetTarget(scrollRect);

        public static Tween TweenHorizontalScrollbarSpacing(this ScrollRect scrollRect, float to, float duration) =>
            Tweening.To(getter: () => scrollRect.horizontalScrollbarSpacing,
                        setter: spacing => scrollRect.horizontalScrollbarSpacing = spacing,
                        to, duration).SetTarget(scrollRect);

        public static Tween TweenVerticalScrollbarSpacing(this ScrollRect scrollRect, float to, float duration) =>
            Tweening.To(getter: () => scrollRect.verticalScrollbarSpacing,
                        setter: spacing => scrollRect.verticalScrollbarSpacing = spacing,
                        to, duration).SetTarget(scrollRect);

    }

}
