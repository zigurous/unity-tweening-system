using UnityEngine;

namespace Zigurous.Tweening
{
    public static class TextMeshTweens
    {
        public static Tween TweenColor(this TextMesh textMesh, Color to, float duration) =>
            Tweening.To(textMesh, (source) => source.color, (source, value) => source.color = value, to, duration)
                    .SetTarget(textMesh);

        public static Tween TweenAlpha(this TextMesh textMesh, float to, float duration) =>
            Tweening.To(textMesh, (source) => source.color.a, (source, value) => source.color = new Color(source.color.r, source.color.g, source.color.b, value), to, duration)
                    .SetTarget(textMesh);

        public static Tween TweenFontSize(this TextMesh textMesh, int to, float duration) =>
            Tweening.To(textMesh, (source) => source.fontSize, (source, value) => source.fontSize = value, to, duration)
                    .SetTarget(textMesh);

        public static Tween TweenOffsetZ(this TextMesh textMesh, float to, float duration) =>
            Tweening.To(textMesh, (source) => source.offsetZ, (source, value) => source.offsetZ = value, to, duration)
                    .SetTarget(textMesh);

        public static Tween TweenCharacterSize(this TextMesh textMesh, float to, float duration) =>
            Tweening.To(textMesh, (source) => source.characterSize, (source, value) => source.characterSize = value, to, duration)
                    .SetTarget(textMesh);

        public static Tween TweenLineSpacing(this TextMesh textMesh, float to, float duration) =>
            Tweening.To(textMesh, (source) => source.lineSpacing, (source, value) => source.lineSpacing = value, to, duration)
                    .SetTarget(textMesh);

        public static Tween TweenTabSize(this TextMesh textMesh, float to, float duration) =>
            Tweening.To(textMesh, (source) => source.tabSize, (source, value) => source.tabSize = value, to, duration)
                    .SetTarget(textMesh);
    }

}
