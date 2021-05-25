using UnityEngine.UI;

namespace Zigurous.Tweening
{
    public static class TextTweens
    {
        public static Tween TweenFontSize(this Text text, int to, float duration) =>
            Tweening.To(getter: () => text.fontSize,
                        setter: fontSize => text.fontSize = fontSize,
                        to, duration).SetTarget(text);

    }

}
