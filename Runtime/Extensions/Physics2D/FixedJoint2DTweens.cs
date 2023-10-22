using UnityEngine;

namespace Zigurous.Tweening
{
    public static class FixedJoint2DTweens
    {
        public static Tween TweenDampingRatio(this FixedJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.dampingRatio, (target, value) => target.dampingRatio = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenFrequency(this FixedJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.frequency, (target, value) => target.frequency = value, to, duration)
                    .SetReference(joint);
    }

}
