using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class SplatPrototypeTweens
    {
        public static Tween TweenTileSize(this SplatPrototype prototype, Vector2 to, float duration) =>
            Tweening.To(getter: () => prototype.tileSize,
                        setter: tileSize => prototype.tileSize = tileSize,
                        to, duration).SetTarget(prototype);

        public static Tween TweenTileOffset(this SplatPrototype prototype, Vector2 to, float duration) =>
            Tweening.To(getter: () => prototype.tileOffset,
                        setter: tileOffset => prototype.tileOffset = tileOffset,
                        to, duration).SetTarget(prototype);

        public static Tween TweenSpecular(this SplatPrototype prototype, Color to, float duration) =>
            Tweening.To(getter: () => prototype.specular,
                        setter: specular => prototype.specular = specular,
                        to, duration).SetTarget(prototype);

        public static Tween TweenMetallic(this SplatPrototype prototype, float to, float duration) =>
            Tweening.To(getter: () => prototype.metallic,
                        setter: metallic => prototype.metallic = metallic,
                        to, duration).SetTarget(prototype);

        public static Tween TweenSmoothness(this SplatPrototype prototype, float to, float duration) =>
            Tweening.To(getter: () => prototype.smoothness,
                        setter: smoothness => prototype.smoothness = smoothness,
                        to, duration).SetTarget(prototype);

    }

}
