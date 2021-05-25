using UnityEngine;

namespace Zigurous.Tweening
{
    public static class RectTransformTweens
    {
        public static Tween TweenAnchoredPosition(this RectTransform transform, Vector2 to, float duration) =>
            Tweening.To(getter: () => transform.anchoredPosition,
                        setter: anchoredPosition => transform.anchoredPosition = anchoredPosition,
                        to, duration).SetTarget(transform);

        public static Tween TweenAnchoredPosition3D(this RectTransform transform, Vector3 to, float duration) =>
            Tweening.To(getter: () => transform.anchoredPosition3D,
                        setter: anchoredPosition3D => transform.anchoredPosition3D = anchoredPosition3D,
                        to, duration).SetTarget(transform);

        public static Tween TweenAnchorMin(this RectTransform transform, Vector2 to, float duration) =>
            Tweening.To(getter: () => transform.anchorMin,
                        setter: anchorMin => transform.anchorMin = anchorMin,
                        to, duration).SetTarget(transform);

        public static Tween TweenAnchorMax(this RectTransform transform, Vector2 to, float duration) =>
            Tweening.To(getter: () => transform.anchorMax,
                        setter: anchorMax => transform.anchorMax = anchorMax,
                        to, duration).SetTarget(transform);

        public static Tween TweenOffsetMin(this RectTransform transform, Vector2 to, float duration) =>
            Tweening.To(getter: () => transform.offsetMin,
                        setter: offsetMin => transform.offsetMin = offsetMin,
                        to, duration).SetTarget(transform);

        public static Tween TweenOffsetMax(this RectTransform transform, Vector2 to, float duration) =>
            Tweening.To(getter: () => transform.offsetMax,
                        setter: offsetMax => transform.offsetMax = offsetMax,
                        to, duration).SetTarget(transform);

        public static Tween TweenPivot(this RectTransform transform, Vector2 to, float duration) =>
            Tweening.To(getter: () => transform.pivot,
                        setter: pivot => transform.pivot = pivot,
                        to, duration).SetTarget(transform);

        public static Tween TweenSizeDelta(this RectTransform transform, Vector2 to, float duration) =>
            Tweening.To(getter: () => transform.sizeDelta,
                        setter: sizeDelta => transform.sizeDelta = sizeDelta,
                        to, duration).SetTarget(transform);

    }

}
