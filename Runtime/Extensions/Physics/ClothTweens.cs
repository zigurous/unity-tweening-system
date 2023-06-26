using UnityEngine;

namespace Zigurous.Tweening
{
    public static class ClothTweens
    {
        public static Tween TweenDamping(this Cloth cloth, float to, float duration) =>
            Tweening.To(cloth, (source) => source.damping, (source, value) => source.damping = value, to, duration)
                    .SetTarget(cloth);

        public static Tween TweenFriction(this Cloth cloth, float to, float duration) =>
            Tweening.To(cloth, (source) => source.friction, (source, value) => source.friction = value, to, duration)
                    .SetTarget(cloth);

        public static Tween TweenCollisionMassScale(this Cloth cloth, float to, float duration) =>
            Tweening.To(cloth, (source) => source.collisionMassScale, (source, value) => source.collisionMassScale = value, to, duration)
                    .SetTarget(cloth);

        public static Tween TweenWorldVelocityScale(this Cloth cloth, float to, float duration) =>
            Tweening.To(cloth, (source) => source.worldVelocityScale, (source, value) => source.worldVelocityScale = value, to, duration)
                    .SetTarget(cloth);

        public static Tween TweenWorldAccelerationScale(this Cloth cloth, float to, float duration) =>
            Tweening.To(cloth, (source) => source.worldAccelerationScale, (source, value) => source.worldAccelerationScale = value, to, duration)
                    .SetTarget(cloth);

        public static Tween TweenExternalAcceleration(this Cloth cloth, Vector3 to, float duration) =>
            Tweening.To(cloth, (source) => source.externalAcceleration, (source, value) => source.externalAcceleration = value, to, duration)
                    .SetTarget(cloth);

        public static Tween TweenRandomAcceleration(this Cloth cloth, Vector3 to, float duration) =>
            Tweening.To(cloth, (source) => source.randomAcceleration, (source, value) => source.randomAcceleration = value, to, duration)
                    .SetTarget(cloth);

        public static Tween TweenStiffnessFrequency(this Cloth cloth, float to, float duration) =>
            Tweening.To(cloth, (source) => source.stiffnessFrequency, (source, value) => source.stiffnessFrequency = value, to, duration)
                    .SetTarget(cloth);

        public static Tween TweenSelfCollisionDistance(this Cloth cloth, float to, float duration) =>
            Tweening.To(cloth, (source) => source.selfCollisionDistance, (source, value) => source.selfCollisionDistance = value, to, duration)
                    .SetTarget(cloth);

        public static Tween TweenSelfCollisionStiffness(this Cloth cloth, float to, float duration) =>
            Tweening.To(cloth, (source) => source.selfCollisionStiffness, (source, value) => source.selfCollisionStiffness = value, to, duration)
                    .SetTarget(cloth);

        public static Tween TweenStretchingStiffness(this Cloth cloth, float to, float duration) =>
            Tweening.To(cloth, (source) => source.stretchingStiffness, (source, value) => source.stretchingStiffness = value, to, duration)
                    .SetTarget(cloth);

        public static Tween TweenBendingStiffness(this Cloth cloth, float to, float duration) =>
            Tweening.To(cloth, (source) => source.bendingStiffness, (source, value) => source.bendingStiffness = value, to, duration)
                    .SetTarget(cloth);

        public static Tween TweenSleepThreshold(this Cloth cloth, float to, float duration) =>
            Tweening.To(cloth, (source) => source.sleepThreshold, (source, value) => source.sleepThreshold = value, to, duration)
                    .SetTarget(cloth);
    }

}
