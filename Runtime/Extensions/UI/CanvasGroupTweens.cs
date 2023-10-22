using UnityEngine;

namespace Zigurous.Tweening
{
    public static class CanvasGroupTweens
    {
        public static Tween TweenAlpha(this CanvasGroup canvasGroup, float to, float duration) =>
            Tweening.To(canvasGroup, (target) => target.alpha, (target, value) => target.alpha = value, to, duration)
                    .SetReference(canvasGroup);
    }

}
