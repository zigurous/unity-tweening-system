using UnityEngine.Video;

namespace Zigurous.Tweening
{
    public static class VideoPlayerTweens
    {
        public static Tween TweenFrame(this VideoPlayer videoPlayer, long to, float duration) =>
            Tweening.To(getter: () => videoPlayer.frame,
                        setter: frame => videoPlayer.frame = frame,
                        to, duration).SetTarget(videoPlayer);

        public static Tween TweenTime(this VideoPlayer videoPlayer, double to, float duration) =>
            Tweening.To(getter: () => videoPlayer.time,
                        setter: time => videoPlayer.time = time,
                        to, duration).SetTarget(videoPlayer);

        public static Tween TweenPlaybackSpeed(this VideoPlayer videoPlayer, float to, float duration) =>
            Tweening.To(getter: () => videoPlayer.playbackSpeed,
                        setter: playbackSpeed => videoPlayer.playbackSpeed = playbackSpeed,
                        to, duration).SetTarget(videoPlayer);

        public static Tween TweenExternalReferenceTime(this VideoPlayer videoPlayer, double to, float duration) =>
            Tweening.To(getter: () => videoPlayer.externalReferenceTime,
                        setter: externalReferenceTime => videoPlayer.externalReferenceTime = externalReferenceTime,
                        to, duration).SetTarget(videoPlayer);

        public static Tween TweenTargetCameraAlpha(this VideoPlayer videoPlayer, float to, float duration) =>
            Tweening.To(getter: () => videoPlayer.targetCameraAlpha,
                        setter: targetCameraAlpha => videoPlayer.targetCameraAlpha = targetCameraAlpha,
                        to, duration).SetTarget(videoPlayer);

    }

}
