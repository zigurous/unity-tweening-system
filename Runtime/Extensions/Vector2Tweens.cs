using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public static class Vector2Tweens
    {
        public static Tween TweenX(this Vector2 vector, float to, float duration) =>
            Tweener.To(getter: () => vector.x,
                       setter: x => vector.x = x,
                       to, duration).SetId(vector.GetHashCode());

        public static Tween TweenY(this Vector2 vector, float to, float duration) =>
            Tweener.To(getter: () => vector.y,
                       setter: y => vector.y = y,
                       to, duration).SetId(vector.GetHashCode());

    }

}
