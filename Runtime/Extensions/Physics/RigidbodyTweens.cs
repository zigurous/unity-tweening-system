using UnityEngine;

namespace Zigurous.Tweening
{
    public static class RigidbodyTweens
    {
        public static Tween TweenPosition(this Rigidbody rigidbody, Vector3 to, float duration) =>
            Tweening.To(rigidbody, (source) => source.position, (source, value) => source.position = value, to, duration)
                    .SetTarget(rigidbody);

        public static Tween TweenRotation(this Rigidbody rigidbody, Quaternion to, float duration) =>
            Tweening.To(rigidbody, (source) => source.rotation, (source, value) => source.rotation = value, to, duration)
                    .SetTarget(rigidbody);

        public static Tween TweenVelocity(this Rigidbody rigidbody, Vector3 to, float duration) =>
            Tweening.To(rigidbody, (source) => source.velocity, (source, value) => source.velocity = value, to, duration)
                    .SetTarget(rigidbody);

        public static Tween TweenAngularVelocity(this Rigidbody rigidbody, Vector3 to, float duration) =>
            Tweening.To(rigidbody, (source) => source.angularVelocity, (source, value) => source.angularVelocity = value, to, duration)
                    .SetTarget(rigidbody);

        public static Tween TweenMaxAngularVelocity(this Rigidbody rigidbody, float to, float duration) =>
            Tweening.To(rigidbody, (source) => source.maxAngularVelocity, (source, value) => source.maxAngularVelocity = value, to, duration)
                    .SetTarget(rigidbody);

        public static Tween TweenMaxDepenetrationVelocity(this Rigidbody rigidbody, float to, float duration) =>
            Tweening.To(rigidbody, (source) => source.maxDepenetrationVelocity, (source, value) => source.maxDepenetrationVelocity = value, to, duration)
                    .SetTarget(rigidbody);

        public static Tween TweenMass(this Rigidbody rigidbody, float to, float duration) =>
            Tweening.To(rigidbody, (source) => source.mass, (source, value) => source.mass = value, to, duration)
                    .SetTarget(rigidbody);

        public static Tween TweenCenterOfMass(this Rigidbody rigidbody, Vector3 to, float duration) =>
            Tweening.To(rigidbody, (source) => source.centerOfMass, (source, value) => source.centerOfMass = value, to, duration)
                    .SetTarget(rigidbody);

        public static Tween TweenDrag(this Rigidbody rigidbody, float to, float duration) =>
            Tweening.To(rigidbody, (source) => source.drag, (source, value) => source.drag = value, to, duration)
                    .SetTarget(rigidbody);

        public static Tween TweenAngularDrag(this Rigidbody rigidbody, float to, float duration) =>
            Tweening.To(rigidbody, (source) => source.angularDrag, (source, value) => source.angularDrag = value, to, duration)
                    .SetTarget(rigidbody);

        public static Tween TweenInertiaTensor(this Rigidbody rigidbody, Vector3 to, float duration) =>
            Tweening.To(rigidbody, (source) => source.inertiaTensor, (source, value) => source.inertiaTensor = value, to, duration)
                    .SetTarget(rigidbody);

        public static Tween TweenInertiaTensorRotation(this Rigidbody rigidbody, Quaternion to, float duration) =>
            Tweening.To(rigidbody, (source) => source.inertiaTensorRotation, (source, value) => source.inertiaTensorRotation = value, to, duration)
                    .SetTarget(rigidbody);

        public static Tween TweenSleepThreshold(this Rigidbody rigidbody, float to, float duration) =>
            Tweening.To(rigidbody, (source) => source.sleepThreshold, (source, value) => source.sleepThreshold = value, to, duration)
                    .SetTarget(rigidbody);
    }

}
