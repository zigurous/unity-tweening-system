using UnityEngine.UI;

namespace Zigurous.Tweening
{
    public static class ScrollbarTweens
    {
        public static Tween TweenValue(this Scrollbar scrollbar, float to, float duration) =>
            Tweening.To(scrollbar, (source) => source.value, (source, value) => source.value = value, to, duration)
                    .SetTarget(scrollbar);

        public static Tween TweenSize(this Scrollbar scrollbar, float to, float duration) =>
            Tweening.To(scrollbar, (source) => source.size, (source, value) => source.size = value, to, duration)
                    .SetTarget(scrollbar);
    }

}
