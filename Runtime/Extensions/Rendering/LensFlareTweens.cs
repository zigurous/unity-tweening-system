using UnityEngine;

namespace Zigurous.Tweening
{
    public static class LensFlareTweens
    {
        public static Tween TweenColor(this LensFlare lensFlare, Color to, float duration) =>
            Tweening.To(lensFlare, (source) => source.color, (source, value) => source.color = value, to, duration)
                    .SetTarget(lensFlare);

        public static Tween TweenBrightness(this LensFlare lensFlare, float to, float duration) =>
            Tweening.To(lensFlare, (source) => source.brightness, (source, value) => source.brightness = value, to, duration)
                    .SetTarget(lensFlare);

        public static Tween TweenFadeSpeed(this LensFlare lensFlare, float to, float duration) =>
            Tweening.To(lensFlare, (source) => source.fadeSpeed, (source, value) => source.fadeSpeed = value, to, duration)
                    .SetTarget(lensFlare);
    }

}
