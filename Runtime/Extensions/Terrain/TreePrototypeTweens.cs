using UnityEngine;

namespace Zigurous.Tweening
{
    public static class TreePrototypeTweens
    {
        public static Tween TweenTileSize(this TreePrototype tree, float to, float duration) =>
            Tweening.To(getter: () => tree.bendFactor,
                        setter: bendFactor => tree.bendFactor = bendFactor,
                        to, duration).SetTarget(tree);

    }

}
