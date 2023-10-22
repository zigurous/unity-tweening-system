using UnityEngine;

namespace Zigurous.Tweening
{
    public static class MaterialPropertyBlockTweens
    {
        public static Tween TweenColor(this MaterialPropertyBlock propertyBlock, int nameID, Color to, float duration) =>
            Tweening.To(propertyBlock, (target) => target.GetColor(nameID), (target, value) => target.SetColor(nameID, value), to, duration)
                    .SetId(propertyBlock.GetHashCode());

        public static Tween TweenColor(this MaterialPropertyBlock propertyBlock, string name, Color to, float duration) =>
            Tweening.To(propertyBlock, (target) => target.GetColor(name), (target, value) => target.SetColor(name, value), to, duration)
                    .SetId(propertyBlock.GetHashCode());

        public static Tween TweenRed(this MaterialPropertyBlock propertyBlock, int nameID, float to, float duration) =>
            Tweening.To(propertyBlock, (target) => target.GetColor(nameID).r, (target, value) => target.SetColor(nameID, target.GetColor(nameID).WithRed(value)), to, duration)
                    .SetId(propertyBlock.GetHashCode());

        public static Tween TweenRed(this MaterialPropertyBlock propertyBlock, string name, float to, float duration) =>
            Tweening.To(propertyBlock, (target) => target.GetColor(name).r, (target, value) => target.SetColor(name, target.GetColor(name).WithRed(value)), to, duration)
                    .SetId(propertyBlock.GetHashCode());

        public static Tween TweenGreen(this MaterialPropertyBlock propertyBlock, int nameID, float to, float duration) =>
            Tweening.To(propertyBlock, (target) => target.GetColor(nameID).g, (target, value) => target.SetColor(nameID, target.GetColor(nameID).WithGreen(value)), to, duration)
                    .SetId(propertyBlock.GetHashCode());

        public static Tween TweenGreen(this MaterialPropertyBlock propertyBlock, string name, float to, float duration) =>
            Tweening.To(propertyBlock, (target) => target.GetColor(name).g, (target, value) => target.SetColor(name, target.GetColor(name).WithGreen(value)), to, duration)
                    .SetId(propertyBlock.GetHashCode());

        public static Tween TweenBlue(this MaterialPropertyBlock propertyBlock, int nameID, float to, float duration) =>
            Tweening.To(propertyBlock, (target) => target.GetColor(nameID).b, (target, value) => target.SetColor(nameID, target.GetColor(nameID).WithBlue(value)), to, duration)
                    .SetId(propertyBlock.GetHashCode());

        public static Tween TweenBlue(this MaterialPropertyBlock propertyBlock, string name, float to, float duration) =>
            Tweening.To(propertyBlock, (target) => target.GetColor(name).b, (target, value) => target.SetColor(name, target.GetColor(name).WithBlue(value)), to, duration)
                    .SetId(propertyBlock.GetHashCode());

        public static Tween TweenAlpha(this MaterialPropertyBlock propertyBlock, int nameID, float to, float duration) =>
            Tweening.To(propertyBlock, (target) => target.GetColor(nameID).a, (target, value) => target.SetColor(nameID, target.GetColor(nameID).WithAlpha(value)), to, duration)
                    .SetId(propertyBlock.GetHashCode());

        public static Tween TweenAlpha(this MaterialPropertyBlock propertyBlock, string name, float to, float duration) =>
            Tweening.To(propertyBlock, (target) => target.GetColor(name).a, (target, value) => target.SetColor(name, target.GetColor(name).WithAlpha(value)), to, duration)
                    .SetId(propertyBlock.GetHashCode());

        public static Tween TweenVector(this MaterialPropertyBlock propertyBlock, int nameID, Vector4 to, float duration) =>
            Tweening.To(propertyBlock, (target) => target.GetVector(nameID), (target, value) => target.SetVector(nameID, value), to, duration)
                    .SetId(propertyBlock.GetHashCode());

        public static Tween TweenVector(this MaterialPropertyBlock propertyBlock, string name, Vector4 to, float duration) =>
            Tweening.To(propertyBlock, (target) => target.GetVector(name), (target, value) => target.SetVector(name, value), to, duration)
                    .SetId(propertyBlock.GetHashCode());

        public static Tween TweenFloat(this MaterialPropertyBlock propertyBlock, int nameID, float to, float duration) =>
            Tweening.To(propertyBlock, (target) => target.GetFloat(nameID), (target, value) => target.SetFloat(nameID, value), to, duration)
                    .SetId(propertyBlock.GetHashCode());

        public static Tween TweenFloat(this MaterialPropertyBlock propertyBlock, string name, float to, float duration) =>
            Tweening.To(propertyBlock, (target) => target.GetFloat(name), (target, value) => target.SetFloat(name, value), to, duration)
                    .SetId(propertyBlock.GetHashCode());

        public static Tween TweenInt(this MaterialPropertyBlock propertyBlock, int nameID, int to, float duration) =>
            Tweening.To(propertyBlock, (target) => target.GetInt(nameID), (target, value) => target.SetInt(nameID, value), to, duration)
                    .SetId(propertyBlock.GetHashCode());

        public static Tween TweenInt(this MaterialPropertyBlock propertyBlock, string name, int to, float duration) =>
            Tweening.To(propertyBlock, (target) => target.GetInt(name), (target, value) => target.SetInt(name, value), to, duration)
                    .SetId(propertyBlock.GetHashCode());
    }

}
