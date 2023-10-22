using UnityEngine;
using UnityEngine.Tilemaps;

namespace Zigurous.Tweening
{
    public static class TilemapTweens
    {
        public static Tween TweenColor(this Tilemap tilemap, Color to, float duration) =>
            Tweening.To(tilemap, (target) => target.color, (target, value) => target.color = value, to, duration)
                    .SetReference(tilemap);

        public static Tween TweenOrigin(this Tilemap tilemap, Vector3Int to, float duration) =>
            Tweening.To(tilemap, (target) => target.origin, (target, value) => target.origin = value, to, duration)
                    .SetReference(tilemap);

        public static Tween TweenSize(this Tilemap tilemap, Vector3Int to, float duration) =>
            Tweening.To(tilemap, (target) => target.size, (target, value) => target.size = value, to, duration)
                    .SetReference(tilemap);

        public static Tween TweenTileAnchor(this Tilemap tilemap, Vector3 to, float duration) =>
            Tweening.To(tilemap, (target) => target.tileAnchor, (target, value) => target.tileAnchor = value, to, duration)
                    .SetReference(tilemap);

        public static Tween TweenAnimationFrameRate(this Tilemap tilemap, float to, float duration) =>
            Tweening.To(tilemap, (target) => target.animationFrameRate, (target, value) => target.animationFrameRate = value, to, duration)
                    .SetReference(tilemap);
    }

}
