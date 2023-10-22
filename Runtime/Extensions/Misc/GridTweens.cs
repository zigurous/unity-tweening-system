using UnityEngine;

namespace Zigurous.Tweening
{
    public static class GridTweens
    {
        public static Tween TweenCellSize(this Grid grid, Vector3 to, float duration) =>
            Tweening.To(grid, (target) => target.cellSize, (target, value) => target.cellSize = value, to, duration)
                    .SetReference(grid);

        public static Tween TweenCellGap(this Grid grid, Vector3 to, float duration) =>
            Tweening.To(grid, (target) => target.cellGap, (target, value) => target.cellGap = value, to, duration)
                    .SetReference(grid);
    }

}
