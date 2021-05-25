using UnityEngine;

namespace Zigurous.Tweening
{
    public static class AnimatorTweens
    {
        public static Tween TweenSpeed(this Animator animator, float to, float duration) =>
            Tweening.To(getter: () => animator.speed,
                        setter: speed => animator.speed = speed,
                        to, duration).SetTarget(animator);

        public static Tween TweenPlaybackTime(this Animator animator, float to, float duration) =>
            Tweening.To(getter: () => animator.playbackTime,
                        setter: playbackTime => animator.playbackTime = playbackTime,
                        to, duration).SetTarget(animator);

        public static Tween TweenBodyRotation(this Animator animator, Quaternion to, float duration) =>
            Tweening.To(getter: () => animator.bodyRotation,
                        setter: bodyRotation => animator.bodyRotation = bodyRotation,
                        to, duration).SetTarget(animator);

        public static Tween TweenBodyPosition(this Animator animator, Vector3 to, float duration) =>
            Tweening.To(getter: () => animator.bodyPosition,
                        setter: bodyPosition => animator.bodyPosition = bodyPosition,
                        to, duration).SetTarget(animator);

        public static Tween TweenRootRotation(this Animator animator, Quaternion to, float duration) =>
            Tweening.To(getter: () => animator.rootRotation,
                        setter: rootRotation => animator.rootRotation = rootRotation,
                        to, duration).SetTarget(animator);

        public static Tween TweenRootPosition(this Animator animator, Vector3 to, float duration) =>
            Tweening.To(getter: () => animator.rootPosition,
                        setter: rootPosition => animator.rootPosition = rootPosition,
                        to, duration).SetTarget(animator);

        public static Tween TweenFeetPivotActive(this Animator animator, float to, float duration) =>
            Tweening.To(getter: () => animator.feetPivotActive,
                        setter: feetPivotActive => animator.feetPivotActive = feetPivotActive,
                        to, duration).SetTarget(animator);

    }

}
