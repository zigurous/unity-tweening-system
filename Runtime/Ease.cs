using System.Collections.Generic;

namespace Zigurous.Tweening
{
    /// <summary>
    /// An easing function type. Easing functions specify the rate of change of
    /// a parameter over time.
    /// </summary>
    public enum Ease : int
    {
        Linear,
        SineIn,
        SineOut,
        SineInOut,
        CubicIn,
        CubicOut,
        CubicInOut,
        QuadIn,
        QuadOut,
        QuadInOut,
        QuartIn,
        QuartOut,
        QuartInOut,
        QuintIn,
        QuintOut,
        QuintInOut,
        ExpoIn,
        ExpoOut,
        ExpoInOut,
        CircIn,
        CircOut,
        CircInOut,
        BackIn,
        BackOut,
        BackInOut,
        ElasticIn,
        ElasticOut,
        ElasticInOut,
        BounceIn,
        BounceOut,
        BounceInOut
    }

    /// <summary>
    /// Compares the equality of two <see cref="Ease"/> types.
    /// </summary>
    public sealed class EaseEqualityComparer : IEqualityComparer<Ease>
    {
        /// <summary>
        /// Returns true if the two <see cref="Ease"/> types are equal.
        /// </summary>
        /// <param name="x">The first ease to compare.</param>
        /// <param name="y">The second ease to compare.</param>
        public bool Equals(Ease x, Ease y) => x == y;

        /// <summary>
        /// Returns the hash code for the <see cref="Ease"/> type.
        /// </summary>
        /// <param name="ease">The ease to get the hash code for.</param>
        public int GetHashCode(Ease ease) => (int)ease;
    }

    /// <summary>
    /// Extension methods for <see cref="Ease"/>.
    /// </summary>
    public static class EaseExtensions
    {
        /// <summary>
        /// Returns the f(x) value using the ease function.
        /// </summary>
        /// <param name="ease">The ease function type.</param>
        /// <param name="x">The x-axis value to evaluate.</param>
        /// <returns>The interpolated value at <paramref name="x"/>.</returns>
        public static float ValueAt(this Ease ease, float x)
        {
            return EaseFunction.lookup[ease](x);
        }

    }

}
