using UnityEngine;
using UnityEngine.UI;

namespace Zigurous.Tweening
{
    public static class GridLayoutGroupTweens
    {
        public static Tween TweenSpacing(this GridLayoutGroup layoutGroup, Vector2 to, float duration) =>
            Tweening.To(getter: () => layoutGroup.spacing,
                        setter: spacing => layoutGroup.spacing = spacing,
                        to, duration).SetTarget(layoutGroup);

        public static Tween TweenCellSize(this GridLayoutGroup layoutGroup, Vector2 to, float duration) =>
            Tweening.To(getter: () => layoutGroup.cellSize,
                        setter: cellSize => layoutGroup.cellSize = cellSize,
                        to, duration).SetTarget(layoutGroup);

    }

}
