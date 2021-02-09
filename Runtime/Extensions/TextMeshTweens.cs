using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public static class TextMeshTweens
    {
        public static Tween TweenFontSize(this TextMesh textMesh, int to, float duration) =>
            Tweener.To(getter: () => textMesh.fontSize,
                       setter: fontSize => textMesh.fontSize = (int)fontSize,
                       to, duration).SetTarget(textMesh);

        public static Tween TweenOffsetZ(this TextMesh textMesh, float to, float duration) =>
            Tweener.To(getter: () => textMesh.offsetZ,
                       setter: offsetZ => textMesh.offsetZ = offsetZ,
                       to, duration).SetTarget(textMesh);

        public static Tween TweenCharacterSize(this TextMesh textMesh, float to, float duration) =>
            Tweener.To(getter: () => textMesh.characterSize,
                       setter: characterSize => textMesh.characterSize = characterSize,
                       to, duration).SetTarget(textMesh);

        public static Tween TweenColor(this TextMesh textMesh, Color to, float duration)
        {
            Color from = textMesh.color;
            return Tweener.To(
                getter: () => { from = textMesh.color; return 0.0f; },
                setter: t => { textMesh.color = Color.Lerp(from, to, t); },
                endValue: 1.0f, duration).SetTarget(textMesh);
        }

        public static Tween TweenAlpha(this TextMesh textMesh, float to, float duration) =>
            Tweener.To(getter: () => textMesh.color.a,
                       setter: alpha => textMesh.color = new Color(textMesh.color.r, textMesh.color.g, textMesh.color.b, alpha),
                       to, duration).SetTarget(textMesh);

    }

}
