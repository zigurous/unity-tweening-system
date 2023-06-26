using UnityEngine;

namespace Zigurous.Tweening
{
    public static class CapsuleColliderTweens
    {
        public static Tween TweenCenter(this CapsuleCollider collider, Vector3 to, float duration) =>
            Tweening.To(collider, (source) => source.center, (source, value) => source.center = value, to, duration)
                    .SetTarget(collider);

        public static Tween TweenRadius(this CapsuleCollider collider, float to, float duration) =>
            Tweening.To(collider, (source) => source.radius, (source, value) => source.radius = value, to, duration)
                    .SetTarget(collider);

        public static Tween TweenHeight(this CapsuleCollider collider, float to, float duration) =>
            Tweening.To(collider, (source) => source.height, (source, value) => source.height = value, to, duration)
                    .SetTarget(collider);
    }

}
