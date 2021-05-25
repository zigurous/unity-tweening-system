using UnityEngine;

namespace Zigurous.Tweening
{
    public static class SpriteMaskTweens
    {
        public static Tween TweenAlphaCutoff(this SpriteMask mask, float to, float duration) =>
            Tweening.To(getter: () => mask.alphaCutoff,
                        setter: alphaCutoff => mask.alphaCutoff = alphaCutoff,
                        to, duration).SetTarget(mask);

    }

}
