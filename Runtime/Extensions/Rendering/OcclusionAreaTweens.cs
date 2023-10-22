using UnityEngine;

namespace Zigurous.Tweening
{
    public static class OcclusionAreaTweens
    {
        public static Tween TweenCenter(this OcclusionArea area, Vector3 to, float duration) =>
            Tweening.To(area, (target) => target.center, (target, value) => target.center = value, to, duration)
                    .SetReference(area);

        public static Tween TweenSize(this OcclusionArea area, Vector3 to, float duration) =>
            Tweening.To(area, (target) => target.size, (target, value) => target.size = value, to, duration)
                    .SetReference(area);
    }

}
