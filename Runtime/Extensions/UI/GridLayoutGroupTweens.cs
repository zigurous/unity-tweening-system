using UnityEngine;
using UnityEngine.UI;

namespace Zigurous.Tweening
{
    public static class GridLayoutGroupTweens
    {
        public static Tween TweenSpacing(this GridLayoutGroup layoutGroup, Vector2 to, float duration) =>
            Tweening.To(layoutGroup, (target) => target.spacing, (target, value) => target.spacing = value, to, duration)
                    .SetReference(layoutGroup);

        public static Tween TweenCellSize(this GridLayoutGroup layoutGroup, Vector2 to, float duration) =>
            Tweening.To(layoutGroup, (target) => target.cellSize, (target, value) => target.cellSize = value, to, duration)
                    .SetReference(layoutGroup);
    }

}
