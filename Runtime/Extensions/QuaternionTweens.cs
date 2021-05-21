using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public static class QuaternionTweens
    {
        public static Tween TweenX(this Quaternion quaternion, float to, float duration) =>
            Tweener.To(getter: () => quaternion.x,
                       setter: x => quaternion.x = x,
                       to, duration).SetId(quaternion.GetHashCode());

        public static Tween TweenY(this Quaternion quaternion, float to, float duration) =>
            Tweener.To(getter: () => quaternion.y,
                       setter: y => quaternion.y = y,
                       to, duration).SetId(quaternion.GetHashCode());

        public static Tween TweenZ(this Quaternion quaternion, float to, float duration) =>
            Tweener.To(getter: () => quaternion.z,
                       setter: z => quaternion.z = z,
                       to, duration).SetId(quaternion.GetHashCode());

        public static Tween TweenW(this Quaternion quaternion, float to, float duration) =>
            Tweener.To(getter: () => quaternion.w,
                       setter: w => quaternion.w = w,
                       to, duration).SetId(quaternion.GetHashCode());

        public static Tween TweenEulerAngles(this Quaternion quaternion, Vector3 to, float duration) =>
            Tweener.To(getter: () => quaternion.eulerAngles,
                       setter: eulerAngles => quaternion.eulerAngles = eulerAngles,
                       to, duration).SetId(quaternion.GetHashCode());

    }

}
