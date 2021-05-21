using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public static class BoxColliderTweens
    {
        public static Tween TweenCenter(this BoxCollider collider, Vector3 to, float duration) =>
            Tweener.To(getter: () => collider.center,
                       setter: center => collider.center = center,
                       to, duration).SetTarget(collider);

        public static Tween TweenSize(this BoxCollider collider, Vector3 to, float duration) =>
            Tweener.To(getter: () => collider.size,
                       setter: size => collider.size = size,
                       to, duration).SetTarget(collider);

    }

}
