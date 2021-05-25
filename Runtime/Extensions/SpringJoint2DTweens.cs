using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class SpringJoint2DTweens
    {
        public static Tween TweenDistance(this SpringJoint2D joint, float to, float duration) =>
            Tweening.To(getter: () => joint.distance,
                        setter: distance => joint.distance = distance,
                        to, duration).SetTarget(joint);

        public static Tween TweenDampingRatio(this SpringJoint2D joint, float to, float duration) =>
            Tweening.To(getter: () => joint.dampingRatio,
                        setter: dampingRatio => joint.dampingRatio = dampingRatio,
                        to, duration).SetTarget(joint);

        public static Tween TweenFrequency(this SpringJoint2D joint, float to, float duration) =>
            Tweening.To(getter: () => joint.frequency,
                        setter: frequency => joint.frequency = frequency,
                        to, duration).SetTarget(joint);

    }

}
