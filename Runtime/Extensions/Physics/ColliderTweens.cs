using UnityEngine;

namespace Zigurous.Tweening
{
    public static class ColliderTweens
    {
        public static Tween TweenContactOffset(this Collider collider, float to, float duration) =>
            Tweening.To(collider, (target) => target.contactOffset, (target, value) => target.contactOffset = value, to, duration)
                    .SetReference(collider);
    }

}
