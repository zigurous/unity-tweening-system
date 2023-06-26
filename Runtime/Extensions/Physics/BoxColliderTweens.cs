using UnityEngine;

namespace Zigurous.Tweening
{
    public static class BoxColliderTweens
    {
        public static Tween TweenCenter(this BoxCollider collider, Vector3 to, float duration) =>
            Tweening.To(collider, (source) => source.center, (source, value) => source.center = value, to, duration)
                    .SetTarget(collider);

        public static Tween TweenSize(this BoxCollider collider, Vector3 to, float duration) =>
            Tweening.To(collider, (source) => source.size, (source, value) => source.size = value, to, duration)
                    .SetTarget(collider);
    }

}
