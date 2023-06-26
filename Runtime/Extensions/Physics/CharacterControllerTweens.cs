using UnityEngine;

namespace Zigurous.Tweening
{
    public static class CharacterControllerTweens
    {
        public static Tween TweenCenter(this CharacterController character, Vector3 to, float duration) =>
            Tweening.To(character, (source) => source.center, (source, value) => source.center = value, to, duration)
                    .SetTarget(character);

        public static Tween TweenRadius(this CharacterController character, float to, float duration) =>
            Tweening.To(character, (source) => source.radius, (source, value) => source.radius = value, to, duration)
                    .SetTarget(character);

        public static Tween TweenHeight(this CharacterController character, float to, float duration) =>
            Tweening.To(character, (source) => source.height, (source, value) => source.height = value, to, duration)
                    .SetTarget(character);

        public static Tween TweenSlopeLimit(this CharacterController character, float to, float duration) =>
            Tweening.To(character, (source) => source.slopeLimit, (source, value) => source.slopeLimit = value, to, duration)
                    .SetTarget(character);

        public static Tween TweenStepOffset(this CharacterController character, float to, float duration) =>
            Tweening.To(character, (source) => source.stepOffset, (source, value) => source.stepOffset = value, to, duration)
                    .SetTarget(character);

        public static Tween TweenSkinWidth(this CharacterController character, float to, float duration) =>
            Tweening.To(character, (source) => source.skinWidth, (source, value) => source.skinWidth = value, to, duration)
                    .SetTarget(character);

        public static Tween TweenMinMoveDistance(this CharacterController character, float to, float duration) =>
            Tweening.To(character, (source) => source.minMoveDistance, (source, value) => source.minMoveDistance = value, to, duration)
                    .SetTarget(character);
    }

}
