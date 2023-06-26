using UnityEngine;

namespace Zigurous.Tweening
{
    public static class OcclusionAreaTweens
    {
        public static Tween TweenCenter(this OcclusionArea area, Vector3 to, float duration) =>
            Tweening.To(area, (source) => source.center, (source, value) => source.center = value, to, duration)
                    .SetTarget(area);

        public static Tween TweenSize(this OcclusionArea area, Vector3 to, float duration) =>
            Tweening.To(area, (source) => source.size, (source, value) => source.size = value, to, duration)
                    .SetTarget(area);
    }

}
