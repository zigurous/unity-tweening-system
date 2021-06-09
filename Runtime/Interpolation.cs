using UnityEngine;

namespace Zigurous.Tweening
{
    /// <summary>
    /// Provides functions for interpolating values.
    /// </summary>
    public static class Interpolation
    {
        /// <summary>
        /// Linearly interpolates between a and b by t.
        /// </summary>
        public static float Lerp(float a, float b, float t, bool snapping = false)
        {
            float value = Mathf.Lerp(a, b, t);
            return snapping ? (int)value : value;
        }

        /// <summary>
        /// Linearly interpolates between a and b by t.
        /// </summary>
        public static double Lerp(double a, double b, float t, bool snapping = false)
        {
            double value = Mathf.Lerp((float)a, (float)b, t);
            return snapping ? (int)value : value;
        }

        /// <summary>
        /// Linearly interpolates between a and b by t.
        /// </summary>
        public static int Lerp(int a, int b, float t, bool snapping = false)
        {
            return (int)Mathf.Lerp(a, b, t);
        }

        /// <summary>
        /// Linearly interpolates between a and b by t.
        /// </summary>
        public static long Lerp(long a, long b, float t, bool snapping = false)
        {
            long value = (long)Mathf.Lerp(a, b, t);
            return snapping ? (int)value : value;
        }

        /// <summary>
        /// Linearly interpolates between a and b by t.
        /// </summary>
        public static Vector2 Lerp(Vector2 a, Vector2 b, float t, bool snapping = false)
        {
            Vector2 value = Vector2.Lerp(a, b, t);
            return snapping ? Snap(value) : value;
        }

        /// <summary>
        /// Linearly interpolates between a and b by t.
        /// </summary>
        public static Vector2Int Lerp(Vector2Int a, Vector2Int b, float t, bool snapping = false)
        {
            return new Vector2Int(
                (int)Mathf.Lerp(a.x, b.x, t),
                (int)Mathf.Lerp(a.y, b.y, t));
        }

        /// <summary>
        /// Linearly interpolates between a and b by t.
        /// </summary>
        public static Vector3 Lerp(Vector3 a, Vector3 b, float t, bool snapping = false)
        {
            Vector3 value = Vector3.Lerp(a, b, t);
            return snapping ? Snap(value) : value;
        }

        /// <summary>
        /// Linearly interpolates between a and b by t.
        /// </summary>
        public static Vector3Int Lerp(Vector3Int a, Vector3Int b, float t, bool snapping = false)
        {
            return new Vector3Int(
                (int)Mathf.Lerp(a.x, b.x, t),
                (int)Mathf.Lerp(a.y, b.y, t),
                (int)Mathf.Lerp(a.z, b.z, t));
        }

        /// <summary>
        /// Linearly interpolates between a and b by t.
        /// </summary>
        public static Vector4 Lerp(Vector4 a, Vector4 b, float t, bool snapping = false)
        {
            Vector4 value = Vector4.Lerp(a, b, t);
            return snapping ? Snap(value) : value;
        }

        /// <summary>
        /// Linearly interpolates between a and b by t.
        /// </summary>
        public static Quaternion Lerp(Quaternion a, Quaternion b, float t, bool snapping = false)
        {
            Quaternion value = Quaternion.Lerp(a, b, t);
            return snapping ? Snap(value) : value;
        }

        /// <summary>
        /// Linearly interpolates between a and b by t.
        /// </summary>
        public static Color Lerp(Color a, Color b, float t, bool snapping = false)
        {
            Color value = Color.Lerp(a, b, t);
            return snapping ? Snap(value) : value;
        }

        /// <summary>
        /// Smoothly snaps the values to integers.
        /// </summary>
        internal static Vector2 Snap(Vector2 value)
        {
            return new Vector2((int)value.x, (int)value.y);
        }

        /// <summary>
        /// Smoothly snaps the values to integers.
        /// </summary>
        internal static Vector3 Snap(Vector3 value)
        {
            return new Vector3((int)value.x, (int)value.y, (int)value.z);
        }

        /// <summary>
        /// Smoothly snaps the values to integers.
        /// </summary>
        internal static Vector4 Snap(Vector4 value)
        {
            return new Vector4((int)value.x, (int)value.y, (int)value.z, (int)value.w);
        }

        /// <summary>
        /// Smoothly snaps the values to integers.
        /// </summary>
        internal static Quaternion Snap(Quaternion value)
        {
            return Quaternion.Euler(Snap(value.eulerAngles));
        }

        /// <summary>
        /// Smoothly snaps the values to integers.
        /// </summary>
        internal static Color Snap(Color value)
        {
            int r = Mathf.RoundToInt(value.r * 255.0f);
            int g = Mathf.RoundToInt(value.g * 255.0f);
            int b = Mathf.RoundToInt(value.b * 255.0f);
            return new Color(r / 255.0f, g / 255.0f, b / 255.0f, value.a);
        }

    }

}
