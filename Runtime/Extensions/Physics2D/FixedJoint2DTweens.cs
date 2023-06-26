using UnityEngine;

namespace Zigurous.Tweening
{
    public static class FixedJoint2DTweens
    {
        public static Tween TweenDampingRatio(this FixedJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.dampingRatio, (source, value) => source.dampingRatio = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenFrequency(this FixedJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.frequency, (source, value) => source.frequency = value, to, duration)
                    .SetTarget(joint);
    }

}
