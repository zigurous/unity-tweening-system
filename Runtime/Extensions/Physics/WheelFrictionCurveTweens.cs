using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class WheelFrictionCurveTweens
    {
        public static Tween TweenExtremumSlip(this WheelFrictionCurve curve, float to, float duration) =>
            Tweening.To(getter: () => curve.extremumSlip,
                        setter: extremumSlip => curve.extremumSlip = extremumSlip,
                        to, duration).SetTarget(curve);

        public static Tween TweenExtremumValue(this WheelFrictionCurve curve, float to, float duration) =>
            Tweening.To(getter: () => curve.extremumValue,
                        setter: extremumValue => curve.extremumValue = extremumValue,
                        to, duration).SetTarget(curve);

        public static Tween TweenAsymptoteSlip(this WheelFrictionCurve curve, float to, float duration) =>
            Tweening.To(getter: () => curve.asymptoteSlip,
                        setter: asymptoteSlip => curve.asymptoteSlip = asymptoteSlip,
                        to, duration).SetTarget(curve);

        public static Tween TweenAsymptoteValue(this WheelFrictionCurve curve, float to, float duration) =>
            Tweening.To(getter: () => curve.asymptoteValue,
                        setter: asymptoteValue => curve.asymptoteValue = asymptoteValue,
                        to, duration).SetTarget(curve);

        public static Tween TweenStiffness(this WheelFrictionCurve curve, float to, float duration) =>
            Tweening.To(getter: () => curve.stiffness,
                        setter: stiffness => curve.stiffness = stiffness,
                        to, duration).SetTarget(curve);

    }

}
