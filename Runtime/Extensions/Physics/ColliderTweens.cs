using UnityEngine;

namespace Zigurous.Tweening
{
    public static class ColliderTweens
    {
        public static Tween TweenContactOffset(this Collider collider, float to, float duration) =>
            Tweening.To(collider, (source) => source.contactOffset, (source, value) => source.contactOffset = value, to, duration)
                    .SetTarget(collider);
    }

}
