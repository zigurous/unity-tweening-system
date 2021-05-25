using UnityEngine;
using UnityEngine.UI;

namespace Zigurous.Tweening
{
    public static class ShadowTweens
    {
        public static Tween TweenEffectColor(this Shadow shadow, Color to, float duration) =>
            Tweening.To(getter: () => shadow.effectColor,
                        setter: effectColor => shadow.effectColor = effectColor,
                        to, duration).SetTarget(shadow);

        public static Tween TweenEffectDistance(this Shadow shadow, Vector2 to, float duration) =>
            Tweening.To(getter: () => shadow.effectDistance,
                        setter: effectDistance => shadow.effectDistance = effectDistance,
                        to, duration).SetTarget(shadow);

    }

}
