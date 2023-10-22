using UnityEngine;

namespace Zigurous.Tweening
{
    public static class LensFlareTweens
    {
        public static Tween TweenColor(this LensFlare lensFlare, Color to, float duration) =>
            Tweening.To(lensFlare, (target) => target.color, (target, value) => target.color = value, to, duration)
                    .SetReference(lensFlare);

        public static Tween TweenBrightness(this LensFlare lensFlare, float to, float duration) =>
            Tweening.To(lensFlare, (target) => target.brightness, (target, value) => target.brightness = value, to, duration)
                    .SetReference(lensFlare);

        public static Tween TweenFadeSpeed(this LensFlare lensFlare, float to, float duration) =>
            Tweening.To(lensFlare, (target) => target.fadeSpeed, (target, value) => target.fadeSpeed = value, to, duration)
                    .SetReference(lensFlare);
    }

}
