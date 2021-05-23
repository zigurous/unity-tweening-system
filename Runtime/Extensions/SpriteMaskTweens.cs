using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class SpriteMaskTweens
    {
        public static Tween TweenAlphaCutoff(this SpriteMask mask, float to, float duration) =>
            Tweening.To(getter: () => mask.alphaCutoff,
                        setter: alphaCutoff => mask.alphaCutoff = alphaCutoff,
                        to, duration).SetTarget(mask);

    }

}
