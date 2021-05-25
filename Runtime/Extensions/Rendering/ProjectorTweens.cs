using UnityEngine;

namespace Zigurous.Tweening
{
    public static class ProjectorTweens
    {
        public static Tween TweenNearClipPlane(this Projector projector, float to, float duration) =>
            Tweening.To(getter: () => projector.nearClipPlane,
                        setter: nearClipPlane => projector.nearClipPlane = nearClipPlane,
                        to, duration).SetTarget(projector);

        public static Tween TweenFarClipPlane(this Projector projector, float to, float duration) =>
            Tweening.To(getter: () => projector.farClipPlane,
                        setter: farClipPlane => projector.farClipPlane = farClipPlane,
                        to, duration).SetTarget(projector);

        public static Tween TweenFieldOfView(this Projector projector, float to, float duration) =>
            Tweening.To(getter: () => projector.fieldOfView,
                        setter: fieldOfView => projector.fieldOfView = fieldOfView,
                        to, duration).SetTarget(projector);

        public static Tween TweenAspectRatio(this Projector projector, float to, float duration) =>
            Tweening.To(getter: () => projector.aspectRatio,
                        setter: aspectRatio => projector.aspectRatio = aspectRatio,
                        to, duration).SetTarget(projector);

        public static Tween TweenOrthographicSize(this Projector projector, float to, float duration) =>
            Tweening.To(getter: () => projector.orthographicSize,
                        setter: orthographicSize => projector.orthographicSize = orthographicSize,
                        to, duration).SetTarget(projector);

    }

}
