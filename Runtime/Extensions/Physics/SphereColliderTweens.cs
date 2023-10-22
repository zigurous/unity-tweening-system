using UnityEngine;

namespace Zigurous.Tweening
{
    public static class SphereColliderTweens
    {
        public static Tween TweenCenter(this SphereCollider collider, Vector3 to, float duration) =>
            Tweening.To(collider, (target) => target.center, (target, value) => target.center = value, to, duration)
                    .SetReference(collider);

        public static Tween TweenRadius(this SphereCollider collider, float to, float duration) =>
            Tweening.To(collider, (target) => target.radius, (target, value) => target.radius = value, to, duration)
                    .SetReference(collider);
    }

}
