using UnityEngine;

namespace Zigurous.Tweening
{
    public static class SpriteMaskTweens
    {
        public static Tween TweenAlphaCutoff(this SpriteMask mask, float to, float duration) =>
            Tweening.To(mask, (target) => target.alphaCutoff, (target, value) => target.alphaCutoff = value, to, duration)
                    .SetReference(mask);
    }

}
