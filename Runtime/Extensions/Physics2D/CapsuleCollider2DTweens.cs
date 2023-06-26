using UnityEngine;

namespace Zigurous.Tweening
{
    public static class CapsuleCollider2DTweens
    {
        public static Tween TweenSize(this CapsuleCollider2D collider, Vector2 to, float duration) =>
            Tweening.To(collider, (source) => source.size, (source, value) => source.size = value, to, duration)
                    .SetTarget(collider);
    }

}
