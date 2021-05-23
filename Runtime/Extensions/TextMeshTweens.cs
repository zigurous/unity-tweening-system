using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class TextMeshTweens
    {
        public static Tween TweenColor(this TextMesh textMesh, Color to, float duration) =>
            Tweening.To(getter: () => textMesh.color,
                        setter: color => textMesh.color = color,
                        to, duration).SetTarget(textMesh);

        public static Tween TweenAlpha(this TextMesh textMesh, float to, float duration) =>
            Tweening.To(getter: () => textMesh.color.a,
                        setter: alpha => textMesh.color = new Color(textMesh.color.r, textMesh.color.g, textMesh.color.b, alpha),
                        to, duration).SetTarget(textMesh);

        public static Tween TweenFontSize(this TextMesh textMesh, int to, float duration) =>
            Tweening.To(getter: () => textMesh.fontSize,
                        setter: fontSize => textMesh.fontSize = fontSize,
                        to, duration).SetTarget(textMesh);

        public static Tween TweenOffsetZ(this TextMesh textMesh, float to, float duration) =>
            Tweening.To(getter: () => textMesh.offsetZ,
                        setter: offsetZ => textMesh.offsetZ = offsetZ,
                        to, duration).SetTarget(textMesh);

        public static Tween TweenCharacterSize(this TextMesh textMesh, float to, float duration) =>
            Tweening.To(getter: () => textMesh.characterSize,
                        setter: characterSize => textMesh.characterSize = characterSize,
                        to, duration).SetTarget(textMesh);

        public static Tween TweenLineSpacing(this TextMesh textMesh, float to, float duration) =>
            Tweening.To(getter: () => textMesh.lineSpacing,
                        setter: lineSpacing => textMesh.lineSpacing = lineSpacing,
                        to, duration).SetTarget(textMesh);

        public static Tween TweenTabSize(this TextMesh textMesh, float to, float duration) =>
            Tweening.To(getter: () => textMesh.tabSize,
                        setter: tabSize => textMesh.tabSize = tabSize,
                        to, duration).SetTarget(textMesh);

    }

}
