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
        public static float Lerp(float a, float b, float t)
        {
            return Mathf.Lerp(a, b, t);
        }

        /// <summary>
        /// Linearly interpolates between a and b by t.
        /// </summary>
        public static double Lerp(double a, double b, float t)
        {
            return Mathf.Lerp((float)a, (float)b, t);
        }

        /// <summary>
        /// Linearly interpolates between a and b by t.
        /// </summary>
        public static int Lerp(int a, int b, float t)
        {
            return (int)Mathf.Lerp(a, b, t);
        }

        /// <summary>
        /// Linearly interpolates between a and b by t.
        /// </summary>
        public static long Lerp(long a, long b, float t)
        {
            return (long)Mathf.Lerp(a, b, t);
        }

        /// <summary>
        /// Linearly interpolates between a and b by t.
        /// </summary>
        public static Vector2 Lerp(Vector2 a, Vector2 b, float t)
        {
            return Vector2.Lerp(a, b, t);
        }

        /// <summary>
        /// Linearly interpolates between a and b by t.
        /// </summary>
        public static Vector2Int Lerp(Vector2Int a, Vector2Int b, float t)
        {
            return new Vector2Int(
                (int)Mathf.Lerp(a.x, b.x, t),
                (int)Mathf.Lerp(a.y, b.y, t));
        }

        /// <summary>
        /// Linearly interpolates between a and b by t.
        /// </summary>
        public static Vector3 Lerp(Vector3 a, Vector3 b, float t)
        {
            return Vector3.Lerp(a, b, t);
        }

        /// <summary>
        /// Linearly interpolates between a and b by t.
        /// </summary>
        public static Vector3Int Lerp(Vector3Int a, Vector3Int b, float t)
        {
            return new Vector3Int(
                (int)Mathf.Lerp(a.x, b.x, t),
                (int)Mathf.Lerp(a.y, b.y, t),
                (int)Mathf.Lerp(a.z, b.z, t));
        }

        /// <summary>
        /// Linearly interpolates between a and b by t.
        /// </summary>
        public static Vector4 Lerp(Vector4 a, Vector4 b, float t)
        {
            return Vector4.Lerp(a, b, t);
        }

        /// <summary>
        /// Linearly interpolates between a and b by t.
        /// </summary>
        public static Quaternion Lerp(Quaternion a, Quaternion b, float t)
        {
            return Quaternion.Lerp(a, b, t);
        }

        /// <summary>
        /// Linearly interpolates between a and b by t.
        /// </summary>
        public static Color Lerp(Color a, Color b, float t)
        {
            return Color.Lerp(a, b, t);
        }

    }

}
