using UnityEngine;

namespace Zigurous.Tweening
{
    public static class PlatformEffector2DTweens
    {
        public static Tween TweenSurfaceArc(this PlatformEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (source) => source.surfaceArc, (source, value) => source.surfaceArc = value, to, duration)
                    .SetTarget(effector);

        public static Tween TweenSideArc(this PlatformEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (source) => source.sideArc, (source, value) => source.sideArc = value, to, duration)
                    .SetTarget(effector);

        public static Tween TweenRotationalOffset(this PlatformEffector2D effector, float to, float duration) =>
            Tweening.To(effector, (source) => source.rotationalOffset, (source, value) => source.rotationalOffset = value, to, duration)
                    .SetTarget(effector);
    }

}
