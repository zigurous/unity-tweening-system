using UnityEngine;

namespace Zigurous.Tweening
{
    public static class ProjectorTweens
    {
        public static Tween TweenNearClipPlane(this Projector projector, float to, float duration) =>
            Tweening.To(projector, (source) => source.nearClipPlane, (source, value) => source.nearClipPlane = value, to, duration)
                    .SetTarget(projector);

        public static Tween TweenFarClipPlane(this Projector projector, float to, float duration) =>
            Tweening.To(projector, (source) => source.farClipPlane, (source, value) => source.farClipPlane = value, to, duration)
                    .SetTarget(projector);

        public static Tween TweenFieldOfView(this Projector projector, float to, float duration) =>
            Tweening.To(projector, (source) => source.fieldOfView, (source, value) => source.fieldOfView = value, to, duration)
                    .SetTarget(projector);

        public static Tween TweenAspectRatio(this Projector projector, float to, float duration) =>
            Tweening.To(projector, (source) => source.aspectRatio, (source, value) => source.aspectRatio = value, to, duration)
                    .SetTarget(projector);

        public static Tween TweenOrthographicSize(this Projector projector, float to, float duration) =>
            Tweening.To(projector, (source) => source.orthographicSize, (source, value) => source.orthographicSize = value, to, duration)
                    .SetTarget(projector);
    }

}
