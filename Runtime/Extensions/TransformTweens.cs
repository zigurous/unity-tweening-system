using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public static class TransformTweens
    {
        public static Tween TweenPosition(this Transform transform, Vector3 to, float duration)
        {
            Vector3 from = transform.position;
            return Tweener.To(
                getter: () => { from = transform.position; return 0.0f; },
                setter: t => { transform.position = Vector3.Lerp(from, to, t); },
                endValue: 1.0f, duration).SetTarget(transform);
        }

        public static Tween TweenPositionX(this Transform transform, float to, float duration) =>
            Tweener.To(getter: () => transform.position.x,
                       setter: x => transform.position = new Vector3(x, transform.position.y, transform.position.z),
                       to, duration).SetTarget(transform);

        public static Tween TweenPositionY(this Transform transform, float to, float duration) =>
            Tweener.To(getter: () => transform.position.y,
                       setter: y => transform.position = new Vector3(transform.position.x, y, transform.position.z),
                       to, duration).SetTarget(transform);

        public static Tween TweenPositionZ(this Transform transform, float to, float duration) =>
            Tweener.To(getter: () => transform.position.z,
                       setter: z => transform.position = new Vector3(transform.position.x, transform.position.y, z),
                       to, duration).SetTarget(transform);

        public static Tween TweenLocalPosition(this Transform transform, Vector3 to, float duration)
        {
            Vector3 from = transform.localPosition;
            return Tweener.To(
                getter: () => { from = transform.localPosition; return 0.0f; },
                setter: t => { transform.localPosition = Vector3.Lerp(from, to, t); },
                endValue: 1.0f, duration).SetTarget(transform);
        }

        public static Tween TweenLocalPositionX(this Transform transform, float to, float duration) =>
            Tweener.To(getter: () => transform.localPosition.x,
                       setter: x => transform.localPosition = new Vector3(x, transform.localPosition.y, transform.localPosition.z),
                       to, duration).SetTarget(transform);

        public static Tween TweenLocalPositionY(this Transform transform, float to, float duration) =>
            Tweener.To(getter: () => transform.localPosition.y,
                       setter: y => transform.localPosition = new Vector3(transform.localPosition.x, y, transform.localPosition.z),
                       to, duration).SetTarget(transform);

        public static Tween TweenLocalPositionZ(this Transform transform, float to, float duration) =>
            Tweener.To(getter: () => transform.localPosition.z,
                       setter: z => transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, z),
                       to, duration).SetTarget(transform);

        public static Tween TweenScale(this Transform transform, Vector3 to, float duration)
        {
            Vector3 from = transform.localScale;
            return Tweener.To(
                getter: () => { from = transform.localScale; return 0.0f; },
                setter: t => { transform.localScale = Vector3.Lerp(from, to, t); },
                endValue: 1.0f, duration).SetTarget(transform);
        }

        public static Tween TweenScaleX(this Transform transform, float to, float duration) =>
            Tweener.To(getter: () => transform.localScale.x,
                       setter: x => transform.localScale = new Vector3(x, transform.localScale.y, transform.localScale.z),
                       to, duration).SetTarget(transform);

        public static Tween TweenScaleY(this Transform transform, float to, float duration) =>
            Tweener.To(getter: () => transform.localScale.y,
                       setter: y => transform.localScale = new Vector3(transform.localScale.x, y, transform.localScale.z),
                       to, duration).SetTarget(transform);

        public static Tween TweenScaleZ(this Transform transform, float to, float duration) =>
            Tweener.To(getter: () => transform.localScale.z,
                       setter: z => transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, z),
                       to, duration).SetTarget(transform);

        public static Tween TweenRotation(this Transform transform, Quaternion to, float duration)
        {
            Quaternion from = transform.rotation;
            return Tweener.To(
                getter: () => { from = transform.rotation; return 0.0f; },
                setter: t => { transform.rotation = Quaternion.Lerp(from, to, t); },
                endValue: 1.0f, duration).SetTarget(transform);
        }

        public static Tween TweenEulerAngles(this Transform transform, Vector3 to, float duration) =>
            TweenRotation(transform, Quaternion.Euler(to), duration);

        public static Tween TweenEulerAnglesX(this Transform transform, float to, float duration) =>
            TweenRotation(transform, Quaternion.Euler(to, transform.eulerAngles.y, transform.eulerAngles.z), duration);

        public static Tween TweenEulerAnglesY(this Transform transform, float to, float duration) =>
            TweenRotation(transform, Quaternion.Euler(transform.eulerAngles.x, to, transform.eulerAngles.z), duration);

        public static Tween TweenEulerAnglesZ(this Transform transform, float to, float duration) =>
            TweenRotation(transform, Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, to), duration);

        public static Tween TweenLocalRotation(this Transform transform, Quaternion to, float duration)
        {
            Quaternion from = transform.localRotation;
            return Tweener.To(
                getter: () => { from = transform.localRotation; return 0.0f; },
                setter: t => { transform.localRotation = Quaternion.Lerp(from, to, t); },
                endValue: 1.0f, duration).SetTarget(transform);
        }

        public static Tween TweenLocalEulerAngles(this Transform transform, Vector3 to, float duration) =>
            TweenLocalRotation(transform, Quaternion.Euler(to), duration);

        public static Tween TweenLocalEulerAnglesX(this Transform transform, float to, float duration) =>
            TweenLocalRotation(transform, Quaternion.Euler(to, transform.localEulerAngles.y, transform.localEulerAngles.z), duration);

        public static Tween TweenLocalEulerAnglesY(this Transform transform, float to, float duration) =>
            TweenLocalRotation(transform, Quaternion.Euler(transform.localEulerAngles.x, to, transform.localEulerAngles.z), duration);

        public static Tween TweenLocalEulerAnglesZ(this Transform transform, float to, float duration) =>
            TweenLocalRotation(transform, Quaternion.Euler(transform.localEulerAngles.x, transform.localEulerAngles.y, to), duration);

    }

}
