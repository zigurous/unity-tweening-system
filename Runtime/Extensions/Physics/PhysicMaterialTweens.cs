using UnityEngine;

namespace Zigurous.Tweening
{
    public static class PhysicMaterialTweens
    {
        public static Tween TweenBounciness(this PhysicMaterial material, float to, float duration) =>
            Tweening.To(material, (source) => source.bounciness, (source, value) => source.bounciness = value, to, duration)
                    .SetId(material.GetHashCode());

        public static Tween TweenDynamicFriction(this PhysicMaterial material, float to, float duration) =>
            Tweening.To(material, (source) => source.dynamicFriction, (source, value) => source.dynamicFriction = value, to, duration)
                    .SetId(material.GetHashCode());

        public static Tween TweenStaticFriction(this PhysicMaterial material, float to, float duration) =>
            Tweening.To(material, (source) => source.staticFriction, (source, value) => source.staticFriction = value, to, duration)
                    .SetId(material.GetHashCode());
    }

}
