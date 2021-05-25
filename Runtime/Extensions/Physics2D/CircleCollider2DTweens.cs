using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class CircleCollider2DTweens
    {
        public static Tween TweenRadius(this CircleCollider2D collider, float to, float duration) =>
            Tweening.To(getter: () => collider.radius,
                        setter: radius => collider.radius = radius,
                        to, duration).SetTarget(collider);

    }

}
