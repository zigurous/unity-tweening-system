using UnityEngine;

namespace Zigurous.Tweening
{
    public static class CircleCollider2DTweens
    {
        public static Tween TweenRadius(this CircleCollider2D collider, float to, float duration) =>
            Tweening.To(collider, (target) => target.radius, (target, value) => target.radius = value, to, duration)
                    .SetReference(collider);
    }

}
