using UnityEngine.Video;

namespace Zigurous.Tweening
{
    public static class VideoPlayerTweens
    {
        public static Tween TweenFrame(this VideoPlayer videoPlayer, long to, float duration) =>
            Tweening.To(videoPlayer, (source) => source.frame, (source, value) => source.frame = value, to, duration)
                    .SetTarget(videoPlayer);

        public static Tween TweenTime(this VideoPlayer videoPlayer, double to, float duration) =>
            Tweening.To(videoPlayer, (source) => source.time, (source, value) => source.time = value, to, duration)
                    .SetTarget(videoPlayer);

        public static Tween TweenPlaybackSpeed(this VideoPlayer videoPlayer, float to, float duration) =>
            Tweening.To(videoPlayer, (source) => source.playbackSpeed, (source, value) => source.playbackSpeed = value, to, duration)
                    .SetTarget(videoPlayer);

        public static Tween TweenExternalReferenceTime(this VideoPlayer videoPlayer, double to, float duration) =>
            Tweening.To(videoPlayer, (source) => source.externalReferenceTime, (source, value) => source.externalReferenceTime = value, to, duration)
                    .SetTarget(videoPlayer);

        public static Tween TweenTargetCameraAlpha(this VideoPlayer videoPlayer, float to, float duration) =>
            Tweening.To(videoPlayer, (source) => source.targetCameraAlpha, (source, value) => source.targetCameraAlpha = value, to, duration)
                    .SetTarget(videoPlayer);
    }

}
