using UnityEngine.UI;

namespace Zigurous.Tweening
{
    public static class HorizontalOrVerticalLayoutGroupTweens
    {
        public static Tween TweenSpacing(this HorizontalOrVerticalLayoutGroup layoutGroup, float to, float duration) =>
            Tweening.To(layoutGroup, (target) => target.spacing, (target, value) => target.spacing = value, to, duration)
                    .SetReference(layoutGroup);
    }

}
