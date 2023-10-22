using UnityEngine;

namespace Zigurous.Tweening
{
    /// <summary>
    /// Utility extension methods for colors.
    /// </summary>
    internal static class ColorExtensions
    {
        /// <summary>
        /// Returns a copy of the color with the red component changed.
        /// </summary>
        /// <param name="color">The color to change.</param>
        /// <param name="red">The new red component.</param>
        /// <returns>A copy of the color with the red component changed.</returns>
        public static Color WithRed(this Color color, float red)
        {
            return new Color(red, color.g, color.b, color.a);
        }

        /// <summary>
        /// Returns a copy of the color with the green component changed.
        /// </summary>
        /// <param name="color">The color to change.</param>
        /// <param name="green">The new green component.</param>
        /// <returns>A copy of the color with the green component changed.</returns>
        public static Color WithGreen(this Color color, float green)
        {
            return new Color(color.r, green, color.b, color.a);
        }

        /// <summary>
        /// Returns a copy of the color with the blue component changed.
        /// </summary>
        /// <param name="color">The color to change.</param>
        /// <param name="blue">The new blue component.</param>
        /// <returns>A copy of the color with the blue component changed.</returns>
        public static Color WithBlue(this Color color, float blue)
        {
            return new Color(color.r, color.g, blue, color.a);
        }

        /// <summary>
        /// Returns a copy of the color with the alpha component changed.
        /// </summary>
        /// <param name="color">The color to change.</param>
        /// <param name="alpha">The new alpha component.</param>
        /// <returns>A copy of the color with the alpha component changed.</returns>
        public static Color WithAlpha(this Color color, float alpha)
        {
            return new Color(color.r, color.g, color.b, alpha);
        }

    }

}
