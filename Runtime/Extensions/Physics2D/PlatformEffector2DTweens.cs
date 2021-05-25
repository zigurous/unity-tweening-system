using UnityEngine;

namespace Zigurous.Tweening
{
    public static class PlatformEffector2DTweens
    {
        public static Tween TweenSurfaceArc(this PlatformEffector2D effector, float to, float duration) =>
            Tweening.To(getter: () => effector.surfaceArc,
                        setter: surfaceArc => effector.surfaceArc = surfaceArc,
                        to, duration).SetTarget(effector);

        public static Tween TweenSideArc(this PlatformEffector2D effector, float to, float duration) =>
            Tweening.To(getter: () => effector.sideArc,
                        setter: sideArc => effector.sideArc = sideArc,
                        to, duration).SetTarget(effector);

        public static Tween TweenRotationalOffset(this PlatformEffector2D effector, float to, float duration) =>
            Tweening.To(getter: () => effector.rotationalOffset,
                        setter: rotationalOffset => effector.rotationalOffset = rotationalOffset,
                        to, duration).SetTarget(effector);

    }

}
