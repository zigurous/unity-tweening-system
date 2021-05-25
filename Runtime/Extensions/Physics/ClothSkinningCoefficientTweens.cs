using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class ClothSkinningCoefficientTweens
    {
        public static Tween TweenMaxDistance(this ClothSkinningCoefficient coefficient, float to, float duration) =>
            Tweening.To(getter: () => coefficient.maxDistance,
                        setter: maxDistance => coefficient.maxDistance = maxDistance,
                        to, duration).SetTarget(coefficient);

        public static Tween TweenCollisionSphereDistance(this ClothSkinningCoefficient coefficient, float to, float duration) =>
            Tweening.To(getter: () => coefficient.collisionSphereDistance,
                        setter: collisionSphereDistance => coefficient.collisionSphereDistance = collisionSphereDistance,
                        to, duration).SetTarget(coefficient);

    }

}
