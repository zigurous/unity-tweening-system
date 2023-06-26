using UnityEngine;

namespace Zigurous.Tweening
{
    public static class AnimatorTweens
    {
        public static Tween TweenSpeed(this Animator animator, float to, float duration) =>
            Tweening.To(animator, (source) => source.speed, (source, value) => source.speed = value, to, duration)
                    .SetTarget(animator);

        public static Tween TweenPlaybackTime(this Animator animator, float to, float duration) =>
            Tweening.To(animator, (source) => source.playbackTime, (source, value) => source.playbackTime = value, to, duration)
                    .SetTarget(animator);

        public static Tween TweenBodyRotation(this Animator animator, Quaternion to, float duration) =>
            Tweening.To(animator, (source) => source.bodyRotation, (source, value) => source.bodyRotation = value, to, duration)
                    .SetTarget(animator);

        public static Tween TweenBodyPosition(this Animator animator, Vector3 to, float duration) =>
            Tweening.To(animator, (source) => source.bodyPosition, (source, value) => source.bodyPosition = value, to, duration)
                    .SetTarget(animator);

        public static Tween TweenRootRotation(this Animator animator, Quaternion to, float duration) =>
            Tweening.To(animator, (source) => source.rootRotation, (source, value) => source.rootRotation = value, to, duration)
                    .SetTarget(animator);

        public static Tween TweenRootPosition(this Animator animator, Vector3 to, float duration) =>
            Tweening.To(animator, (source) => source.rootPosition, (source, value) => source.rootPosition = value, to, duration)
                    .SetTarget(animator);

        public static Tween TweenFeetPivotActive(this Animator animator, float to, float duration) =>
            Tweening.To(animator, (source) => source.feetPivotActive, (source, value) => source.feetPivotActive = value, to, duration)
                    .SetTarget(animator);
    }

}
