using UnityEngine.UI;

namespace Zigurous.Tweening
{
    public static class HorizontalOrVerticalLayoutGroupTweens
    {
        public static Tween TweenSpacing(this HorizontalOrVerticalLayoutGroup layoutGroup, float to, float duration) =>
            Tweening.To(layoutGroup, (source) => source.spacing, (source, value) => source.spacing = value, to, duration)
                    .SetTarget(layoutGroup);
    }

}
