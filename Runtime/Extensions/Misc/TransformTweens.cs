using UnityEngine;

namespace Zigurous.Tweening
{
    public static class TransformTweens
    {
        public static Tween TweenPosition(this Transform transform, Vector3 to, float duration) =>
            Tweening.To(transform, (target) => target.position, (target, value) => target.position = value, to, duration)
                    .SetReference(transform);

        public static Tween TweenPositionX(this Transform transform, float to, float duration) =>
            Tweening.To(transform, (target) => target.position.x, (target, value) => target.position = new Vector3(value, target.position.y, target.position.z), to, duration)
                    .SetReference(transform);

        public static Tween TweenPositionY(this Transform transform, float to, float duration) =>
            Tweening.To(transform, (target) => target.position.y, (target, value) => target.position = new Vector3(target.position.x, value, target.position.z), to, duration)
                    .SetReference(transform);

        public static Tween TweenPositionZ(this Transform transform, float to, float duration) =>
            Tweening.To(transform, (target) => target.position.z, (target, value) => target.position = new Vector3(target.position.x, target.position.y, value), to, duration)
                    .SetReference(transform);

        public static Tween TweenLocalPosition(this Transform transform, Vector3 to, float duration) =>
            Tweening.To(transform, (target) => target.localPosition, (target, value) => target.localPosition = value, to, duration)
                    .SetReference(transform);

        public static Tween TweenLocalPositionX(this Transform transform, float to, float duration) =>
            Tweening.To(transform, (target) => target.localPosition.x, (target, value) => target.localPosition = new Vector3(value, target.localPosition.y, target.localPosition.z), to, duration)
                    .SetReference(transform);

        public static Tween TweenLocalPositionY(this Transform transform, float to, float duration) =>
            Tweening.To(transform, (target) => target.localPosition.y, (target, value) => target.localPosition = new Vector3(target.localPosition.x, value, target.localPosition.z), to, duration)
                    .SetReference(transform);

        public static Tween TweenLocalPositionZ(this Transform transform, float to, float duration) =>
            Tweening.To(transform, (target) => target.localPosition.z, (target, value) => target.localPosition = new Vector3(target.localPosition.x, target.localPosition.y, value), to, duration)
                    .SetReference(transform);

        public static Tween TweenScale(this Transform transform, Vector3 to, float duration) =>
            Tweening.To(transform, (target) => target.localScale, (target, value) => target.localScale = value, to, duration)
                    .SetReference(transform);

        public static Tween TweenScaleX(this Transform transform, float to, float duration) =>
            Tweening.To(transform, (target) => target.localScale.x, (target, value) => target.localScale = new Vector3(value, target.localScale.y, target.localScale.z), to, duration)
                    .SetReference(transform);

        public static Tween TweenScaleY(this Transform transform, float to, float duration) =>
            Tweening.To(transform, (target) => target.localScale.y, (target, value) => target.localScale = new Vector3(target.localScale.x, value, target.localScale.z), to, duration)
                    .SetReference(transform);

        public static Tween TweenScaleZ(this Transform transform, float to, float duration) =>
            Tweening.To(transform, (target) => target.localScale.z, (target, value) => target.localScale = new Vector3(target.localScale.x, target.localScale.y, value), to, duration)
                    .SetReference(transform);

        public static Tween TweenRotation(this Transform transform, Quaternion to, float duration) =>
            Tweening.To(transform, (target) => target.rotation, (target, value) => target.rotation = value, to, duration)
                    .SetReference(transform);

        public static Tween TweenLocalRotation(this Transform transform, Quaternion to, float duration) =>
            Tweening.To(transform, (target) => target.localRotation, (target, value) => target.localRotation = value, to, duration)
                    .SetReference(transform);

        public static Tween TweenEulerAngles(this Transform transform, Vector3 to, float duration) =>
            TweenRotation(transform, Quaternion.Euler(to), duration);

        public static Tween TweenEulerAnglesX(this Transform transform, float to, float duration) =>
            TweenRotation(transform, Quaternion.Euler(to, transform.eulerAngles.y, transform.eulerAngles.z), duration);

        public static Tween TweenEulerAnglesY(this Transform transform, float to, float duration) =>
            TweenRotation(transform, Quaternion.Euler(transform.eulerAngles.x, to, transform.eulerAngles.z), duration);

        public static Tween TweenEulerAnglesZ(this Transform transform, float to, float duration) =>
            TweenRotation(transform, Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, to), duration);

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
