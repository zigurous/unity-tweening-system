using UnityEngine;

namespace Zigurous.Tweening
{
    public static class WheelColliderTweens
    {
        public static Tween TweenForceAppPointDistance(this WheelCollider collider, float to, float duration) =>
            Tweening.To(collider, (source) => source.forceAppPointDistance, (source, value) => source.forceAppPointDistance = value, to, duration)
                    .SetTarget(collider);

        public static Tween TweenSteerAngle(this WheelCollider collider, float to, float duration) =>
            Tweening.To(collider, (source) => source.steerAngle, (source, value) => source.steerAngle = value, to, duration)
                    .SetTarget(collider);

        public static Tween TweenBreakTorque(this WheelCollider collider, float to, float duration) =>
            Tweening.To(collider, (source) => source.brakeTorque, (source, value) => source.brakeTorque = value, to, duration)
                    .SetTarget(collider);

        public static Tween TweenMotorTorque(this WheelCollider collider, float to, float duration) =>
            Tweening.To(collider, (source) => source.motorTorque, (source, value) => source.motorTorque = value, to, duration)
                    .SetTarget(collider);

        public static Tween TweenWheelDampingRate(this WheelCollider collider, float to, float duration) =>
            Tweening.To(collider, (source) => source.wheelDampingRate, (source, value) => source.wheelDampingRate = value, to, duration)
                    .SetTarget(collider);

        public static Tween TweenMass(this WheelCollider collider, float to, float duration) =>
            Tweening.To(collider, (source) => source.mass, (source, value) => source.mass = value, to, duration)
                    .SetTarget(collider);

        public static Tween TweenSprungMass(this WheelCollider collider, float to, float duration) =>
            Tweening.To(collider, (source) => source.sprungMass, (source, value) => source.sprungMass = value, to, duration)
                    .SetTarget(collider);

        public static Tween TweenSuspensionDistance(this WheelCollider collider, float to, float duration) =>
            Tweening.To(collider, (source) => source.suspensionDistance, (source, value) => source.suspensionDistance = value, to, duration)
                    .SetTarget(collider);

        public static Tween TweenRadius(this WheelCollider collider, float to, float duration) =>
            Tweening.To(collider, (source) => source.radius, (source, value) => source.radius = value, to, duration)
                    .SetTarget(collider);

        public static Tween TweenCenter(this WheelCollider collider, Vector3 to, float duration) =>
            Tweening.To(collider, (source) => source.center, (source, value) => source.center = value, to, duration)
                    .SetTarget(collider);
    }

}
