using UnityEngine;
using UnityEngine.UI;

namespace Zigurous.Tweening
{
    public static class ScrollRectTweens
    {
        public static Tween TweenElasticity(this ScrollRect scrollRect, float to, float duration) =>
            Tweening.To(scrollRect, (source) => source.elasticity, (source, value) => source.elasticity = value, to, duration)
                    .SetTarget(scrollRect);

        public static Tween TweenDecelerationRate(this ScrollRect scrollRect, float to, float duration) =>
            Tweening.To(scrollRect, (source) => source.decelerationRate, (source, value) => source.decelerationRate = value, to, duration)
                    .SetTarget(scrollRect);

        public static Tween TweenScrollSensitivity(this ScrollRect scrollRect, float to, float duration) =>
            Tweening.To(scrollRect, (source) => source.scrollSensitivity, (source, value) => source.scrollSensitivity = value, to, duration)
                    .SetTarget(scrollRect);

        public static Tween TweenVelocity(this ScrollRect scrollRect, Vector2 to, float duration) =>
            Tweening.To(scrollRect, (source) => source.velocity, (source, value) => source.velocity = value, to, duration)
                    .SetTarget(scrollRect);

        public static Tween TweenNormalizedPosition(this ScrollRect scrollRect, Vector2 to, float duration) =>
            Tweening.To(scrollRect, (source) => source.normalizedPosition, (source, value) => source.normalizedPosition = value, to, duration)
                    .SetTarget(scrollRect);

        public static Tween TweenHorizontalNormalizedPosition(this ScrollRect scrollRect, float to, float duration) =>
            Tweening.To(scrollRect, (source) => source.horizontalNormalizedPosition, (source, value) => source.horizontalNormalizedPosition = value, to, duration)
                    .SetTarget(scrollRect);

        public static Tween TweenVerticalNormalizedPosition(this ScrollRect scrollRect, float to, float duration) =>
            Tweening.To(scrollRect, (source) => source.verticalNormalizedPosition, (source, value) => source.verticalNormalizedPosition = value, to, duration)
                    .SetTarget(scrollRect);

        public static Tween TweenHorizontalScrollbarSpacing(this ScrollRect scrollRect, float to, float duration) =>
            Tweening.To(scrollRect, (source) => source.horizontalScrollbarSpacing, (source, value) => source.horizontalScrollbarSpacing = value, to, duration)
                    .SetTarget(scrollRect);

        public static Tween TweenVerticalScrollbarSpacing(this ScrollRect scrollRect, float to, float duration) =>
            Tweening.To(scrollRect, (source) => source.verticalScrollbarSpacing, (source, value) => source.verticalScrollbarSpacing = value, to, duration)
                    .SetTarget(scrollRect);
    }

}
