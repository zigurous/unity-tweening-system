using UnityEngine;

namespace Zigurous.Tweening
{
    public static class FrictionJoint2DTweens
    {
        public static Tween TweenMaxForce(this FrictionJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.maxForce, (source, value) => source.maxForce = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenMaxTorque(this FrictionJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.maxTorque, (source, value) => source.maxTorque = value, to, duration)
                    .SetTarget(joint);
    }

}
