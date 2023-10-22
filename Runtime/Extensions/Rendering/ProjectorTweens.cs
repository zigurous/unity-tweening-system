using UnityEngine;

namespace Zigurous.Tweening
{
    public static class ProjectorTweens
    {
        public static Tween TweenNearClipPlane(this Projector projector, float to, float duration) =>
            Tweening.To(projector, (target) => target.nearClipPlane, (target, value) => target.nearClipPlane = value, to, duration)
                    .SetReference(projector);

        public static Tween TweenFarClipPlane(this Projector projector, float to, float duration) =>
            Tweening.To(projector, (target) => target.farClipPlane, (target, value) => target.farClipPlane = value, to, duration)
                    .SetReference(projector);

        public static Tween TweenFieldOfView(this Projector projector, float to, float duration) =>
            Tweening.To(projector, (target) => target.fieldOfView, (target, value) => target.fieldOfView = value, to, duration)
                    .SetReference(projector);

        public static Tween TweenAspectRatio(this Projector projector, float to, float duration) =>
            Tweening.To(projector, (target) => target.aspectRatio, (target, value) => target.aspectRatio = value, to, duration)
                    .SetReference(projector);

        public static Tween TweenOrthographicSize(this Projector projector, float to, float duration) =>
            Tweening.To(projector, (target) => target.orthographicSize, (target, value) => target.orthographicSize = value, to, duration)
                    .SetReference(projector);
    }

}
