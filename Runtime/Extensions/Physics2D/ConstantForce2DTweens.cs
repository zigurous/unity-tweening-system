using UnityEngine;

namespace Zigurous.Tweening
{
    public static class ConstantForce2DTweens
    {
        public static Tween TweenForce(this ConstantForce2D constantForce, Vector2 to, float duration) =>
            Tweening.To(constantForce, (target) => target.force, (target, value) => target.force = value, to, duration)
                    .SetReference(constantForce);

        public static Tween TweenRelativeForce(this ConstantForce2D constantForce, Vector2 to, float duration) =>
            Tweening.To(constantForce, (target) => target.relativeForce, (target, value) => target.relativeForce = value, to, duration)
                    .SetReference(constantForce);

        public static Tween TweenTorque(this ConstantForce2D constantForce, float to, float duration) =>
            Tweening.To(constantForce, (target) => target.torque, (target, value) => target.torque = value, to, duration)
                    .SetReference(constantForce);
    }

}
