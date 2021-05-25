using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class ColliderTweens
    {
        public static Tween TweenContactOffset(this Collider collider, float to, float duration) =>
            Tweening.To(getter: () => collider.contactOffset,
                        setter: contactOffset => collider.contactOffset = contactOffset,
                        to, duration).SetTarget(collider);

    }

}
