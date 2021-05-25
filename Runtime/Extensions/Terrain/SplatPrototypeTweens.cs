using UnityEngine;

namespace Zigurous.Tweening
{
    public static class SplatPrototypeTweens
    {
        public static Tween TweenTileSize(this SplatPrototype splat, Vector2 to, float duration) =>
            Tweening.To(getter: () => splat.tileSize,
                        setter: tileSize => splat.tileSize = tileSize,
                        to, duration).SetTarget(splat);

        public static Tween TweenTileOffset(this SplatPrototype splat, Vector2 to, float duration) =>
            Tweening.To(getter: () => splat.tileOffset,
                        setter: tileOffset => splat.tileOffset = tileOffset,
                        to, duration).SetTarget(splat);

        public static Tween TweenSpecular(this SplatPrototype splat, Color to, float duration) =>
            Tweening.To(getter: () => splat.specular,
                        setter: specular => splat.specular = specular,
                        to, duration).SetTarget(splat);

        public static Tween TweenMetallic(this SplatPrototype splat, float to, float duration) =>
            Tweening.To(getter: () => splat.metallic,
                        setter: metallic => splat.metallic = metallic,
                        to, duration).SetTarget(splat);

        public static Tween TweenSmoothness(this SplatPrototype splat, float to, float duration) =>
            Tweening.To(getter: () => splat.smoothness,
                        setter: smoothness => splat.smoothness = smoothness,
                        to, duration).SetTarget(splat);

    }

}
