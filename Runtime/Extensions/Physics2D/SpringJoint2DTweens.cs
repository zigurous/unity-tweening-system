using UnityEngine;

namespace Zigurous.Tweening
{
    public static class SpringJoint2DTweens
    {
        public static Tween TweenDistance(this SpringJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.distance, (target, value) => target.distance = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenDampingRatio(this SpringJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.dampingRatio, (target, value) => target.dampingRatio = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenFrequency(this SpringJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.frequency, (target, value) => target.frequency = value, to, duration)
                    .SetReference(joint);
    }

}
