using UnityEngine;

namespace Zigurous.Tweening
{
    public static class BoxColliderTweens
    {
        public static Tween TweenCenter(this BoxCollider collider, Vector3 to, float duration) =>
            Tweening.To(collider, (target) => target.center, (target, value) => target.center = value, to, duration)
                    .SetReference(collider);

        public static Tween TweenSize(this BoxCollider collider, Vector3 to, float duration) =>
            Tweening.To(collider, (target) => target.size, (target, value) => target.size = value, to, duration)
                    .SetReference(collider);
    }

}
