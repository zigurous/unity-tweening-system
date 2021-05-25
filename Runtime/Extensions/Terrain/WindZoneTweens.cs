using UnityEngine;

namespace Zigurous.Tweening
{
    public static class WindZoneTweens
    {
        public static Tween TweenRadius(this WindZone windZone, float to, float duration) =>
            Tweening.To(getter: () => windZone.radius,
                        setter: radius => windZone.radius = radius,
                        to, duration).SetTarget(windZone);

        public static Tween TweenWindMain(this WindZone windZone, float to, float duration) =>
            Tweening.To(getter: () => windZone.windMain,
                        setter: windMain => windZone.windMain = windMain,
                        to, duration).SetTarget(windZone);

        public static Tween TweenWindTurbulence(this WindZone windZone, float to, float duration) =>
            Tweening.To(getter: () => windZone.windTurbulence,
                        setter: windTurbulence => windZone.windTurbulence = windTurbulence,
                        to, duration).SetTarget(windZone);

        public static Tween TweenWindPulseMagnitude(this WindZone windZone, float to, float duration) =>
            Tweening.To(getter: () => windZone.windPulseMagnitude,
                        setter: windPulseMagnitude => windZone.windPulseMagnitude = windPulseMagnitude,
                        to, duration).SetTarget(windZone);

        public static Tween TweenWindPulseFrequency(this WindZone windZone, float to, float duration) =>
            Tweening.To(getter: () => windZone.windPulseFrequency,
                        setter: windPulseFrequency => windZone.windPulseFrequency = windPulseFrequency,
                        to, duration).SetTarget(windZone);

    }

}
