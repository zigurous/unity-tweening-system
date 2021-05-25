using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class Collider2DTweens
    {
        public static Tween TweenDensity(this Collider2D collider, float to, float duration) =>
            Tweening.To(getter: () => collider.density,
                        setter: density => collider.density = density,
                        to, duration).SetTarget(collider);

        public static Tween TweenOffset(this Collider2D collider, Vector2 to, float duration) =>
            Tweening.To(getter: () => collider.offset,
                        setter: offset => collider.offset = offset,
                        to, duration).SetTarget(collider);

    }

}
