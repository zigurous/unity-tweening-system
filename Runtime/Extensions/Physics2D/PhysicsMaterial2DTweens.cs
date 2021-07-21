using UnityEngine;

namespace Zigurous.Tweening
{
    public static class PhysicsMaterial2DTweens
    {
        public static Tween TweenBounciness(this PhysicsMaterial2D material, float to, float duration) =>
            Tweening.To(getter: () => material.bounciness,
                        setter: bounciness => material.bounciness = bounciness,
                        to, duration).SetId(material.GetHashCode());

        public static Tween TweenFriction(this PhysicsMaterial2D material, float to, float duration) =>
            Tweening.To(getter: () => material.friction,
                        setter: friction => material.friction = friction,
                        to, duration).SetId(material.GetHashCode());

    }

}
