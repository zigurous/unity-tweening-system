using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class TreeInstanceTweens
    {
        public static Tween TweenPosition(this TreeInstance tree, Vector3 to, float duration) =>
            Tweening.To(getter: () => tree.position,
                        setter: position => tree.position = position,
                        to, duration).SetTarget(tree);

        public static Tween TweenRotation(this TreeInstance tree, float to, float duration) =>
            Tweening.To(getter: () => tree.rotation,
                        setter: rotation => tree.rotation = rotation,
                        to, duration).SetTarget(tree);

        public static Tween TweenWidthScale(this TreeInstance tree, float to, float duration) =>
            Tweening.To(getter: () => tree.widthScale,
                        setter: widthScale => tree.widthScale = widthScale,
                        to, duration).SetTarget(tree);

        public static Tween TweenHeightScale(this TreeInstance tree, float to, float duration) =>
            Tweening.To(getter: () => tree.heightScale,
                        setter: heightScale => tree.heightScale = heightScale,
                        to, duration).SetTarget(tree);

        public static Tween TweenColor(this TreeInstance tree, Color32 to, float duration) =>
            Tweening.To(getter: () => tree.color,
                        setter: color => tree.color = color,
                        to, duration).SetTarget(tree);

        public static Tween TweenLightmapColor(this TreeInstance tree, Color32 to, float duration) =>
            Tweening.To(getter: () => tree.lightmapColor,
                        setter: lightmapColor => tree.lightmapColor = lightmapColor,
                        to, duration).SetTarget(tree);

    }

}
