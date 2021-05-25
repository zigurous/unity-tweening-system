using UnityEngine;

namespace Zigurous.Tweening
{
    public static class EdgeCollider2DTweens
    {
        public static Tween TweenEdgeRadius(this EdgeCollider2D collider, float to, float duration) =>
            Tweening.To(getter: () => collider.edgeRadius,
                        setter: edgeRadius => collider.edgeRadius = edgeRadius,
                        to, duration).SetTarget(collider);

    }

}
