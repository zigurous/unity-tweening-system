using UnityEngine.UI;

namespace Zigurous.Tweening
{
    public static class SliderTweens
    {
        public static Tween TweenValue(this Slider slider, float to, float duration) =>
            Tweening.To(slider, (target) => target.value, (target, value) => target.value = value, to, duration)
                    .SetReference(slider);

        public static Tween TweenNormalizedValue(this Slider slider, float to, float duration) =>
            Tweening.To(slider, (target) => target.normalizedValue, (target, value) => target.normalizedValue = value, to, duration)
                    .SetReference(slider);

        public static Tween TweenMinValue(this Slider slider, float to, float duration) =>
            Tweening.To(slider, (target) => target.minValue, (target, value) => target.minValue = value, to, duration)
                    .SetReference(slider);

        public static Tween TweenMaxValue(this Slider slider, float to, float duration) =>
            Tweening.To(slider, (target) => target.maxValue, (target, value) => target.maxValue = value, to, duration)
                    .SetReference(slider);
    }

}
