using UnityEngine;

namespace Zigurous.Tweening
{
    public static class RectTransformTweens
    {
        public static Tween TweenAnchoredPosition(this RectTransform transform, Vector2 to, float duration) =>
            Tweening.To(transform, (target) => target.anchoredPosition, (target, value) => target.anchoredPosition = value, to, duration)
                    .SetReference(transform);

        public static Tween TweenAnchoredPosition3D(this RectTransform transform, Vector3 to, float duration) =>
            Tweening.To(transform, (target) => target.anchoredPosition3D, (target, value) => target.anchoredPosition3D = value, to, duration)
                    .SetReference(transform);

        public static Tween TweenAnchorMin(this RectTransform transform, Vector2 to, float duration) =>
            Tweening.To(transform, (target) => target.anchorMin, (target, value) => target.anchorMin = value, to, duration)
                    .SetReference(transform);

        public static Tween TweenAnchorMax(this RectTransform transform, Vector2 to, float duration) =>
            Tweening.To(transform, (target) => target.anchorMax, (target, value) => target.anchorMax = value, to, duration)
                    .SetReference(transform);

        public static Tween TweenOffsetMin(this RectTransform transform, Vector2 to, float duration) =>
            Tweening.To(transform, (target) => target.offsetMin, (target, value) => target.offsetMin = value, to, duration)
                    .SetReference(transform);

        public static Tween TweenOffsetMax(this RectTransform transform, Vector2 to, float duration) =>
            Tweening.To(transform, (target) => target.offsetMax, (target, value) => target.offsetMax = value, to, duration)
                    .SetReference(transform);

        public static Tween TweenPivot(this RectTransform transform, Vector2 to, float duration) =>
            Tweening.To(transform, (target) => target.pivot, (target, value) => target.pivot = value, to, duration)
                    .SetReference(transform);

        public static Tween TweenSizeDelta(this RectTransform transform, Vector2 to, float duration) =>
            Tweening.To(transform, (target) => target.sizeDelta, (target, value) => target.sizeDelta = value, to, duration)
                    .SetReference(transform);
    }

}
