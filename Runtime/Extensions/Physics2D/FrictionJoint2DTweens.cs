using UnityEngine;

namespace Zigurous.Tweening
{
    public static class FrictionJoint2DTweens
    {
        public static Tween TweenMaxForce(this FrictionJoint2D joint, float to, float duration) =>
            Tweening.To(getter: () => joint.maxForce,
                        setter: maxForce => joint.maxForce = maxForce,
                        to, duration).SetTarget(joint);

        public static Tween TweenMaxTorque(this FrictionJoint2D joint, float to, float duration) =>
            Tweening.To(getter: () => joint.maxTorque,
                        setter: maxTorque => joint.maxTorque = maxTorque,
                        to, duration).SetTarget(joint);

    }

}
