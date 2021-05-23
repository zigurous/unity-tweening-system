using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public static class Vector3IntTweens
    {
        public static Tween TweenX(this Vector3Int vector, int to, float duration) =>
            Tweener.To(getter: () => vector.x,
                       setter: x => vector.x = x,
                       to, duration).SetTarget(vector);

        public static Tween TweenY(this Vector3Int vector, int to, float duration) =>
            Tweener.To(getter: () => vector.y,
                       setter: y => vector.y = y,
                       to, duration).SetTarget(vector);

        public static Tween TweenZ(this Vector3Int vector, int to, float duration) =>
            Tweener.To(getter: () => vector.z,
                       setter: z => vector.z = z,
                       to, duration).SetTarget(vector);

    }

}
