using System.Collections.Generic;
using UnityEngine;

namespace Zigurous.Tweening
{
    /// <summary>
    /// Timing functions for every ease type. Easing functions specify the rate
    /// of change of a parameter over time.
    /// </summary>
    public static class EaseFunction
    {
        /// <summary>
        /// A function delegate that returns the value along a timing curve
        /// given the x-axis value, i.e., f(x).
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public delegate float TimingCurve(float x);

        /// <summary>
        /// A dictionary of every timing function classified by ease type.
        /// </summary>
        internal static Dictionary<Ease, TimingCurve> lookup = new Dictionary<Ease, TimingCurve>(32, new EaseEqualityComparer())
        {
            { Ease.Linear, Linear },

            { Ease.SineIn, SineIn },
            { Ease.SineOut, SineOut },
            { Ease.SineInOut, SineInOut },

            { Ease.CubicIn, CubicIn },
            { Ease.CubicOut, CubicOut },
            { Ease.CubicInOut, CubicInOut },

            { Ease.QuadIn, QuadIn },
            { Ease.QuadOut, QuadOut },
            { Ease.QuadInOut, QuadInOut },

            { Ease.QuartIn, QuartIn },
            { Ease.QuartOut, QuartOut },
            { Ease.QuartInOut, QuartInOut },

            { Ease.QuintIn, QuintIn },
            { Ease.QuintOut, QuintOut },
            { Ease.QuintInOut, QuintInOut },

            { Ease.ExpoIn, ExpoIn },
            { Ease.ExpoOut, ExpoOut },
            { Ease.ExpoInOut, ExpoInOut },

            { Ease.CircIn, CircIn },
            { Ease.CircOut, CircOut },
            { Ease.CircInOut, CircInOut },

            { Ease.BackIn, BackIn },
            { Ease.BackOut, BackOut },
            { Ease.BackInOut, BackInOut },

            { Ease.ElasticIn, ElasticIn },
            { Ease.ElasticOut, ElasticOut },
            { Ease.ElasticInOut, ElasticInOut },

            { Ease.BounceIn, BounceIn },
            { Ease.BounceOut, BounceOut },
            { Ease.BounceInOut, BounceInOut },
        };

        /// <summary>
        /// Evaulates f(x) using a Linear ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float Linear(float x)
        {
            return x;
        }

        /// <summary>
        /// Evaulates f(x) using a SineIn ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float SineIn(float x)
        {
            return 1.0f - Mathf.Cos(x * Mathf.PI / 2.0f);
        }

        /// <summary>
        /// Evaulates f(x) using a SineOut ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float SineOut(float x)
        {
            return Mathf.Sin(x * Mathf.PI / 2.0f);
        }

        /// <summary>
        /// Evaulates f(x) using a SineInOut ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float SineInOut(float x)
        {
            return -(Mathf.Cos(Mathf.PI * x) - 1.0f) / 2.0f;
        }

        /// <summary>
        /// Evaulates f(x) using a CubicIn ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float CubicIn(float x)
        {
            return x * x * x;
        }

        /// <summary>
        /// Evaulates f(x) using a CubicOut ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float CubicOut(float x)
        {
            return 1.0f - Mathf.Pow(1.0f - x, 3.0f);
        }

        /// <summary>
        /// Evaulates f(x) using a CubicInOut ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float CubicInOut(float x)
        {
            return x < 0.5f ?
                4.0f * x * x * x :
                1.0f - Mathf.Pow(-2.0f * x + 2.0f, 3.0f) / 2.0f;
        }

        /// <summary>
        /// Evaulates f(x) using a QuadIn ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float QuadIn(float x)
        {
            return x * x;
        }

        /// <summary>
        /// Evaulates f(x) using a QuadOut ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float QuadOut(float x)
        {
            return 1.0f - (1.0f - x) * (1.0f - x);
        }

        /// <summary>
        /// Evaulates f(x) using a QuadInOut ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float QuadInOut(float x)
        {
            return x < 0.5f ?
                2.0f * x * x :
                1.0f - Mathf.Pow(-2.0f * x + 2.0f, 2.0f) / 2.0f;

        }

        /// <summary>
        /// Evaulates f(x) using a QuartIn ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float QuartIn(float x)
        {
            return x * x * x * x;
        }

        /// <summary>
        /// Evaulates f(x) using a QuartOut ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float QuartOut(float x)
        {
            return 1.0f - Mathf.Pow(1.0f - x, 4.0f);
        }

        /// <summary>
        /// Evaulates f(x) using a QuartInOut ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float QuartInOut(float x)
        {
            return x < 0.5f ?
                8.0f * x * x * x * x :
                1.0f - Mathf.Pow(-2.0f * x + 2.0f, 4.0f) / 2.0f;
        }

        /// <summary>
        /// Evaulates f(x) using a QuintIn ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float QuintIn(float x)
        {
            return x * x * x * x * x;
        }

        /// <summary>
        /// Evaulates f(x) using a QuintOut ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float QuintOut(float x)
        {
            return 1.0f - Mathf.Pow(1.0f - x, 5.0f);
        }

        /// <summary>
        /// Evaulates f(x) using a QuintInOut ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float QuintInOut(float x)
        {
            return x < 0.5f ?
                16.0f * x * x * x * x * x :
                1.0f - Mathf.Pow(-2.0f * x + 2.0f, 5.0f) / 2.0f;
        }

        /// <summary>
        /// Evaulates f(x) using an ExpoIn ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float ExpoIn(float x)
        {
            return x <= 0.0f ? 0.0f : Mathf.Pow(2.0f, 10.0f * x - 10.0f);
        }

        /// <summary>
        /// Evaulates f(x) using an ExpoOut ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float ExpoOut(float x)
        {
            return x >= 1.0f ? 1.0f : 1.0f - Mathf.Pow(2.0f, -10.0f * x);
        }

        /// <summary>
        /// Evaulates f(x) using an ExpoInOut ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float ExpoInOut(float x)
        {
            return x <= 0.0f ? 0.0f : x >= 1.0f ? 1.0f : x < 0.5f ?
                Mathf.Pow(2.0f, 20.0f * x - 10.0f) / 2.0f :
                (2.0f - Mathf.Pow(2.0f, -20.0f * x + 10.0f)) / 2.0f;
        }

        /// <summary>
        /// Evaulates f(x) using a CircIn ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float CircIn(float x)
        {
            return 1.0f - Mathf.Sqrt(1.0f - Mathf.Pow(x, 2.0f));
        }

        /// <summary>
        /// Evaulates f(x) using a CircOut ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float CircOut(float x)
        {
            return Mathf.Sqrt(1.0f - Mathf.Pow(x - 1.0f, 2.0f));
        }

        /// <summary>
        /// Evaulates f(x) using a CircInOut ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float CircInOut(float x)
        {
            return x < 0.5f ?
                (1.0f - Mathf.Sqrt(1.0f - Mathf.Pow(2.0f * x, 2.0f))) / 2.0f :
                (Mathf.Sqrt(1.0f - Mathf.Pow(-2.0f * x + 2.0f, 2.0f)) + 1.0f) / 2.0f;
        }

        /// <summary>
        /// Evaulates f(x) using a BackIn ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float BackIn(float x)
        {
            return (Tweening.overshoot + 1.0f) * x * x * x - Tweening.overshoot * x * x;
        }

        /// <summary>
        /// Evaulates f(x) using a BackOut ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float BackOut(float x)
        {
            return 1.0f + (Tweening.overshoot + 1.0f) * Mathf.Pow(x - 1.0f, 3.0f) + Tweening.overshoot * Mathf.Pow(x - 1.0f, 2.0f);
        }

        /// <summary>
        /// Evaulates f(x) using a BackInOut ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float BackInOut(float x)
        {
            float c2 = Tweening.overshoot * 1.525f;
            return x < 0.5f ?
                (Mathf.Pow(2.0f * x, 2.0f) * ((c2 + 1.0f) * 2.0f * x - c2)) / 2.0f :
                (Mathf.Pow(2.0f * x - 2.0f, 2.0f) * ((c2 + 1.0f) * (x * 2.0f - 2.0f) + c2) + 2.0f) / 2.0f;
        }

        /// <summary>
        /// Evaulates f(x) using an ElasticIn ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float ElasticIn(float x)
        {
            return x <= 0.0f ? 0.0f : x >= 1.0f ? 1.0f :
                -Mathf.Pow(2.0f, 10.0f * x - 10.0f) * Mathf.Sin((x * 10.0f - 10.75f) * ((2.0f * Mathf.PI) / 3.0f));
        }

        /// <summary>
        /// Evaulates f(x) using an ElasticOut ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float ElasticOut(float x)
        {
            return x <= 0.0f ? 0.0f : x >= 1.0f ? 1.0f :
                Mathf.Pow(2.0f, -10.0f * x) * Mathf.Sin((x * 10.0f - 0.75f) * ((2.0f * Mathf.PI) / 3.0f)) + 1.0f;
        }

        /// <summary>
        /// Evaulates f(x) using an ElasticInOut ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float ElasticInOut(float x)
        {
            return x <= 0.0f ? 0.0f : x >= 1.0f ? 1.0f : x < 0.5f ?
                -(Mathf.Pow(2.0f, 20.0f * x - 10.0f) * Mathf.Sin((20.0f * x - 11.125f) * ((2.0f * Mathf.PI) / 4.5f))) / 2.0f :
                Mathf.Pow(2.0f, -20.0f * x + 10.0f) * Mathf.Sin((20.0f * x - 11.125f) * ((2.0f * Mathf.PI) / 4.5f)) / 2.0f + 1.0f;
        }

        /// <summary>
        /// Evaulates f(x) using a BounceIn ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float BounceIn(float x)
        {
            return 1.0f - BounceOut(1.0f - x);
        }

        /// <summary>
        /// Evaulates f(x) using a BounceOut ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float BounceOut(float x)
        {
            if (x < 1.0f / 2.75f) {
                return 7.5625f * x * x;
            } else if (x < 2.0f / 2.75f) {
                x -= (1.5f / 2.75f);
                return 7.5625f * x * x + 0.75f;
            } else if (x < 2.5f / 2.75f) {
                x -= (2.25f / 2.75f);
                return 7.5625f * x * x + 0.9375f;
            }

            x -= (2.625f / 2.75f);
            return 7.5625f * x * x + 0.984375f;
        }

        /// <summary>
        /// Evaulates f(x) using a BounceInOut ease.
        /// </summary>
        /// <param name="x">The x-axis number to evaluate.</param>
        public static float BounceInOut(float x)
        {
            return x < 0.5f ?
                (1.0f - BounceOut(1.0f - 2.0f * x)) / 2.0f :
                (1.0f + BounceOut(2.0f * x - 1.0f)) / 2.0f;
        }

    }

}
