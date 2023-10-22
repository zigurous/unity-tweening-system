using UnityEngine;

namespace Zigurous.Tweening
{
    public static class PlatformEffector2DTweens
    {
        public static Tween TweenSurfaceArc(this PlatformEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (target) => target.surfaceArc, (target, value) => target.surfaceArc = value, to, duration)
                    .SetReference(effector);

        public static Tween TweenSideArc(this PlatformEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (target) => target.sideArc, (target, value) => target.sideArc = value, to, duration)
                    .SetReference(effector);

        public static Tween TweenRotationalOffset(this PlatformEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (target) => target.rotationalOffset, (target, value) => target.rotationalOffset = value, to, duration)
                    .SetReference(effector);
    }

}
