using UnityEngine;

namespace Zigurous.Tweening
{
    public static class ConstantForceTweens
    {
        public static Tween TweenForce(this ConstantForce constantForce, Vector3 to, float duration) =>
            Tweening.To(getter: () => constantForce.force,
                        setter: force => constantForce.force = force,
                        to, duration).SetTarget(constantForce);

        public static Tween TweenRelativeForce(this ConstantForce constantForce, Vector3 to, float duration) =>
            Tweening.To(getter: () => constantForce.relativeForce,
                        setter: relativeForce => constantForce.relativeForce = relativeForce,
                        to, duration).SetTarget(constantForce);

        public static Tween TweenTorque(this ConstantForce constantForce, Vector3 to, float duration) =>
            Tweening.To(getter: () => constantForce.torque,
                        setter: torque => constantForce.torque = torque,
                        to, duration).SetTarget(constantForce);

        public static Tween TweenRelativeTorque(this ConstantForce constantForce, Vector3 to, float duration) =>
            Tweening.To(getter: () => constantForce.relativeTorque,
                        setter: relativeTorque => constantForce.relativeTorque = relativeTorque,
                        to, duration).SetTarget(constantForce);

    }

}
