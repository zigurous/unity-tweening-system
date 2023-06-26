using UnityEngine;

namespace Zigurous.Tweening
{
    public static class GridTweens
    {
        public static Tween TweenCellSize(this Grid grid, Vector3 to, float duration) =>
            Tweening.To(grid, (source) => source.cellSize, (source, value) => source.cellSize = value, to, duration)
                    .SetTarget(grid);

        public static Tween TweenCellGap(this Grid grid, Vector3 to, float duration) =>
            Tweening.To(grid, (source) => source.cellGap, (source, value) => source.cellGap = value, to, duration)
                    .SetTarget(grid);
    }

}
