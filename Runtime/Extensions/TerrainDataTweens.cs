using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class TerrainDataTweens
    {
        public static Tween TweenSize(this TerrainData terrainData, Vector3 to, float duration) =>
            Tweening.To(getter: () => terrainData.size,
                        setter: size => terrainData.size = size,
                        to, duration).SetTarget(terrainData);

        public static Tween TweenWavingGrassTint(this TerrainData terrainData, Vector3 to, float duration) =>
            Tweening.To(getter: () => terrainData.wavingGrassTint,
                        setter: wavingGrassTint => terrainData.wavingGrassTint = wavingGrassTint,
                        to, duration).SetTarget(terrainData);

        public static Tween TweenWavingGrassSpeed(this TerrainData terrainData, float to, float duration) =>
            Tweening.To(getter: () => terrainData.wavingGrassSpeed,
                        setter: wavingGrassSpeed => terrainData.wavingGrassSpeed = wavingGrassSpeed,
                        to, duration).SetTarget(terrainData);

        public static Tween TweenWavingGrassAmount(this TerrainData terrainData, float to, float duration) =>
            Tweening.To(getter: () => terrainData.wavingGrassAmount,
                        setter: wavingGrassAmount => terrainData.wavingGrassAmount = wavingGrassAmount,
                        to, duration).SetTarget(terrainData);

        public static Tween TweenWavingGrassStrength(this TerrainData terrainData, float to, float duration) =>
            Tweening.To(getter: () => terrainData.wavingGrassStrength,
                        setter: wavingGrassStrength => terrainData.wavingGrassStrength = wavingGrassStrength,
                        to, duration).SetTarget(terrainData);

    }

}
