using UnityEngine.UI;

namespace Zigurous.Tweening
{
    public static class ScrollbarTweens
    {
        public static Tween TweenValue(this Scrollbar scrollbar, float to, float duration) =>
            Tweening.To(getter: () => scrollbar.value,
                        setter: value => scrollbar.value = value,
                        to, duration).SetTarget(scrollbar);

        public static Tween TweenSize(this Scrollbar scrollbar, float to, float duration) =>
            Tweening.To(getter: () => scrollbar.size,
                        setter: size => scrollbar.size = size,
                        to, duration).SetTarget(scrollbar);

    }

}
