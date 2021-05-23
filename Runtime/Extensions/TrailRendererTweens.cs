using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class TrailRendererTweens
    {
        public static Tween TweenTime(this TrailRenderer renderer, float to, float duration) =>
            Tweening.To(getter: () => renderer.time,
                        setter: time => renderer.time = time,
                        to, duration).SetTarget(renderer);

        public static Tween TweenStartColor(this TrailRenderer renderer, Color to, float duration) =>
            Tweening.To(getter: () => renderer.startColor,
                        setter: startColor => renderer.startColor = startColor,
                        to, duration).SetTarget(renderer);

        public static Tween TweenEndColor(this TrailRenderer renderer, Color to, float duration) =>
            Tweening.To(getter: () => renderer.endColor,
                        setter: endColor => renderer.endColor = endColor,
                        to, duration).SetTarget(renderer);

        public static Tween TweenStartWidth(this TrailRenderer renderer, float to, float duration) =>
            Tweening.To(getter: () => renderer.startWidth,
                        setter: startWidth => renderer.startWidth = startWidth,
                        to, duration).SetTarget(renderer);

        public static Tween TweenEndWidth(this TrailRenderer renderer, float to, float duration) =>
            Tweening.To(getter: () => renderer.endWidth,
                        setter: endWidth => renderer.endWidth = endWidth,
                        to, duration).SetTarget(renderer);

        public static Tween TweenWidthMultiplier(this TrailRenderer renderer, float to, float duration) =>
            Tweening.To(getter: () => renderer.widthMultiplier,
                        setter: widthMultiplier => renderer.widthMultiplier = widthMultiplier,
                        to, duration).SetTarget(renderer);

        public static Tween TweenShadowBias(this TrailRenderer renderer, float to, float duration) =>
            Tweening.To(getter: () => renderer.shadowBias,
                        setter: shadowBias => renderer.shadowBias = shadowBias,
                        to, duration).SetTarget(renderer);

        public static Tween TweenMinVertexDistance(this TrailRenderer renderer, float to, float duration) =>
            Tweening.To(getter: () => renderer.minVertexDistance,
                        setter: minVertexDistance => renderer.minVertexDistance = minVertexDistance,
                        to, duration).SetTarget(renderer);

    }

}
