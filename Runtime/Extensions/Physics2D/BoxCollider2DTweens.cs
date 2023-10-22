using UnityEngine;

namespace Zigurous.Tweening
{
    public static class BoxCollider2DTweens
    {
        public static Tween TweenSize(this BoxCollider2D collider, Vector2 to, float duration) =>
            Tweening.To(collider, (target) => target.size, (target, value) => target.size = value, to, duration)
                    .SetReference(collider);

        public static Tween TweenEdgeRadius(this BoxCollider2D collider, float to, float duration) =>
            Tweening.To(collider, (target) => target.edgeRadius, (target, value) => target.edgeRadius = value, to, duration)
                    .SetReference(collider);
    }

}
