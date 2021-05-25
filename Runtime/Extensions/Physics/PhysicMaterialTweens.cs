using UnityEngine;

namespace Zigurous.Tweening
{
    public static class PhysicMaterialTweens
    {
        public static Tween TweenBounciness(this PhysicMaterial material, float to, float duration) =>
            Tweening.To(getter: () => material.bounciness,
                        setter: bounciness => material.bounciness = bounciness,
                        to, duration).SetTarget(material);

        public static Tween TweenDynamicFriction(this PhysicMaterial material, float to, float duration) =>
            Tweening.To(getter: () => material.dynamicFriction,
                        setter: friction => material.dynamicFriction = friction,
                        to, duration).SetTarget(material);

        public static Tween TweenStaticFriction(this PhysicMaterial material, float to, float duration) =>
            Tweening.To(getter: () => material.staticFriction,
                        setter: friction => material.staticFriction = friction,
                        to, duration).SetTarget(material);

    }

}
