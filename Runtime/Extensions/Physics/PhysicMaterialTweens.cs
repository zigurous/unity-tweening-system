using System;
using UnityEngine;

namespace Zigurous.Tweening
{
    public static class PhysicMaterialTweens
    {
        [Obsolete("'PhysicMaterial' is obsolete: 'PhysicMaterial has been renamed to PhysicsMaterial.")]
        public static Tween TweenBounciness(this PhysicMaterial material, float to, float duration) =>
            Tweening.To(material, (target) => target.bounciness, (target, value) => target.bounciness = value, to, duration)
                    .SetReference(material);

        [Obsolete("'PhysicMaterial' is obsolete: 'PhysicMaterial has been renamed to PhysicsMaterial.")]
        public static Tween TweenDynamicFriction(this PhysicMaterial material, float to, float duration) =>
            Tweening.To(material, (target) => target.dynamicFriction, (target, value) => target.dynamicFriction = value, to, duration)
                    .SetReference(material);

        [Obsolete("'PhysicMaterial' is obsolete: 'PhysicMaterial has been renamed to PhysicsMaterial.")]
        public static Tween TweenStaticFriction(this PhysicMaterial material, float to, float duration) =>
            Tweening.To(material, (target) => target.staticFriction, (target, value) => target.staticFriction = value, to, duration)
                    .SetReference(material);

        public static Tween TweenBounciness(this PhysicsMaterial material, float to, float duration) =>
            Tweening.To(material, (target) => target.bounciness, (target, value) => target.bounciness = value, to, duration)
                    .SetReference(material);

        public static Tween TweenDynamicFriction(this PhysicsMaterial material, float to, float duration) =>
            Tweening.To(material, (target) => target.dynamicFriction, (target, value) => target.dynamicFriction = value, to, duration)
                    .SetReference(material);

        public static Tween TweenStaticFriction(this PhysicsMaterial material, float to, float duration) =>
            Tweening.To(material, (target) => target.staticFriction, (target, value) => target.staticFriction = value, to, duration)
                    .SetReference(material);
    }

}
