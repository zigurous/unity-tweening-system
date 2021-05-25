using UnityEngine;

namespace Zigurous.Tweening
{
    public static class LensFlareTweens
    {
        public static Tween TweenColor(this LensFlare lensFlare, Color to, float duration) =>
            Tweening.To(getter: () => lensFlare.color,
                        setter: color => lensFlare.color = color,
                        to, duration).SetTarget(lensFlare);

        public static Tween TweenBrightness(this LensFlare lensFlare, float to, float duration) =>
            Tweening.To(getter: () => lensFlare.brightness,
                        setter: brightness => lensFlare.brightness = brightness,
                        to, duration).SetTarget(lensFlare);

        public static Tween TweenFadeSpeed(this LensFlare lensFlare, float to, float duration) =>
            Tweening.To(getter: () => lensFlare.fadeSpeed,
                        setter: fadeSpeed => lensFlare.fadeSpeed = fadeSpeed,
                        to, duration).SetTarget(lensFlare);

    }

}
