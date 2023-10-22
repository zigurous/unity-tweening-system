using UnityEngine;
using UnityEngine.UI;

namespace Zigurous.Tweening
{
    public static class RectMask2DTweens
    {
        public static Tween TweenPadding(this RectMask2D mask, Vector4 to, float duration) =>
            Tweening.To(mask, (target) => target.padding, (target, value) => target.padding = value, to, duration)
                    .SetReference(mask);

        public static Tween TweenSoftness(this RectMask2D mask, Vector2Int to, float duration) =>
            Tweening.To(mask, (target) => target.softness, (target, value) => target.softness = value, to, duration)
                    .SetReference(mask);
    }

}
