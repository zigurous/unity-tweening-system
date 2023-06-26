using UnityEngine;

namespace Zigurous.Tweening
{
    public static class SpriteMaskTweens
    {
        public static Tween TweenAlphaCutoff(this SpriteMask mask, float to, float duration) =>
            Tweening.To(mask, (source) => source.alphaCutoff, (source, value) => source.alphaCutoff = value, to, duration)
                    .SetTarget(mask);
    }

}
