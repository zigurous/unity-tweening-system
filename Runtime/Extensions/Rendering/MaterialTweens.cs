using UnityEngine;

namespace Zigurous.Tweening
{
    public static class MaterialTweens
    {
        public static Tween TweenColor(this Material material, Color to, float duration) =>
            Tweening.To(getter: () => material.color,
                        setter: color => material.color = color,
                        to, duration).SetId(material.GetHashCode());

        public static Tween TweenColor(this Material material, Color to, int nameId, float duration) =>
            Tweening.To(getter: () => material.GetColor(nameId),
                        setter: color => material.SetColor(nameId, color),
                        to, duration).SetId(material.GetHashCode());

        public static Tween TweenColor(this Material material, Color to, string name, float duration) =>
            Tweening.To(getter: () => material.GetColor(name),
                        setter: color => material.SetColor(name, color),
                        to, duration).SetId(material.GetHashCode());

        public static Tween TweenAlpha(this Material material, float to, float duration) =>
            Tweening.To(getter: () => material.color.a,
                        setter: alpha => material.color = new Color(material.color.r, material.color.g, material.color.b, alpha),
                        to, duration).SetId(material.GetHashCode());

        public static Tween TweenAlpha(this Material material, float to, int nameId, float duration) =>
            Tweening.To(getter: () => material.GetColor(nameId).a,
                        setter: alpha => material.SetColor(nameId, new Color(material.color.r, material.color.g, material.color.b, alpha)),
                        to, duration).SetId(material.GetHashCode());

        public static Tween TweenAlpha(this Material material, float to, string name, float duration) =>
            Tweening.To(getter: () => material.GetColor(name).a,
                        setter: alpha => material.SetColor(name, new Color(material.color.r, material.color.g, material.color.b, alpha)),
                        to, duration).SetId(material.GetHashCode());

        public static Tween TweenFloat(this Material material, float to, int nameId, float duration) =>
            Tweening.To(getter: () => material.GetFloat(nameId),
                        setter: value => material.SetFloat(nameId, value),
                        to, duration).SetId(material.GetHashCode());

        public static Tween TweenFloat(this Material material, float to, string name, float duration) =>
            Tweening.To(getter: () => material.GetFloat(name),
                        setter: value => material.SetFloat(name, value),
                        to, duration).SetId(material.GetHashCode());

        public static Tween TweenInt(this Material material, int to, int nameId, float duration) =>
            Tweening.To(getter: () => material.GetInt(nameId),
                        setter: value => material.SetInt(nameId, value),
                        to, duration).SetId(material.GetHashCode());

        public static Tween TweenInt(this Material material, int to, string name, float duration) =>
            Tweening.To(getter: () => material.GetInt(name),
                        setter: value => material.SetInt(name, value),
                        to, duration).SetId(material.GetHashCode());

        public static Tween TweenMainTextureOffset(this Material material, Vector2 to, float duration) =>
            Tweening.To(getter: () => material.mainTextureOffset,
                        setter: mainTextureOffset => material.mainTextureOffset = mainTextureOffset,
                        to, duration).SetId(material.GetHashCode());

        public static Tween TweenMainTextureScale(this Material material, Vector2 to, float duration) =>
            Tweening.To(getter: () => material.mainTextureScale,
                        setter: mainTextureScale => material.mainTextureScale = mainTextureScale,
                        to, duration).SetId(material.GetHashCode());

        public static Tween TweenTextureOffset(this Material material, Vector2 to, int nameId, float duration) =>
            Tweening.To(getter: () => material.GetTextureOffset(nameId),
                        setter: value => material.SetTextureOffset(nameId, value),
                        to, duration).SetId(material.GetHashCode());

        public static Tween TweenTextureOffset(this Material material, Vector2 to, string name, float duration) =>
            Tweening.To(getter: () => material.GetTextureOffset(name),
                        setter: value => material.SetTextureOffset(name, value),
                        to, duration).SetId(material.GetHashCode());

        public static Tween TweenTextureScale(this Material material, Vector2 to, int nameId, float duration) =>
            Tweening.To(getter: () => material.GetTextureScale(nameId),
                        setter: value => material.SetTextureScale(nameId, value),
                        to, duration).SetId(material.GetHashCode());

        public static Tween TweenTextureScale(this Material material, Vector2 to, string name, float duration) =>
            Tweening.To(getter: () => material.GetTextureScale(name),
                        setter: value => material.SetTextureScale(name, value),
                        to, duration).SetId(material.GetHashCode());

    }

}
