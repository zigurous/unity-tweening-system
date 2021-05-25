using UnityEngine;

namespace Zigurous.Tweening
{
    public static class CircleCollider2DTweens
    {
        public static Tween TweenRadius(this CircleCollider2D collider, float to, float duration) =>
            Tweening.To(getter: () => collider.radius,
                        setter: radius => collider.radius = radius,
                        to, duration).SetTarget(collider);

    }

}
