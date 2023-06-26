using UnityEngine;
using UnityEngine.UI;

namespace Zigurous.Tweening
{
    public static class RectMask2DTweens
    {
        public static Tween TweenPadding(this RectMask2D mask, Vector4 to, float duration) =>
            Tweening.To(mask, (source) => source.padding, (source, value) => source.padding = value, to, duration)
                    .SetTarget(mask);

        public static Tween TweenSoftness(this RectMask2D mask, Vector2Int to, float duration) =>
            Tweening.To(mask, (source) => source.softness, (source, value) => source.softness = value, to, duration)
                    .SetTarget(mask);
    }

}
