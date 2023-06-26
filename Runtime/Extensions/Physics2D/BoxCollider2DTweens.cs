using UnityEngine;

namespace Zigurous.Tweening
{
    public static class BoxCollider2DTweens
    {
        public static Tween TweenSize(this BoxCollider2D collider, Vector2 to, float duration) =>
            Tweening.To(collider, (source) => source.size, (source, value) => source.size = value, to, duration)
                    .SetTarget(collider);

        public static Tween TweenEdgeRadius(this BoxCollider2D collider, float to, float duration) =>
            Tweening.To(collider, (source) => source.edgeRadius, (source, value) => source.edgeRadius = value, to, duration)
                    .SetTarget(collider);
    }

}
