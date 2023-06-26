using UnityEngine;

namespace Zigurous.Tweening
{
    public static class PhysicsMaterial2DTweens
    {
        public static Tween TweenBounciness(this PhysicsMaterial2D material, float to, float duration) =>
            Tweening.To(material, (source) => source.bounciness, (source, value) => source.bounciness = value, to, duration)
                    .SetId(material.GetHashCode());

        public static Tween TweenFriction(this PhysicsMaterial2D material, float to, float duration) =>
            Tweening.To(material, (source) => source.friction, (source, value) => source.friction = value, to, duration)
                    .SetId(material.GetHashCode());
    }

}
