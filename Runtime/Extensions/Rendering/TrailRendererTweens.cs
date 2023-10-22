using UnityEngine;

namespace Zigurous.Tweening
{
    public static class TrailRendererTweens
    {
        public static Tween TweenTime(this TrailRenderer renderer, float to, float duration) =>
            Tweening.To(renderer, (target) => target.time, (target, value) => target.time = value, to, duration)
                    .SetReference(renderer);

        public static Tween TweenStartColor(this TrailRenderer renderer, Color to, float duration) =>
            Tweening.To(renderer, (target) => target.startColor, (target, value) => target.startColor = value, to, duration)
                    .SetReference(renderer);

        public static Tween TweenEndColor(this TrailRenderer renderer, Color to, float duration) =>
            Tweening.To(renderer, (target) => target.endColor, (target, value) => target.endColor = value, to, duration)
                    .SetReference(renderer);

        public static Tween TweenStartWidth(this TrailRenderer renderer, float to, float duration) =>
            Tweening.To(renderer, (target) => target.startWidth, (target, value) => target.startWidth = value, to, duration)
                    .SetReference(renderer);

        public static Tween TweenEndWidth(this TrailRenderer renderer, float to, float duration) =>
            Tweening.To(renderer, (target) => target.endWidth, (target, value) => target.endWidth = value, to, duration)
                    .SetReference(renderer);

        public static Tween TweenWidthMultiplier(this TrailRenderer renderer, float to, float duration) =>
            Tweening.To(renderer, (target) => target.widthMultiplier, (target, value) => target.widthMultiplier = value, to, duration)
                    .SetReference(renderer);

        public static Tween TweenShadowBias(this TrailRenderer renderer, float to, float duration) =>
            Tweening.To(renderer, (target) => target.shadowBias, (target, value) => target.shadowBias = value, to, duration)
                    .SetReference(renderer);

        public static Tween TweenMinVertexDistance(this TrailRenderer renderer, float to, float duration) =>
            Tweening.To(renderer, (target) => target.minVertexDistance, (target, value) => target.minVertexDistance = value, to, duration)
                    .SetReference(renderer);
    }

}
