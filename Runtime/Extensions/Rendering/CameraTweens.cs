using UnityEngine;

namespace Zigurous.Tweening
{
    public static class CameraTweens
    {
        public static Tween TweenBackgroundColor(this Camera camera, Color to, float duration) =>
            Tweening.To(getter: () => camera.backgroundColor,
                        setter: backgroundColor => camera.backgroundColor = backgroundColor,
                        to, duration).SetTarget(camera);

        public static Tween TweenAspectRatio(this Camera camera, float to, float duration) =>
            Tweening.To(getter: () => camera.aspect,
                        setter: aspect => camera.aspect = aspect,
                        to, duration).SetTarget(camera);

        public static Tween TweenFieldOfView(this Camera camera, float to, float duration) =>
            Tweening.To(getter: () => camera.fieldOfView,
                        setter: fieldOfView => camera.fieldOfView = fieldOfView,
                        to, duration).SetTarget(camera);

        public static Tween TweenNearClipPlane(this Camera camera, float to, float duration) =>
            Tweening.To(getter: () => camera.nearClipPlane,
                        setter: nearClipPlane => camera.nearClipPlane = nearClipPlane,
                        to, duration).SetTarget(camera);

        public static Tween TweenFarClipPlane(this Camera camera, float to, float duration) =>
            Tweening.To(getter: () => camera.farClipPlane,
                        setter: farClipPlane => camera.farClipPlane = farClipPlane,
                        to, duration).SetTarget(camera);

        public static Tween TweenOrthographicSize(this Camera camera, float to, float duration) =>
            Tweening.To(getter: () => camera.orthographicSize,
                        setter: orthographicSize => camera.orthographicSize = orthographicSize,
                        to, duration).SetTarget(camera);

        public static Tween TweenSensorSize(this Camera camera, Vector2 to, float duration) =>
            Tweening.To(getter: () => camera.sensorSize,
                        setter: sensorSize => camera.sensorSize = sensorSize,
                        to, duration).SetTarget(camera);

        public static Tween TweenFocalLength(this Camera camera, float to, float duration) =>
            Tweening.To(getter: () => camera.focalLength,
                        setter: focalLength => camera.focalLength = focalLength,
                        to, duration).SetTarget(camera);

        public static Tween TweenStereoConvergence(this Camera camera, float to, float duration) =>
            Tweening.To(getter: () => camera.stereoConvergence,
                        setter: stereoConvergence => camera.stereoConvergence = stereoConvergence,
                        to, duration).SetTarget(camera);

        public static Tween TweenStereoSeparation(this Camera camera, float to, float duration) =>
            Tweening.To(getter: () => camera.stereoSeparation,
                        setter: stereoSeparation => camera.stereoSeparation = stereoSeparation,
                        to, duration).SetTarget(camera);

        public static Tween TweenLensShift(this Camera camera, Vector2 to, float duration) =>
            Tweening.To(getter: () => camera.lensShift,
                        setter: lensShift => camera.lensShift = lensShift,
                        to, duration).SetTarget(camera);

        public static Tween TweenRect(this Camera camera, Rect to, float duration) =>
            Tweening.To(getter: () => camera.rect,
                        setter: rect => camera.rect = rect,
                        to, duration).SetTarget(camera);

        public static Tween TweenPixelRect(this Camera camera, Rect to, float duration) =>
            Tweening.To(getter: () => camera.pixelRect,
                        setter: pixelRect => camera.pixelRect = pixelRect,
                        to, duration).SetTarget(camera);

        public static Tween TweenDepth(this Camera camera, float to, float duration) =>
            Tweening.To(getter: () => camera.depth,
                        setter: depth => camera.depth = depth,
                        to, duration).SetTarget(camera);

    }

}
