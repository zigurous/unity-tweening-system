using UnityEngine;

namespace Zigurous.Tweening
{
    public static class SpringJoint2DTweens
    {
        public static Tween TweenDistance(this SpringJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.distance, (source, value) => source.distance = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenDampingRatio(this SpringJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.dampingRatio, (source, value) => source.dampingRatio = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenFrequency(this SpringJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.frequency, (source, value) => source.frequency = value, to, duration)
                    .SetTarget(joint);
    }

}
