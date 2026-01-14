using System;
using UnityEngine;

namespace Zigurous.Tweening
{
    public static class Rigidbody2DTweens
    {
        public static Tween TweenPosition(this Rigidbody2D rigidbody, Vector2 to, float duration) =>
            Tweening.To(rigidbody, (target) => target.position, (target, value) => target.position = value, to, duration)
                    .SetReference(rigidbody);

        public static Tween TweenRotation(this Rigidbody2D rigidbody, float to, float duration) =>
            Tweening.To(rigidbody, (target) => target.rotation, (target, value) => target.rotation = value, to, duration)
                    .SetReference(rigidbody);

        public static Tween TweenVelocity(this Rigidbody2D rigidbody, Vector2 to, float duration) =>
            Tweening.To(rigidbody, (target) => target.linearVelocity, (target, value) => target.linearVelocity = value, to, duration)
                    .SetReference(rigidbody);

        public static Tween TweenAngularVelocity(this Rigidbody2D rigidbody, float to, float duration) =>
            Tweening.To(rigidbody, (target) => target.angularVelocity, (target, value) => target.angularVelocity = value, to, duration)
                    .SetReference(rigidbody);

        public static Tween TweenMass(this Rigidbody2D rigidbody, float to, float duration) =>
            Tweening.To(rigidbody, (target) => target.mass, (target, value) => target.mass = value, to, duration)
                    .SetReference(rigidbody);

        public static Tween TweenCenterOfMass(this Rigidbody2D rigidbody, Vector2 to, float duration) =>
            Tweening.To(rigidbody, (target) => target.centerOfMass, (target, value) => target.centerOfMass = value, to, duration)
                    .SetReference(rigidbody);

        [Obsolete("This method is obsolete. Use TweenLinearDamping instead.")]
        public static Tween TweenDrag(this Rigidbody2D rigidbody, float to, float duration) =>
            Tweening.To(rigidbody, (target) => target.drag, (target, value) => target.drag = value, to, duration)
                    .SetReference(rigidbody);

        public static Tween TweenLinearDamping(this Rigidbody2D rigidbody, float to, float duration) =>
            Tweening.To(rigidbody, (target) => target.linearDamping, (target, value) => target.linearDamping = value, to, duration)
                    .SetReference(rigidbody);

        [Obsolete("This method is obsolete. Use TweenAngularDamping instead.")]
        public static Tween TweenAngularDrag(this Rigidbody2D rigidbody, float to, float duration) =>
            Tweening.To(rigidbody, (target) => target.angularDrag, (target, value) => target.angularDrag = value, to, duration)
                    .SetReference(rigidbody);

        public static Tween TweenAngularDamping(this Rigidbody2D rigidbody, float to, float duration) =>
            Tweening.To(rigidbody, (target) => target.angularDamping, (target, value) => target.angularDamping = value, to, duration)
                    .SetReference(rigidbody);

        public static Tween TweenInertia(this Rigidbody2D rigidbody, float to, float duration) =>
            Tweening.To(rigidbody, (target) => target.inertia, (target, value) => target.inertia = value, to, duration)
                    .SetReference(rigidbody);

        public static Tween TweenGravityScale(this Rigidbody2D rigidbody, float to, float duration) =>
            Tweening.To(rigidbody, (target) => target.gravityScale, (target, value) => target.gravityScale = value, to, duration)
                    .SetReference(rigidbody);
    }

}
