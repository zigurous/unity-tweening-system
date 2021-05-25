using UnityEngine;

namespace Zigurous.Tweening
{
    public static class GridTweens
    {
        public static Tween TweenCellSize(this Grid grid, Vector3 to, float duration) =>
            Tweening.To(getter: () => grid.cellSize,
                        setter: cellSize => grid.cellSize = cellSize,
                        to, duration).SetTarget(grid);

        public static Tween TweenCellGap(this Grid grid, Vector3 to, float duration) =>
            Tweening.To(getter: () => grid.cellGap,
                        setter: cellGap => grid.cellGap = cellGap,
                        to, duration).SetTarget(grid);

    }

}
