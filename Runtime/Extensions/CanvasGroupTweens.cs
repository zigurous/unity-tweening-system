using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public static class CanvasGroupTweens
    {
        public static Tween TweenAlpha(this CanvasGroup canvasGroup, float to, float duration) =>
            Tweener.To(getter: () => canvasGroup.alpha,
                       setter: alpha => canvasGroup.alpha = alpha,
                       to, duration).SetTarget(canvasGroup);

    }

}
