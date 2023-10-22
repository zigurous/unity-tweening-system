using UnityEngine;

namespace Zigurous.Tweening
{
    public static class CapsuleColliderTweens
    {
        public static Tween TweenCenter(this CapsuleCollider collider, Vector3 to, float duration) =>
            Tweening.To(collider, (target) => target.center, (target, value) => target.center = value, to, duration)
                    .SetReference(collider);

        public static Tween TweenRadius(this CapsuleCollider collider, float to, float duration) =>
            Tweening.To(collider, (target) => target.radius, (target, value) => target.radius = value, to, duration)
                    .SetReference(collider);

        public static Tween TweenHeight(this CapsuleCollider collider, float to, float duration) =>
            Tweening.To(collider, (target) => target.height, (target, value) => target.height = value, to, duration)
                    .SetReference(collider);
    }

}
