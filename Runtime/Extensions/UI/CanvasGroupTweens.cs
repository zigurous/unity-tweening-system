using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class CanvasGroupTweens
    {
        public static Tween TweenAlpha(this CanvasGroup canvasGroup, float to, float duration) =>
            Tweening.To(getter: () => canvasGroup.alpha,
                        setter: alpha => canvasGroup.alpha = alpha,
                        to, duration).SetTarget(canvasGroup);

    }

}
