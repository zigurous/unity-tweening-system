using UnityEngine.UI;

namespace Zigurous.Tweening
{
    public static class TextTweens
    {
        public static Tween TweenFontSize(this Text text, int to, float duration) =>
            Tweening.To(text, (target) => target.fontSize, (target, value) => target.fontSize = value, to, duration)
                    .SetReference(text);
    }

}
