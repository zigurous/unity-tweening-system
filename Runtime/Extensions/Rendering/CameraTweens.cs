using UnityEngine;

namespace Zigurous.Tweening
{
    public static class CameraTweens
    {
        public static Tween TweenBackgroundColor(this Camera camera, Color to, float duration) =>
            Tweening.To(camera, (target) => target.backgroundColor, (target, value) => target.backgroundColor = value, to, duration)
                    .SetReference(camera);

        public static Tween TweenAspectRatio(this Camera camera, float to, float duration) =>
            Tweening.To(camera, (target) => target.aspect, (target, value) => target.aspect = value, to, duration)
                    .SetReference(camera);

        public static Tween TweenFieldOfView(this Camera camera, float to, float duration) =>
            Tweening.To(camera, (target) => target.fieldOfView, (target, value) => target.fieldOfView = value, to, duration)
                    .SetReference(camera);

        public static Tween TweenNearClipPlane(this Camera camera, float to, float duration) =>
            Tweening.To(camera, (target) => target.nearClipPlane, (target, value) => target.nearClipPlane = value, to, duration)
                    .SetReference(camera);

        public static Tween TweenFarClipPlane(this Camera camera, float to, float duration) =>
            Tweening.To(camera, (target) => target.farClipPlane, (target, value) => target.farClipPlane = value, to, duration)
                    .SetReference(camera);

        public static Tween TweenOrthographicSize(this Camera camera, float to, float duration) =>
            Tweening.To(camera, (target) => target.orthographicSize, (target, value) => target.orthographicSize = value, to, duration)
                    .SetReference(camera);

        public static Tween TweenSensorSize(this Camera camera, Vector2 to, float duration) =>
            Tweening.To(camera, (target) => target.sensorSize, (target, value) => target.sensorSize = value, to, duration)
                    .SetReference(camera);

        public static Tween TweenFocalLength(this Camera camera, float to, float duration) =>
            Tweening.To(camera, (target) => target.focalLength, (target, value) => target.focalLength = value, to, duration)
                    .SetReference(camera);

        public static Tween TweenStereoConvergence(this Camera camera, float to, float duration) =>
            Tweening.To(camera, (target) => target.stereoConvergence, (target, value) => target.stereoConvergence = value, to, duration)
                    .SetReference(camera);

        public static Tween TweenStereoSeparation(this Camera camera, float to, float duration) =>
            Tweening.To(camera, (target) => target.stereoSeparation, (target, value) => target.stereoSeparation = value, to, duration)
                    .SetReference(camera);

        public static Tween TweenLensShift(this Camera camera, Vector2 to, float duration) =>
            Tweening.To(camera, (target) => target.lensShift, (target, value) => target.lensShift = value, to, duration)
                    .SetReference(camera);

        public static Tween TweenRect(this Camera camera, Rect to, float duration) =>
            Tweening.To(camera, (target) => target.rect, (target, value) => target.rect = value, to, duration)
                    .SetReference(camera);

        public static Tween TweenPixelRect(this Camera camera, Rect to, float duration) =>
            Tweening.To(camera, (target) => target.pixelRect, (target, value) => target.pixelRect = value, to, duration)
                    .SetReference(camera);

        public static Tween TweenDepth(this Camera camera, float to, float duration) =>
            Tweening.To(camera, (target) => target.depth, (target, value) => target.depth = value, to, duration)
                    .SetReference(camera);
    }

}
