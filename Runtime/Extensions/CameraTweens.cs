using UnityEngine;

namespace Zigurous.TweenEngine
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

        public static Tween TweenDepth(this Camera camera, float to, float duration) =>
            Tweening.To(getter: () => camera.depth,
                        setter: depth => camera.depth = depth,
                        to, duration).SetTarget(camera);

    }

}
