using UnityEngine;

namespace Zigurous.Tweening
{
    public static class RelativeJoint2DTweens
    {
        public static Tween TweenMaxForce(this RelativeJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.maxForce, (source, value) => source.maxForce = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenMaxTorque(this RelativeJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.maxTorque, (source, value) => source.maxTorque = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenCorrectionScale(this RelativeJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.correctionScale, (source, value) => source.correctionScale = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenLinearOffset(this RelativeJoint2D joint, Vector2 to, float duration) =>
            Tweening.To(joint, (source) => source.linearOffset, (source, value) => source.linearOffset = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenAngularOffset(this RelativeJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.angularOffset, (source, value) => source.angularOffset = value, to, duration)
                    .SetTarget(joint);
    }

}
