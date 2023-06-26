using UnityEngine;

namespace Zigurous.Tweening
{
    public static class ConstantForce2DTweens
    {
        public static Tween TweenForce(this ConstantForce2D constantForce, Vector2 to, float duration) =>
            Tweening.To(constantForce, (source) => source.force, (source, value) => source.force = value, to, duration)
                    .SetTarget(constantForce);

        public static Tween TweenRelativeForce(this ConstantForce2D constantForce, Vector2 to, float duration) =>
            Tweening.To(constantForce, (source) => source.relativeForce, (source, value) => source.relativeForce = value, to, duration)
                    .SetTarget(constantForce);

        public static Tween TweenTorque(this ConstantForce2D constantForce, float to, float duration) =>
            Tweening.To(constantForce, (source) => source.torque, (source, value) => source.torque = value, to, duration)
                    .SetTarget(constantForce);
    }

}
