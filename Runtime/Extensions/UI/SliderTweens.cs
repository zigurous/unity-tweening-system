using UnityEngine.UI;

namespace Zigurous.Tweening
{
    public static class SliderTweens
    {
        public static Tween TweenValue(this Slider slider, float to, float duration) =>
            Tweening.To(slider, (source) => source.value, (source, value) => source.value = value, to, duration)
                    .SetTarget(slider);

        public static Tween TweenNormalizedValue(this Slider slider, float to, float duration) =>
            Tweening.To(slider, (source) => source.normalizedValue, (source, value) => source.normalizedValue = value, to, duration)
                    .SetTarget(slider);

        public static Tween TweenMinValue(this Slider slider, float to, float duration) =>
            Tweening.To(slider, (source) => source.minValue, (source, value) => source.minValue = value, to, duration)
                    .SetTarget(slider);

        public static Tween TweenMaxValue(this Slider slider, float to, float duration) =>
            Tweening.To(slider, (source) => source.maxValue, (source, value) => source.maxValue = value, to, duration)
                    .SetTarget(slider);
    }

}
