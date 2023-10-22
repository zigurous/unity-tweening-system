using UnityEngine;

namespace Zigurous.Tweening
{
    public static class PhysicMaterialTweens
    {
        public static Tween TweenBounciness(this PhysicMaterial material, float to, float duration) =>
            Tweening.To(material, (target) => target.bounciness, (target, value) => target.bounciness = value, to, duration)
                    .SetReference(material);

        public static Tween TweenDynamicFriction(this PhysicMaterial material, float to, float duration) =>
            Tweening.To(material, (target) => target.dynamicFriction, (target, value) => target.dynamicFriction = value, to, duration)
                    .SetReference(material);

        public static Tween TweenStaticFriction(this PhysicMaterial material, float to, float duration) =>
            Tweening.To(material, (target) => target.staticFriction, (target, value) => target.staticFriction = value, to, duration)
                    .SetReference(material);
    }

}
