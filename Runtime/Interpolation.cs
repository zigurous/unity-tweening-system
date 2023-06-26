using UnityEngine;

namespace Zigurous.Tweening
{
    /// <summary>
    /// Functions for interpolating values.
    /// </summary>
    public static class Interpolation
    {
        internal static readonly Interpolater<float> _float = Lerp;
        internal static readonly Interpolater<double> _double = Lerp;
        internal static readonly Interpolater<int> _int = Lerp;
        internal static readonly Interpolater<long> _long = Lerp;
        internal static readonly Interpolater<short> _short = Lerp;
        internal static readonly Interpolater<Vector2> _Vector2 = Lerp;
        internal static readonly Interpolater<Vector2Int> _Vector2Int = Lerp;
        internal static readonly Interpolater<Vector3> _Vector3 = Lerp;
        internal static readonly Interpolater<Vector3Int> _Vector3Int = Lerp;
        internal static readonly Interpolater<Vector4> _Vector4 = Lerp;
        internal static readonly Interpolater<Quaternion> _Quaternion = Lerp;
        internal static readonly Interpolater<Rect> _Rect = Lerp;
        internal static readonly Interpolater<Color> _Color = Lerp;

        /// <summary>
        /// Linearly interpolates between <paramref name="a"/> and
        /// <paramref name="b"/> by <paramref name="t"/>.
        /// </summary>
        /// <param name="a">The start value.</param>
        /// <param name="b">The end value.</param>
        /// <param name="t">The interpolation value between the start and end value.</param>
        /// <param name="snapping">Snaps the interpolated value to the nearest whole number.</param>
        /// <returns>The interpolated value between the start and end value.</returns>
        public static float Lerp(float a, float b, float t, bool snapping = false)
        {
            float value = Mathf.Lerp(a, b, t);
            return snapping ? (int)value : value;
        }

        /// <summary>
        /// Linearly interpolates between <paramref name="a"/> and
        /// <paramref name="b"/> by <paramref name="t"/>.
        /// </summary>
        /// <param name="a">The start value.</param>
        /// <param name="b">The end value.</param>
        /// <param name="t">The interpolation value between the start and end value.</param>
        /// <param name="snapping">Snaps the interpolated value to the nearest whole number.</param>
        /// <returns>The interpolated value between the start and end value.</returns>
        public static double Lerp(double a, double b, float t, bool snapping = false)
        {
            double value = Mathf.Lerp((float)a, (float)b, t);
            return snapping ? (int)value : value;
        }

        /// <summary>
        /// Linearly interpolates between <paramref name="a"/> and
        /// <paramref name="b"/> by <paramref name="t"/>.
        /// </summary>
        /// <param name="a">The start value.</param>
        /// <param name="b">The end value.</param>
        /// <param name="t">The interpolation value between the start and end value.</param>
        /// <param name="snapping">Snaps the interpolated value to the nearest whole number.</param>
        /// <returns>The interpolated value between the start and end value.</returns>
        public static int Lerp(int a, int b, float t, bool snapping = false)
        {
            return (int)Mathf.Lerp(a, b, t);
        }

        /// <summary>
        /// Linearly interpolates between <paramref name="a"/> and
        /// <paramref name="b"/> by <paramref name="t"/>.
        /// </summary>
        /// <param name="a">The start value.</param>
        /// <param name="b">The end value.</param>
        /// <param name="t">The interpolation value between the start and end value.</param>
        /// <param name="snapping">Snaps the interpolated value to the nearest whole number.</param>
        /// <returns>The interpolated value between the start and end value.</returns>
        public static long Lerp(long a, long b, float t, bool snapping = false)
        {

        /// <summary>
        /// Linearly interpolates between <paramref name="a"/> and
        /// <paramref name="b"/> by <paramref name="t"/>.
        /// </summary>
        /// <param name="a">The start value.</param>
        /// <param name="b">The end value.</param>
        /// <param name="t">The interpolation value between the start and end value.</param>
        /// <param name="snapping">Snaps the interpolated value to the nearest whole number.</param>
        /// <returns>The interpolated value between the start and end value.</returns>
        public static short Lerp(short a, short b, float t, bool snapping = false)
        {
            return (short)Mathf.Lerp(a, b, t);
        }

        /// <summary>
        /// Linearly interpolates between <paramref name="a"/> and
        /// <paramref name="b"/> by <paramref name="t"/>.
        /// </summary>
        /// <param name="a">The start value.</param>
        /// <param name="b">The end value.</param>
        /// <param name="t">The interpolation value between the start and end value.</param>
        /// <param name="snapping">Snaps the interpolated value to the nearest whole number.</param>
        /// <returns>The interpolated value between the start and end value.</returns>
        public static Vector2 Lerp(Vector2 a, Vector2 b, float t, bool snapping = false)
        {
            Vector2 value = Vector2.Lerp(a, b, t);
            return snapping ? Snap(value) : value;
        }

        /// <summary>
        /// Linearly interpolates between <paramref name="a"/> and
        /// <paramref name="b"/> by <paramref name="t"/>.
        /// </summary>
        /// <param name="a">The start value.</param>
        /// <param name="b">The end value.</param>
        /// <param name="t">The interpolation value between the start and end value.</param>
        /// <param name="snapping">Snaps the interpolated value to the nearest whole number.</param>
        /// <returns>The interpolated value between the start and end value.</returns>
        public static Vector2Int Lerp(Vector2Int a, Vector2Int b, float t, bool snapping = false)
        {
            return new Vector2Int(
                (int)Mathf.Lerp(a.x, b.x, t),
                (int)Mathf.Lerp(a.y, b.y, t));
        }

        /// <summary>
        /// Linearly interpolates between <paramref name="a"/> and
        /// <paramref name="b"/> by <paramref name="t"/>.
        /// </summary>
        /// <param name="a">The start value.</param>
        /// <param name="b">The end value.</param>
        /// <param name="t">The interpolation value between the start and end value.</param>
        /// <param name="snapping">Snaps the interpolated value to the nearest whole number.</param>
        /// <returns>The interpolated value between the start and end value.</returns>
        public static Vector3 Lerp(Vector3 a, Vector3 b, float t, bool snapping = false)
        {
            Vector3 value = Vector3.Lerp(a, b, t);
            return snapping ? Snap(value) : value;
        }

        /// <summary>
        /// Linearly interpolates between <paramref name="a"/> and
        /// <paramref name="b"/> by <paramref name="t"/>.
        /// </summary>
        /// <param name="a">The start value.</param>
        /// <param name="b">The end value.</param>
        /// <param name="t">The interpolation value between the start and end value.</param>
        /// <param name="snapping">Snaps the interpolated value to the nearest whole number.</param>
        /// <returns>The interpolated value between the start and end value.</returns>
        public static Vector3Int Lerp(Vector3Int a, Vector3Int b, float t, bool snapping = false)
        {
            return new Vector3Int(
                (int)Mathf.Lerp(a.x, b.x, t),
                (int)Mathf.Lerp(a.y, b.y, t),
                (int)Mathf.Lerp(a.z, b.z, t));
        }

        /// <summary>
        /// Linearly interpolates between <paramref name="a"/> and
        /// <paramref name="b"/> by <paramref name="t"/>.
        /// </summary>
        /// <param name="a">The start value.</param>
        /// <param name="b">The end value.</param>
        /// <param name="t">The interpolation value between the start and end value.</param>
        /// <param name="snapping">Snaps the interpolated value to the nearest whole number.</param>
        /// <returns>The interpolated value between the start and end value.</returns>
        public static Vector4 Lerp(Vector4 a, Vector4 b, float t, bool snapping = false)
        {
            Vector4 value = Vector4.Lerp(a, b, t);
            return snapping ? Snap(value) : value;
        }

        /// <summary>
        /// Linearly interpolates between <paramref name="a"/> and
        /// <paramref name="b"/> by <paramref name="t"/>.
        /// </summary>
        /// <param name="a">The start value.</param>
        /// <param name="b">The end value.</param>
        /// <param name="t">The interpolation value between the start and end value.</param>
        /// <param name="snapping">Snaps the interpolated value to the nearest whole number.</param>
        /// <returns>The interpolated value between the start and end value.</returns>
        public static Quaternion Lerp(Quaternion a, Quaternion b, float t, bool snapping = false)
        {
            Quaternion value = Quaternion.Lerp(a, b, t);
            return snapping ? Snap(value) : value;
        }

        /// <summary>
        /// Linearly interpolates between <paramref name="a"/> and
        /// <paramref name="b"/> by <paramref name="t"/>.
        /// </summary>
        /// <param name="a">The start value.</param>
        /// <param name="b">The end value.</param>
        /// <param name="t">The interpolation value between the start and end value.</param>
        /// <param name="snapping">Snaps the interpolated value to the nearest whole number.</param>
        /// <returns>The interpolated value between the start and end value.</returns>
        public static Rect Lerp(Rect a, Rect b, float t, bool snapping = false)
        {
            Vector2 position = Lerp(a.position, b.position, t, snapping);
            Vector2 size = Lerp(a.size, b.size, t, snapping);
            return new Rect(position, size);
        }

        /// <summary>
        /// Linearly interpolates between <paramref name="a"/> and
        /// <paramref name="b"/> by <paramref name="t"/>.
        /// </summary>
        /// <param name="a">The start value.</param>
        /// <param name="b">The end value.</param>
        /// <param name="t">The interpolation value between the start and end value.</param>
        /// <param name="snapping">Snaps the interpolated value to the nearest whole number.</param>
        /// <returns>The interpolated value between the start and end value.</returns>
        public static Color Lerp(Color a, Color b, float t, bool snapping = false)
        {
            Color value = Color.Lerp(a, b, t);
            return snapping ? Snap(value) : value;
        }

        /// <summary>
        /// Smoothly snaps the value to the nearest whole number.
        /// </summary>
        /// <param name="value">The value to snap.</param>
        /// <returns>The value snapped to the nearest whole number.</returns>
        internal static Vector2 Snap(Vector2 value)
        {
            return new Vector2(Mathf.Round(value.x), Mathf.Round(value.y));
        }

        /// <summary>
        /// Smoothly snaps the value to the nearest whole number.
        /// </summary>
        /// <param name="value">The value to snap.</param>
        /// <returns>The value snapped to the nearest whole number.</returns>
        internal static Vector3 Snap(Vector3 value)
        {
            return new Vector3(Mathf.Round(value.x), Mathf.Round(value.y), Mathf.Round(value.z));
        }

        /// <summary>
        /// Smoothly snaps the value to the nearest whole number.
        /// </summary>
        /// <param name="value">The value to snap.</param>
        /// <returns>The value snapped to the nearest whole number.</returns>
        internal static Vector4 Snap(Vector4 value)
        {
            return new Vector4(Mathf.Round(value.x), Mathf.Round(value.y), Mathf.Round(value.z), Mathf.Round(value.w));
        }

        /// <summary>
        /// Smoothly snaps the value to the nearest whole number.
        /// </summary>
        /// <param name="value">The value to snap.</param>
        /// <returns>The value snapped to the nearest whole number.</returns>
        internal static Quaternion Snap(Quaternion value)
        {
            return Quaternion.Euler(Snap(value.eulerAngles));
        }

        /// <summary>
        /// Smoothly snaps the value to the nearest whole number.
        /// </summary>
        /// <param name="value">The value to snap.</param>
        /// <returns>The value snapped to the nearest whole number.</returns>
        internal static Color Snap(Color value)
        {
            int r = Mathf.RoundToInt(value.r * 255f);
            int g = Mathf.RoundToInt(value.g * 255f);
            int b = Mathf.RoundToInt(value.b * 255f);
            return new Color(r / 255f, g / 255f, b / 255f, value.a);
        }

    }

}
