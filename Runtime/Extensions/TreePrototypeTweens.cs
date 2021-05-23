using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class TreePrototypeTweens
    {
        public static Tween TweenTileSize(this TreePrototype prototype, float to, float duration) =>
            Tweening.To(getter: () => prototype.bendFactor,
                        setter: bendFactor => prototype.bendFactor = bendFactor,
                        to, duration).SetTarget(prototype);

    }

}
