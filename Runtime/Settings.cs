namespace Zigurous.Tweening
{
    /// <summary>
    /// Properties for changing global tweening settings.
    /// </summary>
    public static class Settings
    {
        /// <summary>
        /// The default Ease assigned to every tween.
        /// </summary>
        public static Ease defaultEase = Ease.QuadOut;

        /// <summary>
        /// The default amount of seconds a tween takes to complete.
        /// </summary>
        public static float defaultDuration = 0.3f;

        /// <summary>
        /// The default amount of seconds before every tween starts.
        /// </summary>
        public static float defaultDelay = 0.0f;

        /// <summary>
        /// The overshoot value used in easing functions.
        /// </summary>
        public static float overshoot = 1.70158f;

        /// <summary>
        /// The initial amount of tweens memory is allocated for when the system
        /// starts. Additional memory will be allocated as needed.
        /// </summary>
        public static int initialCapacity = 16;

        /// <summary>
        /// Automatically starts tweens after being created, by default.
        /// </summary>
        public static bool autoStart = true;

        /// <summary>
        /// Automatically kills tweens after being completed, by default.
        /// </summary>
        public static bool autoKill = true;

        /// <summary>
        /// Keeps tweens in memory to be re-used after being killed, by default.
        /// </summary>
        public static bool recyclable = true;
    }

}
