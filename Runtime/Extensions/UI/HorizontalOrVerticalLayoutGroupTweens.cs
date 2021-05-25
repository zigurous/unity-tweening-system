using UnityEngine.UI;

namespace Zigurous.TweenEngine
{
    public static class HorizontalOrVerticalLayoutGroupTweens
    {
        public static Tween TweenSpacing(this HorizontalOrVerticalLayoutGroup layoutGroup, float to, float duration) =>
            Tweening.To(getter: () => layoutGroup.spacing,
                        setter: spacing => layoutGroup.spacing = spacing,
                        to, duration).SetTarget(layoutGroup);

    }

}
