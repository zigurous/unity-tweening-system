using UnityEngine;

namespace Zigurous.Tweening
{
    public static class AnimatorTweens
    {
        public static Tween TweenSpeed(this Animator animator, float to, float duration) =>
            Tweening.To(animator, (target) => target.speed, (target, value) => target.speed = value, to, duration)
                    .SetReference(animator);

        public static Tween TweenPlaybackTime(this Animator animator, float to, float duration) =>
            Tweening.To(animator, (target) => target.playbackTime, (target, value) => target.playbackTime = value, to, duration)
                    .SetReference(animator);

        public static Tween TweenBodyRotation(this Animator animator, Quaternion to, float duration) =>
            Tweening.To(animator, (target) => target.bodyRotation, (target, value) => target.bodyRotation = value, to, duration)
                    .SetReference(animator);

        public static Tween TweenBodyPosition(this Animator animator, Vector3 to, float duration) =>
            Tweening.To(animator, (target) => target.bodyPosition, (target, value) => target.bodyPosition = value, to, duration)
                    .SetReference(animator);

        public static Tween TweenRootRotation(this Animator animator, Quaternion to, float duration) =>
            Tweening.To(animator, (target) => target.rootRotation, (target, value) => target.rootRotation = value, to, duration)
                    .SetReference(animator);

        public static Tween TweenRootPosition(this Animator animator, Vector3 to, float duration) =>
            Tweening.To(animator, (target) => target.rootPosition, (target, value) => target.rootPosition = value, to, duration)
                    .SetReference(animator);

        public static Tween TweenFeetPivotActive(this Animator animator, float to, float duration) =>
            Tweening.To(animator, (target) => target.feetPivotActive, (target, value) => target.feetPivotActive = value, to, duration)
                    .SetReference(animator);
    }

}
