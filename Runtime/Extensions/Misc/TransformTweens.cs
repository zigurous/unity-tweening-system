using UnityEngine;

namespace Zigurous.Tweening
{
    public static class TransformTweens
    {
        public static Tween TweenPosition(this Transform transform, Vector3 to, float duration) =>
            Tweening.To(transform, (source) => source.position, (source, value) => source.position = value, to, duration)
                    .SetTarget(transform);

        public static Tween TweenPositionX(this Transform transform, float to, float duration) =>
            Tweening.To(transform, (source) => source.position.x, (source, value) => source.position = new Vector3(value, source.position.y, source.position.z), to, duration)
                    .SetTarget(transform);

        public static Tween TweenPositionY(this Transform transform, float to, float duration) =>
            Tweening.To(transform, (source) => source.position.y, (source, value) => source.position = new Vector3(source.position.x, value, source.position.z), to, duration)
                    .SetTarget(transform);

        public static Tween TweenPositionZ(this Transform transform, float to, float duration) =>
            Tweening.To(transform, (source) => source.position.z, (source, value) => source.position = new Vector3(source.position.x, source.position.y, value), to, duration)
                    .SetTarget(transform);

        public static Tween TweenLocalPosition(this Transform transform, Vector3 to, float duration) =>
            Tweening.To(transform, (source) => source.localPosition, (source, value) => source.localPosition = value, to, duration)
                    .SetTarget(transform);

        public static Tween TweenLocalPositionX(this Transform transform, float to, float duration) =>
            Tweening.To(transform, (source) => source.localPosition.x, (source, value) => source.localPosition = new Vector3(value, source.localPosition.y, source.localPosition.z), to, duration)
                    .SetTarget(transform);

        public static Tween TweenLocalPositionY(this Transform transform, float to, float duration) =>
            Tweening.To(transform, (source) => source.localPosition.y, (source, value) => source.localPosition = new Vector3(source.localPosition.x, value, source.localPosition.z), to, duration)
                    .SetTarget(transform);

        public static Tween TweenLocalPositionZ(this Transform transform, float to, float duration) =>
            Tweening.To(transform, (source) => source.localPosition.z, (source, value) => source.localPosition = new Vector3(source.localPosition.x, source.localPosition.y, value), to, duration)
                    .SetTarget(transform);

        public static Tween TweenScale(this Transform transform, Vector3 to, float duration) =>
            Tweening.To(transform, (source) => source.localScale, (source, value) => source.localScale = value, to, duration)
                    .SetTarget(transform);

        public static Tween TweenScaleX(this Transform transform, float to, float duration) =>
            Tweening.To(transform, (source) => source.localScale.x, (source, value) => source.localScale = new Vector3(value, source.localScale.y, source.localScale.z), to, duration)
                    .SetTarget(transform);

        public static Tween TweenScaleY(this Transform transform, float to, float duration) =>
            Tweening.To(transform, (source) => source.localScale.y, (source, value) => source.localScale = new Vector3(source.localScale.x, value, source.localScale.z), to, duration)
                    .SetTarget(transform);

        public static Tween TweenScaleZ(this Transform transform, float to, float duration) =>
            Tweening.To(transform, (source) => source.localScale.z, (source, value) => source.localScale = new Vector3(source.localScale.x, source.localScale.y, value), to, duration)
                    .SetTarget(transform);

        public static Tween TweenRotation(this Transform transform, Quaternion to, float duration) =>
            Tweening.To(transform, (source) => source.rotation, (source, value) => source.rotation = value, to, duration)
                    .SetTarget(transform);

        public static Tween TweenLocalRotation(this Transform transform, Quaternion to, float duration) =>
            Tweening.To(transform, (source) => source.localRotation, (source, value) => source.localRotation = value, to, duration)
                    .SetTarget(transform);

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
