namespace Zigurous.Tweening
{
    /// <summary>
    /// Extension methods for <see cref="Tween.Flag"/>.
    /// </summary>
    internal static class TweenFlagExtensions
    {
        /// <summary>
        /// Checks if the flags contains the specified flag
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="flags">The flags to check.</param>
        /// <param name="other">The other flag to check for.</param>
        public static bool Has(this Tween.Flag flags, Tween.Flag other) {
            return ((int)flags & (int)other) == (int)other;
        }

        /// <summary>
        /// Checks if the flags contains any flag of <paramref name="other"/>.
        /// </summary>
        /// <param name="flags">The flags to check.</param>
        /// <param name="other">The other flags to check for.</param>
        public static bool HasAny(this Tween.Flag flags, Tween.Flag other) {
            return ((int)flags & (int)other) != 0;
        }

    }

}
