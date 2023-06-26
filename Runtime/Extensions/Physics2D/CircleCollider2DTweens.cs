using UnityEngine;

namespace Zigurous.Tweening
{
    public static class CircleCollider2DTweens
    {
        public static Tween TweenRadius(this CircleCollider2D collider, float to, float duration) =>
            Tweening.To(collider, (source) => source.radius, (source, value) => source.radius = value, to, duration)
                    .SetTarget(collider);
    }

}
