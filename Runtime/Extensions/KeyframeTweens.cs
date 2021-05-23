using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class KeyframeTweens
    {
        public static Tween TweenTime(this Keyframe keyframe, float to, float duration) =>
            Tweening.To(getter: () => keyframe.time,
                        setter: time => keyframe.time = time,
                        to, duration).SetTarget(keyframe);

        public static Tween TweenValue(this Keyframe keyframe, float to, float duration) =>
            Tweening.To(getter: () => keyframe.value,
                        setter: value => keyframe.value = value,
                        to, duration).SetTarget(keyframe);

        public static Tween TweenInTangent(this Keyframe keyframe, float to, float duration) =>
            Tweening.To(getter: () => keyframe.inTangent,
                        setter: inTangent => keyframe.inTangent = inTangent,
                        to, duration).SetTarget(keyframe);

        public static Tween TweenOutTangent(this Keyframe keyframe, float to, float duration) =>
            Tweening.To(getter: () => keyframe.outTangent,
                        setter: outTangent => keyframe.outTangent = outTangent,
                        to, duration).SetTarget(keyframe);

        public static Tween TweenInWeight(this Keyframe keyframe, float to, float duration) =>
            Tweening.To(getter: () => keyframe.inWeight,
                        setter: inWeight => keyframe.inWeight = inWeight,
                        to, duration).SetTarget(keyframe);

        public static Tween TweenOutWeight(this Keyframe keyframe, float to, float duration) =>
            Tweening.To(getter: () => keyframe.outWeight,
                        setter: outWeight => keyframe.outWeight = outWeight,
                        to, duration).SetTarget(keyframe);

    }

}
