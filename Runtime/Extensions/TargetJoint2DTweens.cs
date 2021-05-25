using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class TargetJoint2DTweens
    {
        public static Tween TweenAnchor(this TargetJoint2D joint, Vector2 to, float duration) =>
            Tweening.To(getter: () => joint.anchor,
                        setter: anchor => joint.anchor = anchor,
                        to, duration).SetTarget(joint);

        public static Tween TweenTarget(this TargetJoint2D joint, Vector2 to, float duration) =>
            Tweening.To(getter: () => joint.target,
                        setter: target => joint.target = target,
                        to, duration).SetTarget(joint);

        public static Tween TweenMaxForce(this TargetJoint2D joint, float to, float duration) =>
            Tweening.To(getter: () => joint.maxForce,
                        setter: maxForce => joint.maxForce = maxForce,
                        to, duration).SetTarget(joint);

        public static Tween TweenDampingRatio(this TargetJoint2D joint, float to, float duration) =>
            Tweening.To(getter: () => joint.dampingRatio,
                        setter: dampingRatio => joint.dampingRatio = dampingRatio,
                        to, duration).SetTarget(joint);

        public static Tween TweenFrequency(this TargetJoint2D joint, float to, float duration) =>
            Tweening.To(getter: () => joint.frequency,
                        setter: frequency => joint.frequency = frequency,
                        to, duration).SetTarget(joint);

    }

}
