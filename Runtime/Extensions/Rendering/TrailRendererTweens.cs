using UnityEngine;

namespace Zigurous.Tweening
{
    public static class TrailRendererTweens
    {
        public static Tween TweenTime(this TrailRenderer renderer, float to, float duration) =>
            Tweening.To(renderer, (source) => source.time, (source, value) => source.time = value, to, duration)
                    .SetTarget(renderer);

        public static Tween TweenStartColor(this TrailRenderer renderer, Color to, float duration) =>
            Tweening.To(renderer, (source) => source.startColor, (source, value) => source.startColor = value, to, duration)
                    .SetTarget(renderer);

        public static Tween TweenEndColor(this TrailRenderer renderer, Color to, float duration) =>
            Tweening.To(renderer, (source) => source.endColor, (source, value) => source.endColor = value, to, duration)
                    .SetTarget(renderer);

        public static Tween TweenStartWidth(this TrailRenderer renderer, float to, float duration) =>
            Tweening.To(renderer, (source) => source.startWidth, (source, value) => source.startWidth = value, to, duration)
                    .SetTarget(renderer);

        public static Tween TweenEndWidth(this TrailRenderer renderer, float to, float duration) =>
            Tweening.To(renderer, (source) => source.endWidth, (source, value) => source.endWidth = value, to, duration)
                    .SetTarget(renderer);

        public static Tween TweenWidthMultiplier(this TrailRenderer renderer, float to, float duration) =>
            Tweening.To(renderer, (source) => source.widthMultiplier, (source, value) => source.widthMultiplier = value, to, duration)
                    .SetTarget(renderer);

        public static Tween TweenShadowBias(this TrailRenderer renderer, float to, float duration) =>
            Tweening.To(renderer, (source) => source.shadowBias, (source, value) => source.shadowBias = value, to, duration)
                    .SetTarget(renderer);

        public static Tween TweenMinVertexDistance(this TrailRenderer renderer, float to, float duration) =>
            Tweening.To(renderer, (source) => source.minVertexDistance, (source, value) => source.minVertexDistance = value, to, duration)
                    .SetTarget(renderer);
    }

}
