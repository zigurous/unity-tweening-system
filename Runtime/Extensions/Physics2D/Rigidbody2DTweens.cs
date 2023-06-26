using UnityEngine;

namespace Zigurous.Tweening
{
    public static class Rigidbody2DTweens
    {
        public static Tween TweenPosition(this Rigidbody2D rigidbody, Vector2 to, float duration) =>
            Tweening.To(rigidbody, (source) => source.position, (source, value) => source.position = value, to, duration)
                    .SetTarget(rigidbody);

        public static Tween TweenRotation(this Rigidbody2D rigidbody, float to, float duration) =>
            Tweening.To(rigidbody, (source) => source.rotation, (source, value) => source.rotation = value, to, duration)
                    .SetTarget(rigidbody);

        public static Tween TweenVelocity(this Rigidbody2D rigidbody, Vector2 to, float duration) =>
            Tweening.To(rigidbody, (source) => source.velocity, (source, value) => source.velocity = value, to, duration)
                    .SetTarget(rigidbody);

        public static Tween TweenAngularVelocity(this Rigidbody2D rigidbody, float to, float duration) =>
            Tweening.To(rigidbody, (source) => source.angularVelocity, (source, value) => source.angularVelocity = value, to, duration)
                    .SetTarget(rigidbody);

        public static Tween TweenMass(this Rigidbody2D rigidbody, float to, float duration) =>
            Tweening.To(rigidbody, (source) => source.mass, (source, value) => source.mass = value, to, duration)
                    .SetTarget(rigidbody);

        public static Tween TweenCenterOfMass(this Rigidbody2D rigidbody, Vector2 to, float duration) =>
            Tweening.To(rigidbody, (source) => source.centerOfMass, (source, value) => source.centerOfMass = value, to, duration)
                    .SetTarget(rigidbody);

        public static Tween TweenDrag(this Rigidbody2D rigidbody, float to, float duration) =>
            Tweening.To(rigidbody, (source) => source.drag, (source, value) => source.drag = value, to, duration)
                    .SetTarget(rigidbody);

        public static Tween TweenAngularDrag(this Rigidbody2D rigidbody, float to, float duration) =>
            Tweening.To(rigidbody, (source) => source.angularDrag, (source, value) => source.angularDrag = value, to, duration)
                    .SetTarget(rigidbody);

        public static Tween TweenInertia(this Rigidbody2D rigidbody, float to, float duration) =>
            Tweening.To(rigidbody, (source) => source.inertia, (source, value) => source.inertia = value, to, duration)
                    .SetTarget(rigidbody);

        public static Tween TweenGravityScale(this Rigidbody2D rigidbody, float to, float duration) =>
            Tweening.To(rigidbody, (source) => source.gravityScale, (source, value) => source.gravityScale = value, to, duration)
                    .SetTarget(rigidbody);
    }

}
