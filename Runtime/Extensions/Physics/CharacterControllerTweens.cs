using UnityEngine;

namespace Zigurous.Tweening
{
    public static class CharacterControllerTweens
    {
        public static Tween TweenCenter(this CharacterController character, Vector3 to, float duration) =>
            Tweening.To(character, (target) => target.center, (target, value) => target.center = value, to, duration)
                    .SetReference(character);

        public static Tween TweenRadius(this CharacterController character, float to, float duration) =>
            Tweening.To(character, (target) => target.radius, (target, value) => target.radius = value, to, duration)
                    .SetReference(character);

        public static Tween TweenHeight(this CharacterController character, float to, float duration) =>
            Tweening.To(character, (target) => target.height, (target, value) => target.height = value, to, duration)
                    .SetReference(character);

        public static Tween TweenSlopeLimit(this CharacterController character, float to, float duration) =>
            Tweening.To(character, (target) => target.slopeLimit, (target, value) => target.slopeLimit = value, to, duration)
                    .SetReference(character);

        public static Tween TweenStepOffset(this CharacterController character, float to, float duration) =>
            Tweening.To(character, (target) => target.stepOffset, (target, value) => target.stepOffset = value, to, duration)
                    .SetReference(character);

        public static Tween TweenSkinWidth(this CharacterController character, float to, float duration) =>
            Tweening.To(character, (target) => target.skinWidth, (target, value) => target.skinWidth = value, to, duration)
                    .SetReference(character);

        public static Tween TweenMinMoveDistance(this CharacterController character, float to, float duration) =>
            Tweening.To(character, (target) => target.minMoveDistance, (target, value) => target.minMoveDistance = value, to, duration)
                    .SetReference(character);
    }

}
