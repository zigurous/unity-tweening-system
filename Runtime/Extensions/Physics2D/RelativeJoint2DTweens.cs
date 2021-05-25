using UnityEngine;

namespace Zigurous.Tweening
{
    public static class RelativeJoint2DTweens
    {
        public static Tween TweenMaxForce(this RelativeJoint2D joint, float to, float duration) =>
            Tweening.To(getter: () => joint.maxForce,
                        setter: maxForce => joint.maxForce = maxForce,
                        to, duration).SetTarget(joint);

        public static Tween TweenMaxTorque(this RelativeJoint2D joint, float to, float duration) =>
            Tweening.To(getter: () => joint.maxTorque,
                        setter: maxTorque => joint.maxTorque = maxTorque,
                        to, duration).SetTarget(joint);

        public static Tween TweenCorrectionScale(this RelativeJoint2D joint, float to, float duration) =>
            Tweening.To(getter: () => joint.correctionScale,
                        setter: correctionScale => joint.correctionScale = correctionScale,
                        to, duration).SetTarget(joint);

        public static Tween TweenLinearOffset(this RelativeJoint2D joint, Vector2 to, float duration) =>
            Tweening.To(getter: () => joint.linearOffset,
                        setter: linearOffset => joint.linearOffset = linearOffset,
                        to, duration).SetTarget(joint);

        public static Tween TweenAngularOffset(this RelativeJoint2D joint, float to, float duration) =>
            Tweening.To(getter: () => joint.angularOffset,
                        setter: angularOffset => joint.angularOffset = angularOffset,
                        to, duration).SetTarget(joint);

    }

}
