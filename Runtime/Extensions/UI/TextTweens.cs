using UnityEngine.UI;

namespace Zigurous.Tweening
{
    public static class TextTweens
    {
        public static Tween TweenFontSize(this Text text, int to, float duration) =>
            Tweening.To(text, (source) => source.fontSize, (source, value) => source.fontSize = value, to, duration)
                    .SetTarget(text);
    }

}
