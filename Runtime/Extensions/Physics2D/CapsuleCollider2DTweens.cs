using UnityEngine;

namespace Zigurous.Tweening
{
    public static class CapsuleCollider2DTweens
    {
        public static Tween TweenSize(this CapsuleCollider2D collider, Vector2 to, float duration) =>
            Tweening.To(getter: () => collider.size,
                        setter: size => collider.size = size,
                        to, duration).SetTarget(collider);

    }

}
