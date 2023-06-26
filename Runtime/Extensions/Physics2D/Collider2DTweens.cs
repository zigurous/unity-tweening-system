using UnityEngine;

namespace Zigurous.Tweening
{
    public static class Collider2DTweens
    {
        public static Tween TweenDensity(this Collider2D collider, float to, float duration) =>
            Tweening.To(collider, (source) => source.density, (source, value) => source.density = value, to, duration)
                    .SetTarget(collider);

        public static Tween TweenOffset(this Collider2D collider, Vector2 to, float duration) =>
            Tweening.To(collider, (source) => source.offset, (source, value) => source.offset = value, to, duration)
                    .SetTarget(collider);
    }

}
