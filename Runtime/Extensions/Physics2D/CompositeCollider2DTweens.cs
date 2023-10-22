using UnityEngine;

namespace Zigurous.Tweening
{
    public static class CompositeCollider2DTweens
    {
        public static Tween TweenVertexDistance(this CompositeCollider2D collider, float to, float duration) =>
            Tweening.To(collider, (target) => target.vertexDistance, (target, value) => target.vertexDistance = value, to, duration)
                    .SetReference(collider);

        public static Tween TweenEdgeRadius(this CompositeCollider2D collider, float to, float duration) =>
            Tweening.To(collider, (target) => target.edgeRadius, (target, value) => target.edgeRadius = value, to, duration)
                    .SetReference(collider);

        public static Tween TweenOffsetDistance(this CompositeCollider2D collider, float to, float duration) =>
            Tweening.To(collider, (target) => target.offsetDistance, (target, value) => target.offsetDistance = value, to, duration)
                    .SetReference(collider);
    }

}
