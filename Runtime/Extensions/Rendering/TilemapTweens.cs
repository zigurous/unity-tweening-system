using UnityEngine;
using UnityEngine.Tilemaps;

namespace Zigurous.Tweening
{
    public static class TilemapTweens
    {
        public static Tween TweenColor(this Tilemap tilemap, Color to, float duration) =>
            Tweening.To(tilemap, (source) => source.color, (source, value) => source.color = value, to, duration)
                    .SetTarget(tilemap);

        public static Tween TweenOrigin(this Tilemap tilemap, Vector3Int to, float duration) =>
            Tweening.To(tilemap, (source) => source.origin, (source, value) => source.origin = value, to, duration)
                    .SetTarget(tilemap);

        public static Tween TweenSize(this Tilemap tilemap, Vector3Int to, float duration) =>
            Tweening.To(tilemap, (source) => source.size, (source, value) => source.size = value, to, duration)
                    .SetTarget(tilemap);

        public static Tween TweenTileAnchor(this Tilemap tilemap, Vector3 to, float duration) =>
            Tweening.To(tilemap, (source) => source.tileAnchor, (source, value) => source.tileAnchor = value, to, duration)
                    .SetTarget(tilemap);

        public static Tween TweenAnimationFrameRate(this Tilemap tilemap, float to, float duration) =>
            Tweening.To(tilemap, (source) => source.animationFrameRate, (source, value) => source.animationFrameRate = value, to, duration)
                    .SetTarget(tilemap);
    }

}
