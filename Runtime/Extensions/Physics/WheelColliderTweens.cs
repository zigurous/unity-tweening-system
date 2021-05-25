using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class WheelColliderTweens
    {
        public static Tween TweenForceAppPointDistance(this WheelCollider collider, float to, float duration) =>
            Tweening.To(getter: () => collider.forceAppPointDistance,
                        setter: forceAppPointDistance => collider.forceAppPointDistance = forceAppPointDistance,
                        to, duration).SetTarget(collider);

        public static Tween TweenSteerAngle(this WheelCollider collider, float to, float duration) =>
            Tweening.To(getter: () => collider.steerAngle,
                        setter: steerAngle => collider.steerAngle = steerAngle,
                        to, duration).SetTarget(collider);

        public static Tween TweenBreakTorque(this WheelCollider collider, float to, float duration) =>
            Tweening.To(getter: () => collider.brakeTorque,
                        setter: brakeTorque => collider.brakeTorque = brakeTorque,
                        to, duration).SetTarget(collider);

        public static Tween TweenMotorTorque(this WheelCollider collider, float to, float duration) =>
            Tweening.To(getter: () => collider.motorTorque,
                        setter: motorTorque => collider.motorTorque = motorTorque,
                        to, duration).SetTarget(collider);

        public static Tween TweenWheelDampingRate(this WheelCollider collider, float to, float duration) =>
            Tweening.To(getter: () => collider.wheelDampingRate,
                        setter: wheelDampingRate => collider.wheelDampingRate = wheelDampingRate,
                        to, duration).SetTarget(collider);

        public static Tween TweenMass(this WheelCollider collider, float to, float duration) =>
            Tweening.To(getter: () => collider.mass,
                        setter: mass => collider.mass = mass,
                        to, duration).SetTarget(collider);

        public static Tween TweenSprungMass(this WheelCollider collider, float to, float duration) =>
            Tweening.To(getter: () => collider.sprungMass,
                        setter: sprungMass => collider.sprungMass = sprungMass,
                        to, duration).SetTarget(collider);

        public static Tween TweenSuspensionDistance(this WheelCollider collider, float to, float duration) =>
            Tweening.To(getter: () => collider.suspensionDistance,
                        setter: suspensionDistance => collider.suspensionDistance = suspensionDistance,
                        to, duration).SetTarget(collider);

        public static Tween TweenRadius(this WheelCollider collider, float to, float duration) =>
            Tweening.To(getter: () => collider.radius,
                        setter: radius => collider.radius = radius,
                        to, duration).SetTarget(collider);

        public static Tween TweenCenter(this WheelCollider collider, Vector3 to, float duration) =>
            Tweening.To(getter: () => collider.center,
                        setter: center => collider.center = center,
                        to, duration).SetTarget(collider);

    }

}
