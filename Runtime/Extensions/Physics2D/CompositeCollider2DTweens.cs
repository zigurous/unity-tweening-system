using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class CompositeCollider2DTweens
    {
        public static Tween TweenVertexDistance(this CompositeCollider2D collider, float to, float duration) =>
            Tweening.To(getter: () => collider.vertexDistance,
                        setter: vertexDistance => collider.vertexDistance = vertexDistance,
                        to, duration).SetTarget(collider);

        public static Tween TweenEdgeRadius(this CompositeCollider2D collider, float to, float duration) =>
            Tweening.To(getter: () => collider.edgeRadius,
                        setter: edgeRadius => collider.edgeRadius = edgeRadius,
                        to, duration).SetTarget(collider);

        public static Tween TweenOffsetDistance(this CompositeCollider2D collider, float to, float duration) =>
            Tweening.To(getter: () => collider.offsetDistance,
                        setter: offsetDistance => collider.offsetDistance = offsetDistance,
                        to, duration).SetTarget(collider);

    }

}
