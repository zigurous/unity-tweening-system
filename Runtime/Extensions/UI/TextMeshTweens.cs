using UnityEngine;

namespace Zigurous.Tweening
{
    public static class TextMeshTweens
    {
        public static Tween TweenColor(this TextMesh textMesh, Color to, float duration) =>
            Tweening.To(textMesh, (target) => target.color, (target, value) => target.color = value, to, duration)
                    .SetReference(textMesh);

        public static Tween TweenAlpha(this TextMesh textMesh, float to, float duration) =>
            Tweening.To(textMesh, (target) => target.color.a, (target, value) => target.color = new Color(target.color.r, target.color.g, target.color.b, value), to, duration)
                    .SetReference(textMesh);

        public static Tween TweenFontSize(this TextMesh textMesh, int to, float duration) =>
            Tweening.To(textMesh, (target) => target.fontSize, (target, value) => target.fontSize = value, to, duration)
                    .SetReference(textMesh);

        public static Tween TweenOffsetZ(this TextMesh textMesh, float to, float duration) =>
            Tweening.To(textMesh, (target) => target.offsetZ, (target, value) => target.offsetZ = value, to, duration)
                    .SetReference(textMesh);

        public static Tween TweenCharacterSize(this TextMesh textMesh, float to, float duration) =>
            Tweening.To(textMesh, (target) => target.characterSize, (target, value) => target.characterSize = value, to, duration)
                    .SetReference(textMesh);

        public static Tween TweenLineSpacing(this TextMesh textMesh, float to, float duration) =>
            Tweening.To(textMesh, (target) => target.lineSpacing, (target, value) => target.lineSpacing = value, to, duration)
                    .SetReference(textMesh);

        public static Tween TweenTabSize(this TextMesh textMesh, float to, float duration) =>
            Tweening.To(textMesh, (target) => target.tabSize, (target, value) => target.tabSize = value, to, duration)
                    .SetReference(textMesh);
    }

}
