using UnityEngine;
using UnityEngine.UI;

namespace Zigurous.Tweening
{
    public static class GridLayoutGroupTweens
    {
        public static Tween TweenSpacing(this GridLayoutGroup layoutGroup, Vector2 to, float duration) =>
            Tweening.To(layoutGroup, (source) => source.spacing, (source, value) => source.spacing = value, to, duration)
                    .SetTarget(layoutGroup);

        public static Tween TweenCellSize(this GridLayoutGroup layoutGroup, Vector2 to, float duration) =>
            Tweening.To(layoutGroup, (source) => source.cellSize, (source, value) => source.cellSize = value, to, duration)
                    .SetTarget(layoutGroup);
    }

}
