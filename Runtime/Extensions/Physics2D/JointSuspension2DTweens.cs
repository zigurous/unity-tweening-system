using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class JointSuspension2DTweens
    {
        public static Tween TweenDampingRatio(this JointSuspension2D suspension, float to, float duration) =>
            Tweening.To(getter: () => suspension.dampingRatio,
                        setter: dampingRatio => suspension.dampingRatio = dampingRatio,
                        to, duration).SetTarget(suspension);

        public static Tween TweenFrequency(this JointSuspension2D suspension, float to, float duration) =>
            Tweening.To(getter: () => suspension.frequency,
                        setter: frequency => suspension.frequency = frequency,
                        to, duration).SetTarget(suspension);

        public static Tween TweenAngle(this JointSuspension2D suspension, float to, float duration) =>
            Tweening.To(getter: () => suspension.angle,
                        setter: angle => suspension.angle = angle,
                        to, duration).SetTarget(suspension);

    }

}
