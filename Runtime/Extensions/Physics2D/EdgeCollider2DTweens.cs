using UnityEngine;

namespace Zigurous.Tweening
{
    public static class EdgeCollider2DTweens
    {
        public static Tween TweenEdgeRadius(this EdgeCollider2D collider, float to, float duration) =>
            Tweening.To(collider, (source) => source.edgeRadius, (source, value) => source.edgeRadius = value, to, duration)
                    .SetTarget(collider);
    }

}
