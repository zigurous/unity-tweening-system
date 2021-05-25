namespace Zigurous.Tweening
{
    /// <summary>
    /// The default settings used for tweens and the tweening system.
    /// </summary>
    public static class Settings
    {
        /// <summary>
        /// The default Ease assigned to every tween.
        /// </summary>
        public static Ease defaultEase = Ease.QuadOut;

        /// <summary>
        /// Automatically starts tweens after being created, by default.
        /// </summary>
        public static bool defaultAutoStart = true;

        /// <summary>
        /// Automatically kills tweens after being completed, by default.
        /// </summary>
        public static bool defaultAutoKill = true;

        /// <summary>
        /// Keeps tweens in memory to be re-used after being killed, by default.
        /// </summary>
        public static bool defaultRecyclable = true;

        /// <summary>
        /// The default amount of seconds a tween takes to complete.
        /// </summary>
        public static float defaultDuration = 0.3f;

        /// <summary>
        /// The default amount of seconds before every tween starts.
        /// </summary>
        public static float defaultDelay = 0.0f;

        /// <summary>
        /// The default overshoot value used in easing functions.
        /// </summary>
        public static float overshoot = 1.70158f;

        /// <summary>
        /// The initial amount of tweens that memory is allocated for when the
        /// system starts. Additional memory will be allocated as needed.
        /// </summary>
        public static int initialCapacity = 16;

    }

}
