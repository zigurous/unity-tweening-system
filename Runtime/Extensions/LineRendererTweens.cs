using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public static class LineRendererTweens
    {
        public static Tween TweenStartColor(this LineRenderer renderer, Color to, float duration) =>
            Tweener.To(getter: () => renderer.startColor,
                       setter: startColor => renderer.startColor = startColor,
                       to, duration).SetTarget(renderer);

        public static Tween TweenEndColor(this LineRenderer renderer, Color to, float duration) =>
            Tweener.To(getter: () => renderer.endColor,
                       setter: endColor => renderer.endColor = endColor,
                       to, duration).SetTarget(renderer);

        public static Tween TweenStartWidth(this LineRenderer renderer, float to, float duration) =>
            Tweener.To(getter: () => renderer.startWidth,
                       setter: startWidth => renderer.startWidth = startWidth,
                       to, duration).SetTarget(renderer);

        public static Tween TweenEndWidth(this LineRenderer renderer, float to, float duration) =>
            Tweener.To(getter: () => renderer.endWidth,
                       setter: endWidth => renderer.endWidth = endWidth,
                       to, duration).SetTarget(renderer);

        public static Tween TweenWidthMultiplier(this LineRenderer renderer, float to, float duration) =>
            Tweener.To(getter: () => renderer.widthMultiplier,
                       setter: widthMultiplier => renderer.widthMultiplier = widthMultiplier,
                       to, duration).SetTarget(renderer);

        public static Tween TweenShadowBias(this LineRenderer renderer, float to, float duration) =>
            Tweener.To(getter: () => renderer.shadowBias,
                       setter: shadowBias => renderer.shadowBias = shadowBias,
                       to, duration).SetTarget(renderer);

    }

}
