using UnityEngine.UI;

namespace Zigurous.TweenEngine
{
    public static class HorizontalOrVerticalLayoutGroupTweens
    {
        public static Tween TweenSpacing(this HorizontalOrVerticalLayoutGroup group, float to, float duration) =>
            Tweening.To(getter: () => group.spacing,
                        setter: spacing => group.spacing = spacing,
                        to, duration).SetTarget(group);

    }

}
