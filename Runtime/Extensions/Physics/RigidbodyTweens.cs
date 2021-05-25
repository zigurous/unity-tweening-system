using UnityEngine;

namespace Zigurous.Tweening
{
    public static class RigidbodyTweens
    {
        public static Tween TweenPosition(this Rigidbody rigidbody, Vector3 to, float duration) =>
            Tweening.To(getter: () => rigidbody.position,
                        setter: position => rigidbody.position = position,
                        to, duration).SetTarget(rigidbody);

        public static Tween TweenRotation(this Rigidbody rigidbody, Quaternion to, float duration) =>
            Tweening.To(getter: () => rigidbody.rotation,
                        setter: rotation => rigidbody.rotation = rotation,
                        to, duration).SetTarget(rigidbody);

        public static Tween TweenVelocity(this Rigidbody rigidbody, Vector3 to, float duration) =>
            Tweening.To(getter: () => rigidbody.velocity,
                        setter: velocity => rigidbody.velocity = velocity,
                        to, duration).SetTarget(rigidbody);

        public static Tween TweenAngularVelocity(this Rigidbody rigidbody, Vector3 to, float duration) =>
            Tweening.To(getter: () => rigidbody.angularVelocity,
                        setter: angularVelocity => rigidbody.angularVelocity = angularVelocity,
                        to, duration).SetTarget(rigidbody);

        public static Tween TweenMaxAngularVelocity(this Rigidbody rigidbody, float to, float duration) =>
            Tweening.To(getter: () => rigidbody.maxAngularVelocity,
                        setter: maxAngularVelocity => rigidbody.maxAngularVelocity = maxAngularVelocity,
                        to, duration).SetTarget(rigidbody);

        public static Tween TweenMaxDepenetrationVelocity(this Rigidbody rigidbody, float to, float duration) =>
            Tweening.To(getter: () => rigidbody.maxDepenetrationVelocity,
                        setter: maxDepenetrationVelocity => rigidbody.maxDepenetrationVelocity = maxDepenetrationVelocity,
                        to, duration).SetTarget(rigidbody);

        public static Tween TweenMass(this Rigidbody rigidbody, float to, float duration) =>
            Tweening.To(getter: () => rigidbody.mass,
                        setter: mass => rigidbody.mass = mass,
                        to, duration).SetTarget(rigidbody);

        public static Tween TweenCenterOfMass(this Rigidbody rigidbody, Vector3 to, float duration) =>
            Tweening.To(getter: () => rigidbody.centerOfMass,
                        setter: centerOfMass => rigidbody.centerOfMass = centerOfMass,
                        to, duration).SetTarget(rigidbody);

        public static Tween TweenDrag(this Rigidbody rigidbody, float to, float duration) =>
            Tweening.To(getter: () => rigidbody.drag,
                        setter: drag => rigidbody.drag = drag,
                        to, duration).SetTarget(rigidbody);

        public static Tween TweenAngularDrag(this Rigidbody rigidbody, float to, float duration) =>
            Tweening.To(getter: () => rigidbody.angularDrag,
                        setter: angularDrag => rigidbody.angularDrag = angularDrag,
                        to, duration).SetTarget(rigidbody);

        public static Tween TweenInertiaTensor(this Rigidbody rigidbody, Vector3 to, float duration) =>
            Tweening.To(getter: () => rigidbody.inertiaTensor,
                        setter: inertiaTensor => rigidbody.inertiaTensor = inertiaTensor,
                        to, duration).SetTarget(rigidbody);

        public static Tween TweenInertiaTensorRotation(this Rigidbody rigidbody, Quaternion to, float duration) =>
            Tweening.To(getter: () => rigidbody.inertiaTensorRotation,
                        setter: inertiaTensorRotation => rigidbody.inertiaTensorRotation = inertiaTensorRotation,
                        to, duration).SetTarget(rigidbody);

        public static Tween TweenSleepThreshold(this Rigidbody rigidbody, float to, float duration) =>
            Tweening.To(getter: () => rigidbody.sleepThreshold,
                        setter: sleepThreshold => rigidbody.sleepThreshold = sleepThreshold,
                        to, duration).SetTarget(rigidbody);

    }

}
