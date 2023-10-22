using UnityEngine;
using UnityEngine.UI;

namespace Zigurous.Tweening
{
    public static class ScrollRectTweens
    {
        public static Tween TweenElasticity(this ScrollRect scrollRect, float to, float duration) =>
            Tweening.To(scrollRect, (target) => target.elasticity, (target, value) => target.elasticity = value, to, duration)
                    .SetReference(scrollRect);

        public static Tween TweenDecelerationRate(this ScrollRect scrollRect, float to, float duration) =>
            Tweening.To(scrollRect, (target) => target.decelerationRate, (target, value) => target.decelerationRate = value, to, duration)
                    .SetReference(scrollRect);

        public static Tween TweenScrollSensitivity(this ScrollRect scrollRect, float to, float duration) =>
            Tweening.To(scrollRect, (target) => target.scrollSensitivity, (target, value) => target.scrollSensitivity = value, to, duration)
                    .SetReference(scrollRect);

        public static Tween TweenVelocity(this ScrollRect scrollRect, Vector2 to, float duration) =>
            Tweening.To(scrollRect, (target) => target.velocity, (target, value) => target.velocity = value, to, duration)
                    .SetReference(scrollRect);

        public static Tween TweenNormalizedPosition(this ScrollRect scrollRect, Vector2 to, float duration) =>
            Tweening.To(scrollRect, (target) => target.normalizedPosition, (target, value) => target.normalizedPosition = value, to, duration)
                    .SetReference(scrollRect);

        public static Tween TweenHorizontalNormalizedPosition(this ScrollRect scrollRect, float to, float duration) =>
            Tweening.To(scrollRect, (target) => target.horizontalNormalizedPosition, (target, value) => target.horizontalNormalizedPosition = value, to, duration)
                    .SetReference(scrollRect);

        public static Tween TweenVerticalNormalizedPosition(this ScrollRect scrollRect, float to, float duration) =>
            Tweening.To(scrollRect, (target) => target.verticalNormalizedPosition, (target, value) => target.verticalNormalizedPosition = value, to, duration)
                    .SetReference(scrollRect);

        public static Tween TweenHorizontalScrollbarSpacing(this ScrollRect scrollRect, float to, float duration) =>
            Tweening.To(scrollRect, (target) => target.horizontalScrollbarSpacing, (target, value) => target.horizontalScrollbarSpacing = value, to, duration)
                    .SetReference(scrollRect);

        public static Tween TweenVerticalScrollbarSpacing(this ScrollRect scrollRect, float to, float duration) =>
            Tweening.To(scrollRect, (target) => target.verticalScrollbarSpacing, (target, value) => target.verticalScrollbarSpacing = value, to, duration)
                    .SetReference(scrollRect);
    }

}
