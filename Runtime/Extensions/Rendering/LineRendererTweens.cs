using UnityEngine;

namespace Zigurous.Tweening
{
    public static class LineRendererTweens
    {
        public static Tween TweenStartColor(this LineRenderer renderer, Color to, float duration) =>
            Tweening.To(renderer, (source) => source.startColor, (source, value) => source.startColor = value, to, duration)
                    .SetTarget(renderer);

        public static Tween TweenEndColor(this LineRenderer renderer, Color to, float duration) =>
            Tweening.To(renderer, (source) => source.endColor, (source, value) => source.endColor = value, to, duration)
                    .SetTarget(renderer);

        public static Tween TweenStartWidth(this LineRenderer renderer, float to, float duration) =>
            Tweening.To(renderer, (source) => source.startWidth, (source, value) => source.startWidth = value, to, duration)
                    .SetTarget(renderer);

        public static Tween TweenEndWidth(this LineRenderer renderer, float to, float duration) =>
            Tweening.To(renderer, (source) => source.endWidth, (source, value) => source.endWidth = value, to, duration)
                    .SetTarget(renderer);

        public static Tween TweenWidthMultiplier(this LineRenderer renderer, float to, float duration) =>
            Tweening.To(renderer, (source) => source.widthMultiplier, (source, value) => source.widthMultiplier = value, to, duration)
                    .SetTarget(renderer);

        public static Tween TweenShadowBias(this LineRenderer renderer, float to, float duration) =>
            Tweening.To(renderer, (source) => source.shadowBias, (source, value) => source.shadowBias = value, to, duration)
                    .SetTarget(renderer);
    }

}
