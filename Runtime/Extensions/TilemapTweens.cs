using UnityEngine;
using UnityEngine.Tilemaps;

namespace Zigurous.Animation.Tweening
{
    public static class TilemapTweens
    {
        public static Tween TweenColor(this Tilemap tilemap, Color to, float duration) =>
            Tweener.To(getter: () => tilemap.color,
                       setter: color => tilemap.color = color,
                       to, duration).SetTarget(tilemap);

        public static Tween TweenOrigin(this Tilemap tilemap, Vector3Int to, float duration) =>
            Tweener.To(getter: () => tilemap.origin,
                       setter: origin => tilemap.origin = origin,
                       to, duration).SetTarget(tilemap);

        public static Tween TweenSize(this Tilemap tilemap, Vector3Int to, float duration) =>
            Tweener.To(getter: () => tilemap.size,
                       setter: size => tilemap.size = size,
                       to, duration).SetTarget(tilemap);

        public static Tween TweenTileAnchor(this Tilemap tilemap, Vector3 to, float duration) =>
            Tweener.To(getter: () => tilemap.tileAnchor,
                       setter: tileAnchor => tilemap.tileAnchor = tileAnchor,
                       to, duration).SetTarget(tilemap);

        public static Tween TweenAnimationFrameRate(this Tilemap tilemap, float to, float duration) =>
            Tweener.To(getter: () => tilemap.animationFrameRate,
                       setter: animationFrameRate => tilemap.animationFrameRate = animationFrameRate,
                       to, duration).SetTarget(tilemap);

    }

}
