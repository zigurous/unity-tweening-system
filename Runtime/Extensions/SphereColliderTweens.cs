using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public static class SphereColliderTweens
    {
        public static Tween TweenCenter(this SphereCollider collider, Vector3 to, float duration) =>
            Tweener.To(getter: () => collider.center,
                       setter: center => collider.center = center,
                       to, duration).SetTarget(collider);

        public static Tween TweenRadius(this SphereCollider collider, float to, float duration) =>
            Tweener.To(getter: () => collider.radius,
                       setter: radius => collider.radius = radius,
                       to, duration).SetTarget(collider);

    }

}
