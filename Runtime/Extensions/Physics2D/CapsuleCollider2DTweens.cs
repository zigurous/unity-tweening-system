using UnityEngine;

namespace Zigurous.Tweening
{
    public static class CapsuleCollider2DTweens
    {
        public static Tween TweenSize(this CapsuleCollider2D collider, Vector2 to, float duration) =>
            Tweening.To(collider, (target) => target.size, (target, value) => target.size = value, to, duration)
                    .SetReference(collider);
    }

}
