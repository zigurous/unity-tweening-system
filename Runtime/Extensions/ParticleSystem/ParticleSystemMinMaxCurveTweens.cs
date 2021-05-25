using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class ParticleSystemMinMaxCurveTweens
    {
        public static Tween TweenConstant(this ParticleSystem.MinMaxCurve curve, float to, float duration) =>
            Tweening.To(getter: () => curve.constant,
                        setter: constant => curve.constant = constant,
                        to, duration).SetTarget(curve);

        public static Tween TweenConstantMin(this ParticleSystem.MinMaxCurve curve, float to, float duration) =>
            Tweening.To(getter: () => curve.constantMin,
                        setter: constantMin => curve.constantMin = constantMin,
                        to, duration).SetTarget(curve);

        public static Tween TweenConstantMax(this ParticleSystem.MinMaxCurve curve, float to, float duration) =>
            Tweening.To(getter: () => curve.constantMax,
                        setter: constantMax => curve.constantMax = constantMax,
                        to, duration).SetTarget(curve);

        public static Tween TweenCurveMultiplier(this ParticleSystem.MinMaxCurve curve, float to, float duration) =>
            Tweening.To(getter: () => curve.curveMultiplier,
                        setter: curveMultiplier => curve.curveMultiplier = curveMultiplier,
                        to, duration).SetTarget(curve);

    }

}
