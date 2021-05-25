using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class BoxCollider2DTweens
    {
        public static Tween TweenSize(this BoxCollider2D collider, Vector2 to, float duration) =>
            Tweening.To(getter: () => collider.size,
                        setter: size => collider.size = size,
                        to, duration).SetTarget(collider);

        public static Tween TweenEdgeRadius(this BoxCollider2D collider, float to, float duration) =>
            Tweening.To(getter: () => collider.edgeRadius,
                        setter: edgeRadius => collider.edgeRadius = edgeRadius,
                        to, duration).SetTarget(collider);

    }

}
