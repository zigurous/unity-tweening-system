using UnityEngine.UI;

namespace Zigurous.Tweening
{
    public static class ScrollbarTweens
    {
        public static Tween TweenValue(this Scrollbar scrollbar, float to, float duration) =>
            Tweening.To(scrollbar, (target) => target.value, (target, value) => target.value = value, to, duration)
                    .SetReference(scrollbar);

        public static Tween TweenSize(this Scrollbar scrollbar, float to, float duration) =>
            Tweening.To(scrollbar, (target) => target.size, (target, value) => target.size = value, to, duration)
                    .SetReference(scrollbar);
    }

}
