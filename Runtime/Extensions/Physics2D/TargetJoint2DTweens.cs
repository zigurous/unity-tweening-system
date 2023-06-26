using UnityEngine;

namespace Zigurous.Tweening
{
    public static class TargetJoint2DTweens
    {
        public static Tween TweenAnchor(this TargetJoint2D joint, Vector2 to, float duration) =>
            Tweening.To(joint, (source) => source.anchor, (source, value) => source.anchor = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenTarget(this TargetJoint2D joint, Vector2 to, float duration) =>
            Tweening.To(joint, (source) => source.target, (source, value) => source.target = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenMaxForce(this TargetJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.maxForce, (source, value) => source.maxForce = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenDampingRatio(this TargetJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.dampingRatio, (source, value) => source.dampingRatio = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenFrequency(this TargetJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.frequency, (source, value) => source.frequency = value, to, duration)
                    .SetTarget(joint);
    }

}
