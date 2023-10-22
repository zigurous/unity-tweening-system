using UnityEngine;

namespace Zigurous.Tweening
{
    public static class EdgeCollider2DTweens
    {
        public static Tween TweenEdgeRadius(this EdgeCollider2D collider, float to, float duration) =>
            Tweening.To(collider, (target) => target.edgeRadius, (target, value) => target.edgeRadius = value, to, duration)
                    .SetReference(collider);
    }

}
