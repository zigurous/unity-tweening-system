using UnityEngine;

namespace Zigurous.Tweening
{
    public static class Joint2DTweens
    {
        public static Tween TweenBreakForce(this Joint2D joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.breakForce, (source, value) => source.breakForce = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenBreakTorque(this Joint2D joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.breakTorque, (source, value) => source.breakTorque = value, to, duration)
                    .SetTarget(joint);
    }

}
