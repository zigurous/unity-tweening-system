using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class OcclusionAreaTweens
    {
        public static Tween TweenCenter(this OcclusionArea area, Vector3 to, float duration) =>
            Tweening.To(getter: () => area.center,
                        setter: center => area.center = center,
                        to, duration).SetTarget(area);

        public static Tween TweenSize(this OcclusionArea area, Vector3 to, float duration) =>
            Tweening.To(getter: () => area.size,
                        setter: size => area.size = size,
                        to, duration).SetTarget(area);

    }

}
