using UnityEngine;

namespace Zigurous.Tweening
{
    public static class LineRendererTweens
    {
        public static Tween TweenStartColor(this LineRenderer renderer, Color to, float duration) =>
            Tweening.To(renderer, (target) => target.startColor, (target, value) => target.startColor = value, to, duration)
                    .SetReference(renderer);

        public static Tween TweenEndColor(this LineRenderer renderer, Color to, float duration) =>
            Tweening.To(renderer, (target) => target.endColor, (target, value) => target.endColor = value, to, duration)
                    .SetReference(renderer);

        public static Tween TweenStartWidth(this LineRenderer renderer, float to, float duration) =>
            Tweening.To(renderer, (target) => target.startWidth, (target, value) => target.startWidth = value, to, duration)
                    .SetReference(renderer);

        public static Tween TweenEndWidth(this LineRenderer renderer, float to, float duration) =>
            Tweening.To(renderer, (target) => target.endWidth, (target, value) => target.endWidth = value, to, duration)
                    .SetReference(renderer);

        public static Tween TweenWidthMultiplier(this LineRenderer renderer, float to, float duration) =>
            Tweening.To(renderer, (target) => target.widthMultiplier, (target, value) => target.widthMultiplier = value, to, duration)
                    .SetReference(renderer);

        public static Tween TweenShadowBias(this LineRenderer renderer, float to, float duration) =>
            Tweening.To(renderer, (target) => target.shadowBias, (target, value) => target.shadowBias = value, to, duration)
                    .SetReference(renderer);
    }

}
