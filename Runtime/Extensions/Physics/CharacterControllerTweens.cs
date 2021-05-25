using UnityEngine;

namespace Zigurous.Tweening
{
    public static class CharacterControllerTweens
    {
        public static Tween TweenCenter(this CharacterController character, Vector3 to, float duration) =>
            Tweening.To(getter: () => character.center,
                        setter: center => character.center = center,
                        to, duration).SetTarget(character);

        public static Tween TweenRadius(this CharacterController character, float to, float duration) =>
            Tweening.To(getter: () => character.radius,
                        setter: radius => character.radius = radius,
                        to, duration).SetTarget(character);

        public static Tween TweenHeight(this CharacterController character, float to, float duration) =>
            Tweening.To(getter: () => character.height,
                        setter: height => character.height = height,
                        to, duration).SetTarget(character);

        public static Tween TweenSlopeLimit(this CharacterController character, float to, float duration) =>
            Tweening.To(getter: () => character.slopeLimit,
                        setter: slopeLimit => character.slopeLimit = slopeLimit,
                        to, duration).SetTarget(character);

        public static Tween TweenStepOffset(this CharacterController character, float to, float duration) =>
            Tweening.To(getter: () => character.stepOffset,
                        setter: stepOffset => character.stepOffset = stepOffset,
                        to, duration).SetTarget(character);

        public static Tween TweenSkinWidth(this CharacterController character, float to, float duration) =>
            Tweening.To(getter: () => character.skinWidth,
                        setter: skinWidth => character.skinWidth = skinWidth,
                        to, duration).SetTarget(character);

        public static Tween TweenMinMoveDistance(this CharacterController character, float to, float duration) =>
            Tweening.To(getter: () => character.minMoveDistance,
                        setter: minMoveDistance => character.minMoveDistance = minMoveDistance,
                        to, duration).SetTarget(character);

    }

}
