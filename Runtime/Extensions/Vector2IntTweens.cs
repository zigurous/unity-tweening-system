using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class Vector2IntTweens
    {
        public static Tween TweenX(this Vector2Int vector, int to, float duration) =>
            Tweening.To(getter: () => vector.x,
                        setter: x => vector.x = x,
                        to, duration).SetTarget(vector);

        public static Tween TweenY(this Vector2Int vector, int to, float duration) =>
            Tweening.To(getter: () => vector.y,
                        setter: y => vector.y = y,
                        to, duration).SetTarget(vector);

    }

}
