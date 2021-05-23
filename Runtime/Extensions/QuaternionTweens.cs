using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class QuaternionTweens
    {
        public static Tween TweenX(this Quaternion quaternion, float to, float duration) =>
            Tweening.To(getter: () => quaternion.x,
                        setter: x => quaternion.x = x,
                        to, duration).SetTarget(quaternion);

        public static Tween TweenY(this Quaternion quaternion, float to, float duration) =>
            Tweening.To(getter: () => quaternion.y,
                        setter: y => quaternion.y = y,
                        to, duration).SetTarget(quaternion);

        public static Tween TweenZ(this Quaternion quaternion, float to, float duration) =>
            Tweening.To(getter: () => quaternion.z,
                        setter: z => quaternion.z = z,
                        to, duration).SetTarget(quaternion);

        public static Tween TweenW(this Quaternion quaternion, float to, float duration) =>
            Tweening.To(getter: () => quaternion.w,
                        setter: w => quaternion.w = w,
                        to, duration).SetTarget(quaternion);

        public static Tween TweenEulerAngles(this Quaternion quaternion, Vector3 to, float duration) =>
            Tweening.To(getter: () => quaternion.eulerAngles,
                        setter: eulerAngles => quaternion.eulerAngles = eulerAngles,
                        to, duration).SetTarget(quaternion);

    }

}
