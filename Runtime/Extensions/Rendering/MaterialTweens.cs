using UnityEngine;

namespace Zigurous.Tweening
{
    public static class MaterialTweens
    {
        public static Tween TweenColor(this Material material, Color to, float duration) =>
            Tweening.To(material, (target) => target.color, (target, value) => target.color = value, to, duration)
                    .SetReference(material);

        public static Tween TweenColor(this Material material, int nameID, Color to, float duration) =>
            Tweening.To(material, (target) => target.GetColor(nameID), (target, value) => target.SetColor(nameID, value), to, duration)
                    .SetReference(material);

        public static Tween TweenColor(this Material material, string name, Color to, float duration) =>
            Tweening.To(material, (target) => target.GetColor(name), (target, value) => target.SetColor(name, value), to, duration)
                    .SetReference(material);

        public static Tween TweenRed(this Material material, float to, float duration) =>
            Tweening.To(material, (target) => target.color.r, (target, value) => target.color = target.color.WithRed(value), to, duration)
                    .SetReference(material);

        public static Tween TweenRed(this Material material, int nameID, float to, float duration) =>
            Tweening.To(material, (target) => target.GetColor(nameID).r, (target, value) => target.SetColor(nameID, target.GetColor(nameID).WithRed(value)), to, duration)
                    .SetReference(material);

        public static Tween TweenRed(this Material material, string name, float to, float duration) =>
            Tweening.To(material, (target) => target.GetColor(name).r, (target, value) => target.SetColor(name, target.GetColor(name).WithRed(value)), to, duration)
                    .SetReference(material);

        public static Tween TweenGreen(this Material material, float to, float duration) =>
            Tweening.To(material, (target) => target.color.g, (target, value) => target.color = target.color.WithGreen(value), to, duration)
                    .SetReference(material);

        public static Tween TweenGreen(this Material material, int nameID, float to, float duration) =>
            Tweening.To(material, (target) => target.GetColor(nameID).g, (target, value) => target.SetColor(nameID, target.GetColor(nameID).WithGreen(value)), to, duration)
                    .SetReference(material);

        public static Tween TweenGreen(this Material material, string name, float to, float duration) =>
            Tweening.To(material, (target) => target.GetColor(name).g, (target, value) => target.SetColor(name, target.GetColor(name).WithGreen(value)), to, duration)
                    .SetReference(material);

        public static Tween TweenBlue(this Material material, float to, float duration) =>
            Tweening.To(material, (target) => target.color.b, (target, value) => target.color = target.color.WithBlue(value), to, duration)
                    .SetReference(material);

        public static Tween TweenBlue(this Material material, int nameID, float to, float duration) =>
            Tweening.To(material, (target) => target.GetColor(nameID).b, (target, value) => target.SetColor(nameID, target.GetColor(nameID).WithBlue(value)), to, duration)
                    .SetReference(material);

        public static Tween TweenBlue(this Material material, string name, float to, float duration) =>
            Tweening.To(material, (target) => target.GetColor(name).b, (target, value) => target.SetColor(name, target.GetColor(name).WithBlue(value)), to, duration)
                    .SetReference(material);

        public static Tween TweenAlpha(this Material material, float to, float duration) =>
            Tweening.To(material, (target) => target.color.a, (target, value) => target.color = target.color.WithAlpha(value), to, duration)
                    .SetReference(material);

        public static Tween TweenAlpha(this Material material, int nameID, float to, float duration) =>
            Tweening.To(material, (target) => target.GetColor(nameID).a, (target, value) => target.SetColor(nameID, target.GetColor(nameID).WithAlpha(value)), to, duration)
                    .SetReference(material);

        public static Tween TweenAlpha(this Material material, string name, float to, float duration) =>
            Tweening.To(material, (target) => target.GetColor(name).a, (target, value) => target.SetColor(name, target.GetColor(name).WithAlpha(value)), to, duration)
                    .SetReference(material);

        public static Tween TweenFloat(this Material material, int nameID, float to, float duration) =>
            Tweening.To(material, (target) => target.GetFloat(nameID), (target, value) => target.SetFloat(nameID, value), to, duration)
                    .SetReference(material);

        public static Tween TweenFloat(this Material material, string name, float to, float duration) =>
            Tweening.To(material, (target) => target.GetFloat(name), (target, value) => target.SetFloat(name, value), to, duration)
                    .SetReference(material);

        public static Tween TweenInt(this Material material, int nameID, int to, float duration) =>
            Tweening.To(material, (target) => target.GetInt(nameID), (target, value) => target.SetInt(nameID, value), to, duration)
                    .SetReference(material);

        public static Tween TweenInt(this Material material, string name, int to, float duration) =>
            Tweening.To(material, (target) => target.GetInt(name), (target, value) => target.SetInt(name, value), to, duration)
                    .SetReference(material);

        public static Tween TweenMainTextureOffset(this Material material, Vector2 to, float duration) =>
            Tweening.To(material, (target) => target.mainTextureOffset, (target, value) => target.mainTextureOffset = value, to, duration)
                    .SetReference(material);

        public static Tween TweenMainTextureScale(this Material material, Vector2 to, float duration) =>
            Tweening.To(material, (target) => target.mainTextureScale, (target, value) => target.mainTextureScale = value, to, duration)
                    .SetReference(material);

        public static Tween TweenTextureOffset(this Material material, int nameID, Vector2 to, float duration) =>
            Tweening.To(material, (target) => target.GetTextureOffset(nameID), (target, value) => target.SetTextureOffset(nameID, value), to, duration)
                    .SetReference(material);

        public static Tween TweenTextureOffset(this Material material, string name, Vector2 to, float duration) =>
            Tweening.To(material, (target) => target.GetTextureOffset(name), (target, value) => target.SetTextureOffset(name, value), to, duration)
                    .SetReference(material);

        public static Tween TweenTextureScale(this Material material, int nameID, Vector2 to, float duration) =>
            Tweening.To(material, (target) => target.GetTextureScale(nameID), (target, value) => target.SetTextureScale(nameID, value), to, duration)
                    .SetReference(material);

        public static Tween TweenTextureScale(this Material material, string name, Vector2 to, float duration) =>
            Tweening.To(material, (target) => target.GetTextureScale(name), (target, value) => target.SetTextureScale(name, value), to, duration)
                    .SetReference(material);
    }

}
