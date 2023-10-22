using UnityEngine;

namespace Zigurous.Tweening
{
    public static class ClothTweens
    {
        public static Tween TweenDamping(this Cloth cloth, float to, float duration) =>
            Tweening.To(cloth, (target) => target.damping, (target, value) => target.damping = value, to, duration)
                    .SetReference(cloth);

        public static Tween TweenFriction(this Cloth cloth, float to, float duration) =>
            Tweening.To(cloth, (target) => target.friction, (target, value) => target.friction = value, to, duration)
                    .SetReference(cloth);

        public static Tween TweenCollisionMassScale(this Cloth cloth, float to, float duration) =>
            Tweening.To(cloth, (target) => target.collisionMassScale, (target, value) => target.collisionMassScale = value, to, duration)
                    .SetReference(cloth);

        public static Tween TweenWorldVelocityScale(this Cloth cloth, float to, float duration) =>
            Tweening.To(cloth, (target) => target.worldVelocityScale, (target, value) => target.worldVelocityScale = value, to, duration)
                    .SetReference(cloth);

        public static Tween TweenWorldAccelerationScale(this Cloth cloth, float to, float duration) =>
            Tweening.To(cloth, (target) => target.worldAccelerationScale, (target, value) => target.worldAccelerationScale = value, to, duration)
                    .SetReference(cloth);

        public static Tween TweenExternalAcceleration(this Cloth cloth, Vector3 to, float duration) =>
            Tweening.To(cloth, (target) => target.externalAcceleration, (target, value) => target.externalAcceleration = value, to, duration)
                    .SetReference(cloth);

        public static Tween TweenRandomAcceleration(this Cloth cloth, Vector3 to, float duration) =>
            Tweening.To(cloth, (target) => target.randomAcceleration, (target, value) => target.randomAcceleration = value, to, duration)
                    .SetReference(cloth);

        public static Tween TweenStiffnessFrequency(this Cloth cloth, float to, float duration) =>
            Tweening.To(cloth, (target) => target.stiffnessFrequency, (target, value) => target.stiffnessFrequency = value, to, duration)
                    .SetReference(cloth);

        public static Tween TweenSelfCollisionDistance(this Cloth cloth, float to, float duration) =>
            Tweening.To(cloth, (target) => target.selfCollisionDistance, (target, value) => target.selfCollisionDistance = value, to, duration)
                    .SetReference(cloth);

        public static Tween TweenSelfCollisionStiffness(this Cloth cloth, float to, float duration) =>
            Tweening.To(cloth, (target) => target.selfCollisionStiffness, (target, value) => target.selfCollisionStiffness = value, to, duration)
                    .SetReference(cloth);

        public static Tween TweenStretchingStiffness(this Cloth cloth, float to, float duration) =>
            Tweening.To(cloth, (target) => target.stretchingStiffness, (target, value) => target.stretchingStiffness = value, to, duration)
                    .SetReference(cloth);

        public static Tween TweenBendingStiffness(this Cloth cloth, float to, float duration) =>
            Tweening.To(cloth, (target) => target.bendingStiffness, (target, value) => target.bendingStiffness = value, to, duration)
                    .SetReference(cloth);

        public static Tween TweenSleepThreshold(this Cloth cloth, float to, float duration) =>
            Tweening.To(cloth, (target) => target.sleepThreshold, (target, value) => target.sleepThreshold = value, to, duration)
                    .SetReference(cloth);
    }

}
