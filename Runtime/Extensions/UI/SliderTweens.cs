using UnityEngine.UI;

namespace Zigurous.TweenEngine
{
    public static class SliderTweens
    {
        public static Tween TweenValue(this Slider slider, float to, float duration) =>
            Tweening.To(getter: () => slider.value,
                        setter: value => slider.value = value,
                        to, duration).SetTarget(slider);

        public static Tween TweenNormalizedValue(this Slider slider, float to, float duration) =>
            Tweening.To(getter: () => slider.normalizedValue,
                        setter: normalizedValue => slider.normalizedValue = normalizedValue,
                        to, duration).SetTarget(slider);

        public static Tween TweenMinValue(this Slider slider, float to, float duration) =>
            Tweening.To(getter: () => slider.minValue,
                        setter: minValue => slider.minValue = minValue,
                        to, duration).SetTarget(slider);

        public static Tween TweenMaxValue(this Slider slider, float to, float duration) =>
            Tweening.To(getter: () => slider.maxValue,
                        setter: maxValue => slider.maxValue = maxValue,
                        to, duration).SetTarget(slider);

    }

}
