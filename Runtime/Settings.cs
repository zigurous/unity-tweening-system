using UnityEngine;

namespace Zigurous.Tweening
{
    /// <summary>
    /// Properties for changing global tweening settings.
    /// </summary>
    [AddComponentMenu("Zigurous/Tweening/Tweening Settings")]
    [HelpURL("https://docs.zigurous.com/com.zigurous.tweening/api/Zigurous.Tweening/Settings")]
    public sealed class Settings : MonoBehaviour
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
        public static float defaultDelay = 0f;

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
        /// This setting can be overridden by individual tweens.
        /// </summary>
        public static bool autoStart = true;

        /// <summary>
        /// Automatically kills tweens after being completed, by default.
        /// This setting can be overridden by individual tweens.
        /// </summary>
        public static bool autoKill = true;

        /// <summary>
        /// Keeps tweens in memory to be re-used after being killed, by default.
        /// This setting can be overridden by individual tweens.
        /// </summary>
        public static bool recyclable = true;

        [SerializeField]
        [Tooltip("The default Ease assigned to every tween.")]
        private Ease m_DefaultEase = Ease.QuadOut;

        [SerializeField]
        [Tooltip("The default amount of seconds a tween takes to complete.")]
        private float m_DefaultDuration = 0.3f;

        [SerializeField]
        [Tooltip("The default amount of seconds before every tween starts.")]
        private float m_DefaultDelay = 0f;

        [SerializeField]
        [Tooltip("The overshoot value used in easing functions.")]
        private float m_Overshoot = 1.70158f;

        [SerializeField]
        [Tooltip("The initial amount of tweens memory is allocated for when the system starts. Additional memory will be allocated as needed.")]
        private int m_InitialCapacity = 16;

        [SerializeField]
        [Tooltip("Automatically starts tweens after being created, by default. This setting can be overridden by individual tweens.")]
        private bool m_AutoStart = true;

        [SerializeField]
        [Tooltip("Automatically kills tweens after being completed, by default. This setting can be overridden by individual tweens.")]
        private bool m_AutoKill = true;

        [SerializeField]
        [Tooltip("Keeps tweens in memory to be re-used after being killed, by default. This setting can be overridden by individual tweens.")]
        private bool m_Recyclable = true;

        private void OnValidate()
        {
            UpdateSettings();
        }

        private void Awake()
        {
            UpdateSettings();
        }

        private void UpdateSettings()
        {
            Settings.defaultEase = m_DefaultEase;
            Settings.defaultDuration = m_DefaultDuration;
            Settings.defaultDelay = m_DefaultDelay;
            Settings.overshoot = m_Overshoot;
            Settings.initialCapacity = m_InitialCapacity;
            Settings.autoStart = m_AutoStart;
            Settings.autoKill = m_AutoKill;
            Settings.recyclable = m_Recyclable;
        }

        /// <summary>
        /// Sets the default Ease assigned to every tween.
        /// </summary>
        /// <param name="ease">The Ease to set as the default.</param>
        public void SetDefaultEase(Ease ease)
        {
            m_DefaultEase = ease;
            Settings.defaultEase = ease;
        }

        /// <summary>
        /// Sets the default amount of seconds a tween takes to complete.
        /// </summary>
        /// <param name="duration">The amount of seconds to set as the default.</param>
        public void SetDefaultDuration(float duration)
        {
            m_DefaultDuration = duration;
            Settings.defaultDuration = duration;
        }

        /// <summary>
        /// Sets the default amount of seconds before every tween starts.
        /// </summary>
        /// <param name="delay">The amount of seconds to set as the default.</param>
        public void SetDefaultDelay(float delay)
        {
            m_DefaultDelay = delay;
            Settings.defaultDelay = delay;
        }

        /// <summary>
        /// Sets the overshoot value used in easing functions.
        /// </summary>
        /// <param name="overshoot">The overshoot value to set.</param>
        public void SetOvershoot(float overshoot)
        {
            m_Overshoot = overshoot;
            Settings.overshoot = overshoot;
        }

        /// <summary>
        /// Sets the initial amount of tweens memory is allocated for when the
        /// system starts. Additional memory will be allocated as needed.
        /// </summary>
        /// <param name="initialCapacity">The initial capacity to set.</param>
        public void SetInitialCapacity(int initialCapacity)
        {
            m_InitialCapacity = initialCapacity;
            Settings.initialCapacity = initialCapacity;
        }

        /// <summary>
        /// Sets whether to automatically start tweens after being created,
        /// by default. This setting can be overridden by individual tweens.
        /// </summary>
        /// <param name="autoStart">Whether to automatically start tweens after being created.</param>
        public void SetAutoStart(bool autoStart)
        {
            m_AutoStart = autoStart;
            Settings.autoStart = autoStart;
        }

        /// <summary>
        /// Sets whether to automatically kills tweens after being completed,
        /// by default. This setting can be overridden by individual tweens.
        /// </summary>
        /// <param name="autoKill">Whether to automatically kill tweens after being completed.</param>
        public void SetAutoKill(bool autoKill)
        {
            m_AutoKill = autoKill;
            Settings.autoKill = autoKill;
        }

        /// <summary>
        /// Sets whether to keep tweens in memory to be re-used after being
        /// killed, by default. This setting can be overridden by individual tweens.
        /// </summary>
        /// <param name="recyclable">Whether to allow tweens to be recycled.</param>
        public void SetRecyclable(bool recyclable)
        {
            m_Recyclable = recyclable;
            Settings.recyclable = recyclable;
        }

    }

}
