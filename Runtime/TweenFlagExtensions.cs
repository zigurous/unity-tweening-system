namespace Zigurous.Tweening
{
    /// <summary>
    /// Extension methods for <see cref="Tween.Flag"/>.
    /// </summary>
    internal static class TweenFlagExtensions
    {
        /// <summary>
        /// Checks if the flags has a specified flag.
        /// </summary>
        /// <param name="flags">The flags to check.</param>
        /// <param name="other">The other flag to check for.</param>
        /// <returns>True if the flags has the specified flag, false otherwise.</returns>
        public static bool Has(this Tween.Flag flags, Tween.Flag other)
        {
            return ((int)flags & (int)other) == (int)other;
        }

        /// <summary>
        /// Checks if the flags has any of the other specified flags.
        /// </summary>
        /// <param name="flags">The flags to check.</param>
        /// <param name="other">The other flags to check for.</param>
        /// <returns>True if the flags has the specified flag, false otherwise.</returns>
        public static bool HasAny(this Tween.Flag flags, Tween.Flag other)
        {
            return ((int)flags & (int)other) != 0;
        }

    }

}
