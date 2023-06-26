using UnityEngine;

namespace Zigurous.Tweening
{
    public static class MaterialTweens
    {
        public static Tween TweenColor(this Material material, Color to, float duration) =>
            Tweening.To(material, (source) => source.color, (source, value) => source.color = value, to, duration)
                    .SetId(material.GetHashCode());

        public static Tween TweenColor(this Material material, int nameID, Color to, float duration) =>
            Tweening.To(material, (source) => source.GetColor(nameID), (source, value) => source.SetColor(nameID, value), to, duration)
                    .SetId(material.GetHashCode());

        public static Tween TweenColor(this Material material, string name, Color to, float duration) =>
            Tweening.To(material, (source) => source.GetColor(name), (source, value) => source.SetColor(name, value), to, duration)
                    .SetId(material.GetHashCode());

        public static Tween TweenAlpha(this Material material, float to, float duration) =>
            Tweening.To(material, (source) => source.color.a, (source, value) => source.color = new Color(source.color.r, source.color.g, source.color.b, value), to, duration)
                    .SetId(material.GetHashCode());

        public static Tween TweenAlpha(this Material material, int nameID, float to, float duration) =>
            Tweening.To(material, (source) => source.GetColor(nameID).a, (source, value) => source.SetColor(nameID, new Color(source.color.r, source.color.g, source.color.b, value)), to, duration)
                    .SetId(material.GetHashCode());

        public static Tween TweenAlpha(this Material material, string name, float to, float duration) =>
            Tweening.To(material, (source) => source.GetColor(name).a, (source, value) => source.SetColor(name, new Color(source.color.r, source.color.g, source.color.b, value)), to, duration)
                    .SetId(material.GetHashCode());

        public static Tween TweenFloat(this Material material, int nameID, float to, float duration) =>
            Tweening.To(material, (source) => source.GetFloat(nameID), (source, value) => source.SetFloat(nameID, value), to, duration)
                    .SetId(material.GetHashCode());

        public static Tween TweenFloat(this Material material, string name, float to, float duration) =>
            Tweening.To(material, (source) => source.GetFloat(name), (source, value) => source.SetFloat(name, value), to, duration)
                    .SetId(material.GetHashCode());

        public static Tween TweenInt(this Material material, int nameID, int to, float duration) =>
            Tweening.To(material, (source) => source.GetInt(nameID), (source, value) => source.SetInt(nameID, value), to, duration)
                    .SetId(material.GetHashCode());

        public static Tween TweenInt(this Material material, string name, int to, float duration) =>
            Tweening.To(material, (source) => source.GetInt(name), (source, value) => source.SetInt(name, value), to, duration)
                    .SetId(material.GetHashCode());

        public static Tween TweenMainTextureOffset(this Material material, Vector2 to, float duration) =>
            Tweening.To(material, (source) => source.mainTextureOffset, (source, value) => source.mainTextureOffset = value, to, duration)
                    .SetId(material.GetHashCode());

        public static Tween TweenMainTextureScale(this Material material, Vector2 to, float duration) =>
            Tweening.To(material, (source) => source.mainTextureScale, (source, value) => source.mainTextureScale = value, to, duration)
                    .SetId(material.GetHashCode());

        public static Tween TweenTextureOffset(this Material material, int nameID, Vector2 to, float duration) =>
            Tweening.To(material, (source) => source.GetTextureOffset(nameID), (source, value) => source.SetTextureOffset(nameID, value), to, duration)
                    .SetId(material.GetHashCode());

        public static Tween TweenTextureOffset(this Material material, string name, Vector2 to, float duration) =>
            Tweening.To(material, (source) => source.GetTextureOffset(name), (source, value) => source.SetTextureOffset(name, value), to, duration)
                    .SetId(material.GetHashCode());

        public static Tween TweenTextureScale(this Material material, int nameID, Vector2 to, float duration) =>
            Tweening.To(material, (source) => source.GetTextureScale(nameID), (source, value) => source.SetTextureScale(nameID, value), to, duration)
                    .SetId(material.GetHashCode());

        public static Tween TweenTextureScale(this Material material, string name, Vector2 to, float duration) =>
            Tweening.To(material, (source) => source.GetTextureScale(name), (source, value) => source.SetTextureScale(name, value), to, duration)
                    .SetId(material.GetHashCode());
    }

}
