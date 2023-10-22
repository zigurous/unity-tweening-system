using UnityEngine;

namespace Zigurous.Tweening
{
    public static class FrictionJoint2DTweens
    {
        public static Tween TweenMaxForce(this FrictionJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.maxForce, (target, value) => target.maxForce = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenMaxTorque(this FrictionJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.maxTorque, (target, value) => target.maxTorque = value, to, duration)
                    .SetReference(joint);
    }

}
