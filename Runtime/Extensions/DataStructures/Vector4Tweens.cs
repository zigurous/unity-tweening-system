using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class Vector4Tweens
    {
        public static Tween TweenX(this Vector4 vector, float to, float duration) =>
            Tweening.To(getter: () => vector.x,
                        setter: x => vector.x = x,
                        to, duration).SetTarget(vector);

        public static Tween TweenY(this Vector4 vector, float to, float duration) =>
            Tweening.To(getter: () => vector.y,
                        setter: y => vector.y = y,
                        to, duration).SetTarget(vector);

        public static Tween TweenZ(this Vector4 vector, float to, float duration) =>
            Tweening.To(getter: () => vector.z,
                        setter: z => vector.z = z,
                        to, duration).SetTarget(vector);

        public static Tween TweenW(this Vector4 vector, float to, float duration) =>
            Tweening.To(getter: () => vector.w,
                        setter: w => vector.w = w,
                        to, duration).SetTarget(vector);

    }

}
