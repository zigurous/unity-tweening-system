using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class ClothTweens
    {
        public static Tween TweenDamping(this Cloth cloth, float to, float duration) =>
            Tweening.To(getter: () => cloth.damping,
                        setter: damping => cloth.damping = damping,
                        to, duration).SetTarget(cloth);

        public static Tween TweenFriction(this Cloth cloth, float to, float duration) =>
            Tweening.To(getter: () => cloth.friction,
                        setter: friction => cloth.friction = friction,
                        to, duration).SetTarget(cloth);

        public static Tween TweenCollisionMassScale(this Cloth cloth, float to, float duration) =>
            Tweening.To(getter: () => cloth.collisionMassScale,
                        setter: collisionMassScale => cloth.collisionMassScale = collisionMassScale,
                        to, duration).SetTarget(cloth);

        public static Tween TweenWorldVelocityScale(this Cloth cloth, float to, float duration) =>
            Tweening.To(getter: () => cloth.worldVelocityScale,
                        setter: worldVelocityScale => cloth.worldVelocityScale = worldVelocityScale,
                        to, duration).SetTarget(cloth);

        public static Tween TweenWorldAccelerationScale(this Cloth cloth, float to, float duration) =>
            Tweening.To(getter: () => cloth.worldAccelerationScale,
                        setter: worldAccelerationScale => cloth.worldAccelerationScale = worldAccelerationScale,
                        to, duration).SetTarget(cloth);

        public static Tween TweenExternalAcceleration(this Cloth cloth, Vector3 to, float duration) =>
            Tweening.To(getter: () => cloth.externalAcceleration,
                        setter: externalAcceleration => cloth.externalAcceleration = externalAcceleration,
                        to, duration).SetTarget(cloth);

        public static Tween TweenRandomAcceleration(this Cloth cloth, Vector3 to, float duration) =>
            Tweening.To(getter: () => cloth.randomAcceleration,
                        setter: randomAcceleration => cloth.randomAcceleration = randomAcceleration,
                        to, duration).SetTarget(cloth);

        public static Tween TweenStiffnessFrequency(this Cloth cloth, float to, float duration) =>
            Tweening.To(getter: () => cloth.stiffnessFrequency,
                        setter: stiffnessFrequency => cloth.stiffnessFrequency = stiffnessFrequency,
                        to, duration).SetTarget(cloth);

        public static Tween TweenSelfCollisionDistance(this Cloth cloth, float to, float duration) =>
            Tweening.To(getter: () => cloth.selfCollisionDistance,
                        setter: selfCollisionDistance => cloth.selfCollisionDistance = selfCollisionDistance,
                        to, duration).SetTarget(cloth);

        public static Tween TweenSelfCollisionStiffness(this Cloth cloth, float to, float duration) =>
            Tweening.To(getter: () => cloth.selfCollisionStiffness,
                        setter: selfCollisionStiffness => cloth.selfCollisionStiffness = selfCollisionStiffness,
                        to, duration).SetTarget(cloth);

        public static Tween TweenStretchingStiffness(this Cloth cloth, float to, float duration) =>
            Tweening.To(getter: () => cloth.stretchingStiffness,
                        setter: stretchingStiffness => cloth.stretchingStiffness = stretchingStiffness,
                        to, duration).SetTarget(cloth);

        public static Tween TweenBendingStiffness(this Cloth cloth, float to, float duration) =>
            Tweening.To(getter: () => cloth.bendingStiffness,
                        setter: bendingStiffness => cloth.bendingStiffness = bendingStiffness,
                        to, duration).SetTarget(cloth);

        public static Tween TweenSleepThreshold(this Cloth cloth, float to, float duration) =>
            Tweening.To(getter: () => cloth.sleepThreshold,
                        setter: sleepThreshold => cloth.sleepThreshold = sleepThreshold,
                        to, duration).SetTarget(cloth);

    }

}
