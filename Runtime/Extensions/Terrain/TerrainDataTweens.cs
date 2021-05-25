using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class TerrainDataTweens
    {
        public static Tween TweenSize(this TerrainData data, Vector3 to, float duration) =>
            Tweening.To(getter: () => data.size,
                        setter: size => data.size = size,
                        to, duration).SetTarget(data);

        public static Tween TweenWavingGrassTint(this TerrainData data, Vector3 to, float duration) =>
            Tweening.To(getter: () => data.wavingGrassTint,
                        setter: wavingGrassTint => data.wavingGrassTint = wavingGrassTint,
                        to, duration).SetTarget(data);

        public static Tween TweenWavingGrassSpeed(this TerrainData data, float to, float duration) =>
            Tweening.To(getter: () => data.wavingGrassSpeed,
                        setter: wavingGrassSpeed => data.wavingGrassSpeed = wavingGrassSpeed,
                        to, duration).SetTarget(data);

        public static Tween TweenWavingGrassAmount(this TerrainData data, float to, float duration) =>
            Tweening.To(getter: () => data.wavingGrassAmount,
                        setter: wavingGrassAmount => data.wavingGrassAmount = wavingGrassAmount,
                        to, duration).SetTarget(data);

        public static Tween TweenWavingGrassStrength(this TerrainData data, float to, float duration) =>
            Tweening.To(getter: () => data.wavingGrassStrength,
                        setter: wavingGrassStrength => data.wavingGrassStrength = wavingGrassStrength,
                        to, duration).SetTarget(data);

    }

}
