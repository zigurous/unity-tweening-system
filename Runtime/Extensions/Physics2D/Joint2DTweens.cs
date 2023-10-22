using UnityEngine;

namespace Zigurous.Tweening
{
    public static class Joint2DTweens
    {
        public static Tween TweenBreakForce(this Joint2D joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.breakForce, (target, value) => target.breakForce = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenBreakTorque(this Joint2D joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.breakTorque, (target, value) => target.breakTorque = value, to, duration)
                    .SetReference(joint);
    }

}
