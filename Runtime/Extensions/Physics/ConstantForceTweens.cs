using UnityEngine;

namespace Zigurous.Tweening
{
    public static class ConstantForceTweens
    {
        public static Tween TweenForce(this ConstantForce constantForce, Vector3 to, float duration) =>
            Tweening.To(constantForce, (source) => source.force, (source, value) => source.force = value, to, duration)
                    .SetTarget(constantForce);

        public static Tween TweenRelativeForce(this ConstantForce constantForce, Vector3 to, float duration) =>
            Tweening.To(constantForce, (source) => source.relativeForce, (source, value) => source.relativeForce = value, to, duration)
                    .SetTarget(constantForce);

        public static Tween TweenTorque(this ConstantForce constantForce, Vector3 to, float duration) =>
            Tweening.To(constantForce, (source) => source.torque, (source, value) => source.torque = value, to, duration)
                    .SetTarget(constantForce);

        public static Tween TweenRelativeTorque(this ConstantForce constantForce, Vector3 to, float duration) =>
            Tweening.To(constantForce, (source) => source.relativeTorque, (source, value) => source.relativeTorque = value, to, duration)
                    .SetTarget(constantForce);
    }

}
