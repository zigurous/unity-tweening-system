using UnityEngine;

namespace Zigurous.Tweening
{
    public static class WindZoneTweens
    {
        public static Tween TweenRadius(this WindZone windZone, float to, float duration) =>
            Tweening.To(windZone, (target) => target.radius, (target, value) => target.radius = value, to, duration)
                    .SetReference(windZone);

        public static Tween TweenWindMain(this WindZone windZone, float to, float duration) =>
            Tweening.To(windZone, (target) => target.windMain, (target, value) => target.windMain = value, to, duration)
                    .SetReference(windZone);

        public static Tween TweenWindTurbulence(this WindZone windZone, float to, float duration) =>
            Tweening.To(windZone, (target) => target.windTurbulence, (target, value) => target.windTurbulence = value, to, duration)
                    .SetReference(windZone);

        public static Tween TweenWindPulseMagnitude(this WindZone windZone, float to, float duration) =>
            Tweening.To(windZone, (target) => target.windPulseMagnitude, (target, value) => target.windPulseMagnitude = value, to, duration)
                    .SetReference(windZone);

        public static Tween TweenWindPulseFrequency(this WindZone windZone, float to, float duration) =>
            Tweening.To(windZone, (target) => target.windPulseFrequency, (target, value) => target.windPulseFrequency = value, to, duration)
                    .SetReference(windZone);
    }

}
