using UnityEngine;

namespace Zigurous.Tweening
{
    public static class RectTransformTweens
    {
        public static Tween TweenAnchoredPosition(this RectTransform transform, Vector2 to, float duration) =>
            Tweening.To(transform, (source) => source.anchoredPosition, (source, value) => source.anchoredPosition = value, to, duration)
                    .SetTarget(transform);

        public static Tween TweenAnchoredPosition3D(this RectTransform transform, Vector3 to, float duration) =>
            Tweening.To(transform, (source) => source.anchoredPosition3D, (source, value) => source.anchoredPosition3D = value, to, duration)
                    .SetTarget(transform);

        public static Tween TweenAnchorMin(this RectTransform transform, Vector2 to, float duration) =>
            Tweening.To(transform, (source) => source.anchorMin, (source, value) => source.anchorMin = value, to, duration)
                    .SetTarget(transform);

        public static Tween TweenAnchorMax(this RectTransform transform, Vector2 to, float duration) =>
            Tweening.To(transform, (source) => source.anchorMax, (source, value) => source.anchorMax = value, to, duration)
                    .SetTarget(transform);

        public static Tween TweenOffsetMin(this RectTransform transform, Vector2 to, float duration) =>
            Tweening.To(transform, (source) => source.offsetMin, (source, value) => source.offsetMin = value, to, duration)
                    .SetTarget(transform);

        public static Tween TweenOffsetMax(this RectTransform transform, Vector2 to, float duration) =>
            Tweening.To(transform, (source) => source.offsetMax, (source, value) => source.offsetMax = value, to, duration)
                    .SetTarget(transform);

        public static Tween TweenPivot(this RectTransform transform, Vector2 to, float duration) =>
            Tweening.To(transform, (source) => source.pivot, (source, value) => source.pivot = value, to, duration)
                    .SetTarget(transform);

        public static Tween TweenSizeDelta(this RectTransform transform, Vector2 to, float duration) =>
            Tweening.To(transform, (source) => source.sizeDelta, (source, value) => source.sizeDelta = value, to, duration)
                    .SetTarget(transform);
    }

}
