using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public static class CameraTweens
    {
        public static Tween TweenBackgroundColor(this Camera camera, Color to, float duration)
        {
            Color from = camera.backgroundColor;
            return Tweener.To(
                getter: () => { from = camera.backgroundColor; return 0.0f; },
                setter: t => { camera.backgroundColor = Color.Lerp(from, to, t); },
                endValue: 1.0f, duration).SetTarget(camera);
        }

        public static Tween TweenAspectRatio(this Camera camera, float to, float duration) =>
            Tweener.To(getter: () => camera.aspect,
                       setter: aspect => camera.aspect = aspect,
                       to, duration).SetTarget(camera);

        public static Tween TweenFieldOfView(this Camera camera, float to, float duration) =>
            Tweener.To(getter: () => camera.fieldOfView,
                       setter: fov => camera.fieldOfView = fov,
                       to, duration).SetTarget(camera);

        public static Tween TweenNearClipPlane(this Camera camera, float to, float duration) =>
            Tweener.To(getter: () => camera.nearClipPlane,
                       setter: distance => camera.nearClipPlane = distance,
                       to, duration).SetTarget(camera);

        public static Tween TweenFarClipPlane(this Camera camera, float to, float duration) =>
            Tweener.To(getter: () => camera.farClipPlane,
                       setter: distance => camera.farClipPlane = distance,
                       to, duration).SetTarget(camera);

        public static Tween TweenOrthographicSize(this Camera camera, float to, float duration) =>
            Tweener.To(getter: () => camera.orthographicSize,
                       setter: size => camera.orthographicSize = size,
                       to, duration).SetTarget(camera);

    }

}
