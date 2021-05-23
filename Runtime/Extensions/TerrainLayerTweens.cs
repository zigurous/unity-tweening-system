using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class TerrainLayerTweens
    {
        public static Tween TweenTileSize(this TerrainLayer layer, Vector2 to, float duration) =>
            Tweening.To(getter: () => layer.tileSize,
                        setter: tileSize => layer.tileSize = tileSize,
                        to, duration).SetTarget(layer);

        public static Tween TweenTileOffset(this TerrainLayer layer, Vector2 to, float duration) =>
            Tweening.To(getter: () => layer.tileOffset,
                        setter: tileOffset => layer.tileOffset = tileOffset,
                        to, duration).SetTarget(layer);

        public static Tween TweenSpecular(this TerrainLayer layer, Color to, float duration) =>
            Tweening.To(getter: () => layer.specular,
                        setter: specular => layer.specular = specular,
                        to, duration).SetTarget(layer);

        public static Tween TweenMetallic(this TerrainLayer layer, float to, float duration) =>
            Tweening.To(getter: () => layer.metallic,
                        setter: metallic => layer.metallic = metallic,
                        to, duration).SetTarget(layer);

        public static Tween TweenSmoothness(this TerrainLayer layer, float to, float duration) =>
            Tweening.To(getter: () => layer.smoothness,
                        setter: smoothness => layer.smoothness = smoothness,
                        to, duration).SetTarget(layer);

        public static Tween TweenNormalScale(this TerrainLayer layer, float to, float duration) =>
            Tweening.To(getter: () => layer.normalScale,
                        setter: normalScale => layer.normalScale = normalScale,
                        to, duration).SetTarget(layer);

        public static Tween TweenDiffuseRemapMin(this TerrainLayer layer, Vector4 to, float duration) =>
            Tweening.To(getter: () => layer.diffuseRemapMin,
                        setter: diffuseRemapMin => layer.diffuseRemapMin = diffuseRemapMin,
                        to, duration).SetTarget(layer);

        public static Tween TweenDiffuseRemapMax(this TerrainLayer layer, Vector4 to, float duration) =>
            Tweening.To(getter: () => layer.diffuseRemapMax,
                        setter: diffuseRemapMax => layer.diffuseRemapMax = diffuseRemapMax,
                        to, duration).SetTarget(layer);

        public static Tween TweenMaskRemapMin(this TerrainLayer layer, Vector4 to, float duration) =>
            Tweening.To(getter: () => layer.maskMapRemapMin,
                        setter: maskMapRemapMin => layer.maskMapRemapMin = maskMapRemapMin,
                        to, duration).SetTarget(layer);

        public static Tween TweenMaskRemapMax(this TerrainLayer layer, Vector4 to, float duration) =>
            Tweening.To(getter: () => layer.maskMapRemapMax,
                        setter: maskMapRemapMax => layer.maskMapRemapMax = maskMapRemapMax,
                        to, duration).SetTarget(layer);

    }

}
