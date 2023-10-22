using UnityEngine.Video;

namespace Zigurous.Tweening
{
    public static class VideoPlayerTweens
    {
        public static Tween TweenFrame(this VideoPlayer videoPlayer, long to, float duration) =>
            Tweening.To(videoPlayer, (target) => target.frame, (target, value) => target.frame = value, to, duration)
                    .SetReference(videoPlayer);

        public static Tween TweenTime(this VideoPlayer videoPlayer, double to, float duration) =>
            Tweening.To(videoPlayer, (target) => target.time, (target, value) => target.time = value, to, duration)
                    .SetReference(videoPlayer);

        public static Tween TweenPlaybackSpeed(this VideoPlayer videoPlayer, float to, float duration) =>
            Tweening.To(videoPlayer, (target) => target.playbackSpeed, (target, value) => target.playbackSpeed = value, to, duration)
                    .SetReference(videoPlayer);

        public static Tween TweenExternalReferenceTime(this VideoPlayer videoPlayer, double to, float duration) =>
            Tweening.To(videoPlayer, (target) => target.externalReferenceTime, (target, value) => target.externalReferenceTime = value, to, duration)
                    .SetReference(videoPlayer);

        public static Tween TweenTargetCameraAlpha(this VideoPlayer videoPlayer, float to, float duration) =>
            Tweening.To(videoPlayer, (target) => target.targetCameraAlpha, (target, value) => target.targetCameraAlpha = value, to, duration)
                    .SetReference(videoPlayer);
    }

}
