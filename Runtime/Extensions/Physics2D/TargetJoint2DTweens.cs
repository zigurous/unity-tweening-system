using UnityEngine;

namespace Zigurous.Tweening
{
    public static class TargetJoint2DTweens
    {
        public static Tween TweenAnchor(this TargetJoint2D joint, Vector2 to, float duration) =>
            Tweening.To(joint, (target) => target.anchor, (target, value) => target.anchor = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenTarget(this TargetJoint2D joint, Vector2 to, float duration) =>
            Tweening.To(joint, (target) => target.target, (target, value) => target.target = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenMaxForce(this TargetJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.maxForce, (target, value) => target.maxForce = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenDampingRatio(this TargetJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.dampingRatio, (target, value) => target.dampingRatio = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenFrequency(this TargetJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.frequency, (target, value) => target.frequency = value, to, duration)
                    .SetReference(joint);
    }

}
