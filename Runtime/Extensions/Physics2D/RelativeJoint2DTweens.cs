using UnityEngine;

namespace Zigurous.Tweening
{
    public static class RelativeJoint2DTweens
    {
        public static Tween TweenMaxForce(this RelativeJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.maxForce, (target, value) => target.maxForce = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenMaxTorque(this RelativeJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.maxTorque, (target, value) => target.maxTorque = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenCorrectionScale(this RelativeJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.correctionScale, (target, value) => target.correctionScale = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenLinearOffset(this RelativeJoint2D joint, Vector2 to, float duration) =>
            Tweening.To(joint, (target) => target.linearOffset, (target, value) => target.linearOffset = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenAngularOffset(this RelativeJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.angularOffset, (target, value) => target.angularOffset = value, to, duration)
                    .SetReference(joint);
    }

}
