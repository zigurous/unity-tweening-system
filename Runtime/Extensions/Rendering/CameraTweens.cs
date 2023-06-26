using UnityEngine;

namespace Zigurous.Tweening
{
    public static class CameraTweens
    {
        public static Tween TweenBackgroundColor(this Camera camera, Color to, float duration) =>
            Tweening.To(camera, (source) => source.backgroundColor, (source, value) => source.backgroundColor = value, to, duration)
                    .SetTarget(camera);

        public static Tween TweenAspectRatio(this Camera camera, float to, float duration) =>
            Tweening.To(camera, (source) => source.aspect, (source, value) => source.aspect = value, to, duration)
                    .SetTarget(camera);

        public static Tween TweenFieldOfView(this Camera camera, float to, float duration) =>
            Tweening.To(camera, (source) => source.fieldOfView, (source, value) => source.fieldOfView = value, to, duration)
                    .SetTarget(camera);

        public static Tween TweenNearClipPlane(this Camera camera, float to, float duration) =>
            Tweening.To(camera, (source) => source.nearClipPlane, (source, value) => source.nearClipPlane = value, to, duration)
                    .SetTarget(camera);

        public static Tween TweenFarClipPlane(this Camera camera, float to, float duration) =>
            Tweening.To(camera, (source) => source.farClipPlane, (source, value) => source.farClipPlane = value, to, duration)
                    .SetTarget(camera);

        public static Tween TweenOrthographicSize(this Camera camera, float to, float duration) =>
            Tweening.To(camera, (source) => source.orthographicSize, (source, value) => source.orthographicSize = value, to, duration)
                    .SetTarget(camera);

        public static Tween TweenSensorSize(this Camera camera, Vector2 to, float duration) =>
            Tweening.To(camera, (source) => source.sensorSize, (source, value) => source.sensorSize = value, to, duration)
                    .SetTarget(camera);

        public static Tween TweenFocalLength(this Camera camera, float to, float duration) =>
            Tweening.To(camera, (source) => source.focalLength, (source, value) => source.focalLength = value, to, duration)
                    .SetTarget(camera);

        public static Tween TweenStereoConvergence(this Camera camera, float to, float duration) =>
            Tweening.To(camera, (source) => source.stereoConvergence, (source, value) => source.stereoConvergence = value, to, duration)
                    .SetTarget(camera);

        public static Tween TweenStereoSeparation(this Camera camera, float to, float duration) =>
            Tweening.To(camera, (source) => source.stereoSeparation, (source, value) => source.stereoSeparation = value, to, duration)
                    .SetTarget(camera);

        public static Tween TweenLensShift(this Camera camera, Vector2 to, float duration) =>
            Tweening.To(camera, (source) => source.lensShift, (source, value) => source.lensShift = value, to, duration)
                    .SetTarget(camera);

        public static Tween TweenRect(this Camera camera, Rect to, float duration) =>
            Tweening.To(camera, (source) => source.rect, (source, value) => source.rect = value, to, duration)
                    .SetTarget(camera);

        public static Tween TweenPixelRect(this Camera camera, Rect to, float duration) =>
            Tweening.To(camera, (source) => source.pixelRect, (source, value) => source.pixelRect = value, to, duration)
                    .SetTarget(camera);

        public static Tween TweenDepth(this Camera camera, float to, float duration) =>
            Tweening.To(camera, (source) => source.depth, (source, value) => source.depth = value, to, duration)
                    .SetTarget(camera);
    }

}
