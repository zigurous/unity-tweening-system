using UnityEngine;

namespace Zigurous.Tweening
{
    public static class Rigidbody2DTweens
    {
        public static Tween TweenPosition(this Rigidbody2D rigidbody, Vector2 to, float duration) =>
            Tweening.To(getter: () => rigidbody.position,
                        setter: position => rigidbody.position = position,
                        to, duration).SetTarget(rigidbody);

        public static Tween TweenRotation(this Rigidbody2D rigidbody, float to, float duration) =>
            Tweening.To(getter: () => rigidbody.rotation,
                        setter: rotation => rigidbody.rotation = rotation,
                        to, duration).SetTarget(rigidbody);

        public static Tween TweenVelocity(this Rigidbody2D rigidbody, Vector2 to, float duration) =>
            Tweening.To(getter: () => rigidbody.velocity,
                        setter: velocity => rigidbody.velocity = velocity,
                        to, duration).SetTarget(rigidbody);

        public static Tween TweenAngularVelocity(this Rigidbody2D rigidbody, float to, float duration) =>
            Tweening.To(getter: () => rigidbody.angularVelocity,
                        setter: angularVelocity => rigidbody.angularVelocity = angularVelocity,
                        to, duration).SetTarget(rigidbody);

        public static Tween TweenMass(this Rigidbody2D rigidbody, float to, float duration) =>
            Tweening.To(getter: () => rigidbody.mass,
                        setter: mass => rigidbody.mass = mass,
                        to, duration).SetTarget(rigidbody);

        public static Tween TweenCenterOfMass(this Rigidbody2D rigidbody, Vector2 to, float duration) =>
            Tweening.To(getter: () => rigidbody.centerOfMass,
                        setter: centerOfMass => rigidbody.centerOfMass = centerOfMass,
                        to, duration).SetTarget(rigidbody);

        public static Tween TweenDrag(this Rigidbody2D rigidbody, float to, float duration) =>
            Tweening.To(getter: () => rigidbody.drag,
                        setter: drag => rigidbody.drag = drag,
                        to, duration).SetTarget(rigidbody);

        public static Tween TweenAngularDrag(this Rigidbody2D rigidbody, float to, float duration) =>
            Tweening.To(getter: () => rigidbody.angularDrag,
                        setter: angularDrag => rigidbody.angularDrag = angularDrag,
                        to, duration).SetTarget(rigidbody);

        public static Tween TweenInertia(this Rigidbody2D rigidbody, float to, float duration) =>
            Tweening.To(getter: () => rigidbody.inertia,
                        setter: inertia => rigidbody.inertia = inertia,
                        to, duration).SetTarget(rigidbody);

        public static Tween TweenGravityScale(this Rigidbody2D rigidbody, float to, float duration) =>
            Tweening.To(getter: () => rigidbody.gravityScale,
                        setter: gravityScale => rigidbody.gravityScale = gravityScale,
                        to, duration).SetTarget(rigidbody);

    }

}
