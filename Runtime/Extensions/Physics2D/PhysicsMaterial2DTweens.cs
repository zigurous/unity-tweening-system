using UnityEngine;

namespace Zigurous.Tweening
{
    public static class PhysicsMaterial2DTweens
    {
        public static Tween TweenBounciness(this PhysicsMaterial2D material, float to, float duration) =>
            Tweening.To(material, (target) => target.bounciness, (target, value) => target.bounciness = value, to, duration)
                    .SetReference(material);

        public static Tween TweenFriction(this PhysicsMaterial2D material, float to, float duration) =>
            Tweening.To(material, (target) => target.friction, (target, value) => target.friction = value, to, duration)
                    .SetReference(material);
    }

}
