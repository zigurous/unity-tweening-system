using UnityEngine;
using UnityEngine.UI;

namespace Zigurous.Tweening
{
    public static class RectMask2DTweens
    {
        public static Tween TweenPadding(this RectMask2D mask, Vector4 to, float duration) =>
            Tweening.To(getter: () => mask.padding,
                        setter: padding => mask.padding = padding,
                        to, duration).SetTarget(mask);

        public static Tween TweenSoftness(this RectMask2D mask, Vector2Int to, float duration) =>
            Tweening.To(getter: () => mask.softness,
                        setter: softness => mask.softness = softness,
                        to, duration).SetTarget(mask);

    }

}
