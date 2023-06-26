using UnityEngine;

namespace Zigurous.Tweening
{
    public static class WindZoneTweens
    {
        public static Tween TweenRadius(this WindZone windZone, float to, float duration) =>
            Tweening.To(windZone, (source) => source.radius, (source, value) => source.radius = value, to, duration)
                    .SetTarget(windZone);

        public static Tween TweenWindMain(this WindZone windZone, float to, float duration) =>
            Tweening.To(windZone, (source) => source.windMain, (source, value) => source.windMain = value, to, duration)
                    .SetTarget(windZone);

        public static Tween TweenWindTurbulence(this WindZone windZone, float to, float duration) =>
            Tweening.To(windZone, (source) => source.windTurbulence, (source, value) => source.windTurbulence = value, to, duration)
                    .SetTarget(windZone);

        public static Tween TweenWindPulseMagnitude(this WindZone windZone, float to, float duration) =>
            Tweening.To(windZone, (source) => source.windPulseMagnitude, (source, value) => source.windPulseMagnitude = value, to, duration)
                    .SetTarget(windZone);

        public static Tween TweenWindPulseFrequency(this WindZone windZone, float to, float duration) =>
            Tweening.To(windZone, (source) => source.windPulseFrequency, (source, value) => source.windPulseFrequency = value, to, duration)
                    .SetTarget(windZone);
    }

}
