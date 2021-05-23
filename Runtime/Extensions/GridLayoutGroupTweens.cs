using UnityEngine;
using UnityEngine.UI;

namespace Zigurous.TweenEngine
{
    public static class GridLayoutGroupTweens
    {
        public static Tween TweenSpacing(this GridLayoutGroup group, Vector2 to, float duration) =>
            Tweening.To(getter: () => group.spacing,
                        setter: spacing => group.spacing = spacing,
                        to, duration).SetTarget(group);

        public static Tween TweenCellSize(this GridLayoutGroup group, Vector2 to, float duration) =>
            Tweening.To(getter: () => group.cellSize,
                        setter: cellSize => group.cellSize = cellSize,
                        to, duration).SetTarget(group);

    }

}
