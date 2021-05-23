using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class JointTweens
    {
        public static Tween TweenAxis(this Joint joint, Vector3 to, float duration) =>
            Tweening.To(getter: () => joint.axis,
                        setter: axis => joint.axis = axis,
                        to, duration).SetTarget(joint);

        public static Tween TweenAnchor(this Joint joint, Vector3 to, float duration) =>
            Tweening.To(getter: () => joint.anchor,
                        setter: anchor => joint.anchor = anchor,
                        to, duration).SetTarget(joint);

        public static Tween TweenConnectedAnchor(this Joint joint, Vector3 to, float duration) =>
            Tweening.To(getter: () => joint.connectedAnchor,
                        setter: connectedAnchor => joint.connectedAnchor = connectedAnchor,
                        to, duration).SetTarget(joint);

        public static Tween TweenBreakForce(this Joint joint, float to, float duration) =>
            Tweening.To(getter: () => joint.breakForce,
                        setter: breakForce => joint.breakForce = breakForce,
                        to, duration).SetTarget(joint);

        public static Tween TweenBreakTorque(this Joint joint, float to, float duration) =>
            Tweening.To(getter: () => joint.breakTorque,
                        setter: breakTorque => joint.breakTorque = breakTorque,
                        to, duration).SetTarget(joint);

        public static Tween TweenMassScale(this Joint joint, float to, float duration) =>
            Tweening.To(getter: () => joint.massScale,
                        setter: massScale => joint.massScale = massScale,
                        to, duration).SetTarget(joint);

        public static Tween TweenConnectedMassScale(this Joint joint, float to, float duration) =>
            Tweening.To(getter: () => joint.connectedMassScale,
                        setter: connectedMassScale => joint.connectedMassScale = connectedMassScale,
                        to, duration).SetTarget(joint);

    }

}
