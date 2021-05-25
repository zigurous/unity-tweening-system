using UnityEngine;

namespace Zigurous.Tweening
{
    public static class FixedJoint2DTweens
    {
        public static Tween TweenDampingRatio(this FixedJoint2D joint, float to, float duration) =>
            Tweening.To(getter: () => joint.dampingRatio,
                        setter: dampingRatio => joint.dampingRatio = dampingRatio,
                        to, duration).SetTarget(joint);

        public static Tween TweenFrequency(this FixedJoint2D joint, float to, float duration) =>
            Tweening.To(getter: () => joint.frequency,
                        setter: frequency => joint.frequency = frequency,
                        to, duration).SetTarget(joint);

    }

}
