using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class ConstantForce2DTweens
    {
        public static Tween TweenForce(this ConstantForce2D constantForce, Vector2 to, float duration) =>
            Tweening.To(getter: () => constantForce.force,
                        setter: force => constantForce.force = force,
                        to, duration).SetTarget(constantForce);

        public static Tween TweenRelativeForce(this ConstantForce2D constantForce, Vector2 to, float duration) =>
            Tweening.To(getter: () => constantForce.relativeForce,
                        setter: relativeForce => constantForce.relativeForce = relativeForce,
                        to, duration).SetTarget(constantForce);

        public static Tween TweenTorque(this ConstantForce2D constantForce, float to, float duration) =>
            Tweening.To(getter: () => constantForce.torque,
                        setter: torque => constantForce.torque = torque,
                        to, duration).SetTarget(constantForce);

    }

}
