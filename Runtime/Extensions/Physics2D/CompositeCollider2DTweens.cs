using UnityEngine;

namespace Zigurous.Tweening
{
    public static class CompositeCollider2DTweens
    {
        public static Tween TweenVertexDistance(this CompositeCollider2D collider, float to, float duration) =>
            Tweening.To(collider, (source) => source.vertexDistance, (source, value) => source.vertexDistance = value, to, duration)
                    .SetTarget(collider);

        public static Tween TweenEdgeRadius(this CompositeCollider2D collider, float to, float duration) =>
            Tweening.To(collider, (source) => source.edgeRadius, (source, value) => source.edgeRadius = value, to, duration)
                    .SetTarget(collider);

        public static Tween TweenOffsetDistance(this CompositeCollider2D collider, float to, float duration) =>
            Tweening.To(collider, (source) => source.offsetDistance, (source, value) => source.offsetDistance = value, to, duration)
                    .SetTarget(collider);
    }

}
