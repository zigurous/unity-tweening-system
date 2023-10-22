using UnityEngine;

namespace Zigurous.Tweening
{
    public static class Collider2DTweens
    {
        public static Tween TweenDensity(this Collider2D collider, float to, float duration) =>
            Tweening.To(collider, (target) => target.density, (target, value) => target.density = value, to, duration)
                    .SetReference(collider);

        public static Tween TweenOffset(this Collider2D collider, Vector2 to, float duration) =>
            Tweening.To(collider, (target) => target.offset, (target, value) => target.offset = value, to, duration)
                    .SetReference(collider);
    }

}
