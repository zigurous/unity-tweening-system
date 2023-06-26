using UnityEngine;

namespace Zigurous.Tweening
{
    public static class CanvasGroupTweens
    {
        public static Tween TweenAlpha(this CanvasGroup canvasGroup, float to, float duration) =>
            Tweening.To(canvasGroup, (source) => source.alpha, (source, value) => source.alpha = value, to, duration)
                    .SetTarget(canvasGroup);
    }

}
