using UnityEngine;

namespace Zigurous.Tweening
{
    public static class Joint2DTweens
    {
        public static Tween TweenBreakForce(this Joint2D joint, float to, float duration) =>
            Tweening.To(getter: () => joint.breakForce,
                        setter: breakForce => joint.breakForce = breakForce,
                        to, duration).SetTarget(joint);

        public static Tween TweenBreakTorque(this Joint2D joint, float to, float duration) =>
            Tweening.To(getter: () => joint.breakTorque,
                        setter: breakTorque => joint.breakTorque = breakTorque,
                        to, duration).SetTarget(joint);

    }

}
