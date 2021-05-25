using UnityEngine;

namespace Zigurous.Tweening
{
    public static class CapsuleColliderTweens
    {
        public static Tween TweenCenter(this CapsuleCollider collider, Vector3 to, float duration) =>
            Tweening.To(getter: () => collider.center,
                        setter: center => collider.center = center,
                        to, duration).SetTarget(collider);

        public static Tween TweenRadius(this CapsuleCollider collider, float to, float duration) =>
            Tweening.To(getter: () => collider.radius,
                        setter: radius => collider.radius = radius,
                        to, duration).SetTarget(collider);

        public static Tween TweenHeight(this CapsuleCollider collider, float to, float duration) =>
            Tweening.To(getter: () => collider.height,
                        setter: height => collider.height = height,
                        to, duration).SetTarget(collider);

    }

}
