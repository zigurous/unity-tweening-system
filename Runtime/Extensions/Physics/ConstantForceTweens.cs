using UnityEngine;

namespace Zigurous.Tweening
{
    public static class ConstantForceTweens
    {
        public static Tween TweenForce(this ConstantForce constantForce, Vector3 to, float duration) =>
            Tweening.To(constantForce, (target) => target.force, (target, value) => target.force = value, to, duration)
                    .SetReference(constantForce);

        public static Tween TweenRelativeForce(this ConstantForce constantForce, Vector3 to, float duration) =>
            Tweening.To(constantForce, (target) => target.relativeForce, (target, value) => target.relativeForce = value, to, duration)
                    .SetReference(constantForce);

        public static Tween TweenTorque(this ConstantForce constantForce, Vector3 to, float duration) =>
            Tweening.To(constantForce, (target) => target.torque, (target, value) => target.torque = value, to, duration)
                    .SetReference(constantForce);

        public static Tween TweenRelativeTorque(this ConstantForce constantForce, Vector3 to, float duration) =>
            Tweening.To(constantForce, (target) => target.relativeTorque, (target, value) => target.relativeTorque = value, to, duration)
                    .SetReference(constantForce);
    }

}
