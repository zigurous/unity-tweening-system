using UnityEngine;

namespace Zigurous.Tweening
{
    public static class SphereColliderTweens
    {
        public static Tween TweenCenter(this SphereCollider collider, Vector3 to, float duration) =>
            Tweening.To(collider, (source) => source.center, (source, value) => source.center = value, to, duration)
                    .SetTarget(collider);

        public static Tween TweenRadius(this SphereCollider collider, float to, float duration) =>
            Tweening.To(collider, (source) => source.radius, (source, value) => source.radius = value, to, duration)
                    .SetTarget(collider);
    }

}
