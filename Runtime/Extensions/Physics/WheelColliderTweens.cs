using UnityEngine;

namespace Zigurous.Tweening
{
    public static class WheelColliderTweens
    {
        public static Tween TweenForceAppPointDistance(this WheelCollider collider, float to, float duration) =>
            Tweening.To(collider, (target) => target.forceAppPointDistance, (target, value) => target.forceAppPointDistance = value, to, duration)
                    .SetReference(collider);

        public static Tween TweenSteerAngle(this WheelCollider collider, float to, float duration) =>
            Tweening.To(collider, (target) => target.steerAngle, (target, value) => target.steerAngle = value, to, duration)
                    .SetReference(collider);

        public static Tween TweenBreakTorque(this WheelCollider collider, float to, float duration) =>
            Tweening.To(collider, (target) => target.brakeTorque, (target, value) => target.brakeTorque = value, to, duration)
                    .SetReference(collider);

        public static Tween TweenMotorTorque(this WheelCollider collider, float to, float duration) =>
            Tweening.To(collider, (target) => target.motorTorque, (target, value) => target.motorTorque = value, to, duration)
                    .SetReference(collider);

        public static Tween TweenWheelDampingRate(this WheelCollider collider, float to, float duration) =>
            Tweening.To(collider, (target) => target.wheelDampingRate, (target, value) => target.wheelDampingRate = value, to, duration)
                    .SetReference(collider);

        public static Tween TweenMass(this WheelCollider collider, float to, float duration) =>
            Tweening.To(collider, (target) => target.mass, (target, value) => target.mass = value, to, duration)
                    .SetReference(collider);

        public static Tween TweenSprungMass(this WheelCollider collider, float to, float duration) =>
            Tweening.To(collider, (target) => target.sprungMass, (target, value) => target.sprungMass = value, to, duration)
                    .SetReference(collider);

        public static Tween TweenSuspensionDistance(this WheelCollider collider, float to, float duration) =>
            Tweening.To(collider, (target) => target.suspensionDistance, (target, value) => target.suspensionDistance = value, to, duration)
                    .SetReference(collider);

        public static Tween TweenRadius(this WheelCollider collider, float to, float duration) =>
            Tweening.To(collider, (target) => target.radius, (target, value) => target.radius = value, to, duration)
                    .SetReference(collider);

        public static Tween TweenCenter(this WheelCollider collider, Vector3 to, float duration) =>
            Tweening.To(collider, (target) => target.center, (target, value) => target.center = value, to, duration)
                    .SetReference(collider);
    }

}
