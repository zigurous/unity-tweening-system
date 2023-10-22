using UnityEngine;

namespace Zigurous.Tweening
{
    public static class RigidbodyTweens
    {
        public static Tween TweenPosition(this Rigidbody rigidbody, Vector3 to, float duration) =>
            Tweening.To(rigidbody, (target) => target.position, (target, value) => target.position = value, to, duration)
                    .SetReference(rigidbody);

        public static Tween TweenRotation(this Rigidbody rigidbody, Quaternion to, float duration) =>
            Tweening.To(rigidbody, (target) => target.rotation, (target, value) => target.rotation = value, to, duration)
                    .SetReference(rigidbody);

        public static Tween TweenVelocity(this Rigidbody rigidbody, Vector3 to, float duration) =>
            Tweening.To(rigidbody, (target) => target.velocity, (target, value) => target.velocity = value, to, duration)
                    .SetReference(rigidbody);

        public static Tween TweenAngularVelocity(this Rigidbody rigidbody, Vector3 to, float duration) =>
            Tweening.To(rigidbody, (target) => target.angularVelocity, (target, value) => target.angularVelocity = value, to, duration)
                    .SetReference(rigidbody);

        public static Tween TweenMaxAngularVelocity(this Rigidbody rigidbody, float to, float duration) =>
            Tweening.To(rigidbody, (target) => target.maxAngularVelocity, (target, value) => target.maxAngularVelocity = value, to, duration)
                    .SetReference(rigidbody);

        public static Tween TweenMaxDepenetrationVelocity(this Rigidbody rigidbody, float to, float duration) =>
            Tweening.To(rigidbody, (target) => target.maxDepenetrationVelocity, (target, value) => target.maxDepenetrationVelocity = value, to, duration)
                    .SetReference(rigidbody);

        public static Tween TweenMass(this Rigidbody rigidbody, float to, float duration) =>
            Tweening.To(rigidbody, (target) => target.mass, (target, value) => target.mass = value, to, duration)
                    .SetReference(rigidbody);

        public static Tween TweenCenterOfMass(this Rigidbody rigidbody, Vector3 to, float duration) =>
            Tweening.To(rigidbody, (target) => target.centerOfMass, (target, value) => target.centerOfMass = value, to, duration)
                    .SetReference(rigidbody);

        public static Tween TweenDrag(this Rigidbody rigidbody, float to, float duration) =>
            Tweening.To(rigidbody, (target) => target.drag, (target, value) => target.drag = value, to, duration)
                    .SetReference(rigidbody);

        public static Tween TweenAngularDrag(this Rigidbody rigidbody, float to, float duration) =>
            Tweening.To(rigidbody, (target) => target.angularDrag, (target, value) => target.angularDrag = value, to, duration)
                    .SetReference(rigidbody);

        public static Tween TweenInertiaTensor(this Rigidbody rigidbody, Vector3 to, float duration) =>
            Tweening.To(rigidbody, (target) => target.inertiaTensor, (target, value) => target.inertiaTensor = value, to, duration)
                    .SetReference(rigidbody);

        public static Tween TweenInertiaTensorRotation(this Rigidbody rigidbody, Quaternion to, float duration) =>
            Tweening.To(rigidbody, (target) => target.inertiaTensorRotation, (target, value) => target.inertiaTensorRotation = value, to, duration)
                    .SetReference(rigidbody);

        public static Tween TweenSleepThreshold(this Rigidbody rigidbody, float to, float duration) =>
            Tweening.To(rigidbody, (target) => target.sleepThreshold, (target, value) => target.sleepThreshold = value, to, duration)
                    .SetReference(rigidbody);
    }

}
