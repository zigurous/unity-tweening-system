using UnityEngine;

namespace Zigurous.Tweening
{
    /// <summary>
    /// Properties for changing global tweening settings.
    /// </summary>
    [AddComponentMenu("Zigurous/Tweening/Tweening Settings")]
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
        private Ease _defaultEase = Ease.QuadOut;

        [SerializeField]
        [Tooltip("The default amount of seconds a tween takes to complete.")]
        private float _defaultDuration = 0.3f;

        [SerializeField]
        [Tooltip("The default amount of seconds before every tween starts.")]
        private float _defaultDelay = 0f;

        [SerializeField]
        [Tooltip("The overshoot value used in easing functions.")]
        private float _overshoot = 1.70158f;

        [SerializeField]
        [Tooltip("The initial amount of tweens memory is allocated for when the system starts. Additional memory will be allocated as needed.")]
        private int _initialCapacity = 16;

        [SerializeField]
        [Tooltip("Automatically starts tweens after being created, by default. This setting can be overridden by individual tweens.")]
        private bool _autoStart = true;

        [SerializeField]
        [Tooltip("Automatically kills tweens after being completed, by default. This setting can be overridden by individual tweens.")]
        private bool _autoKill = true;

        [SerializeField]
        [Tooltip("Keeps tweens in memory to be re-used after being killed, by default. This setting can be overridden by individual tweens.")]
        private bool _recyclable = true;

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
            Settings.defaultEase = _defaultEase;
            Settings.defaultDuration = _defaultDuration;
            Settings.defaultDelay = _defaultDelay;
            Settings.overshoot = _overshoot;
            Settings.initialCapacity = _initialCapacity;
            Settings.autoStart = _autoStart;
            Settings.autoKill = _autoKill;
            Settings.recyclable = _recyclable;
        }

        /// <summary>
        /// Sets the default Ease assigned to every tween.
        /// </summary>
        /// <param name="ease">The Ease to set as the default.</param>
        public void SetDefaultEase(Ease ease)
        {
            _defaultEase = ease;
            Settings.defaultEase = ease;
        }

        /// <summary>
        /// Sets the default amount of seconds a tween takes to complete.
        /// </summary>
        /// <param name="duration">The amount of seconds to set as the default.</param>
        public void SetDefaultDuration(float duration)
        {
            _defaultDuration = duration;
            Settings.defaultDuration = duration;
        }

        /// <summary>
        /// Sets the default amount of seconds before every tween starts.
        /// </summary>
        /// <param name="delay">The amount of seconds to set as the default.</param>
        public void SetDefaultDelay(float delay)
        {
            _defaultDelay = delay;
            Settings.defaultDelay = delay;
        }

        /// <summary>
        /// Sets the overshoot value used in easing functions.
        /// </summary>
        /// <param name="overshoot">The overshoot value to set.</param>
        public void SetOvershoot(float overshoot)
        {
            _overshoot = overshoot;
            Settings.overshoot = overshoot;
        }

        /// <summary>
        /// Sets the initial amount of tweens memory is allocated for when the
        /// system starts. Additional memory will be allocated as needed.
        /// </summary>
        /// <param name="initialCapacity">The initial capacity to set.</param>
        public void SetInitialCapacity(int initialCapacity)
        {
            _initialCapacity = initialCapacity;
            Settings.initialCapacity = initialCapacity;
        }

        /// <summary>
        /// Sets whether to automatically start tweens after being created,
        /// by default. This setting can be overridden by individual tweens.
        /// </summary>
        /// <param name="autoStart">Whether to automatically start tweens after being created.</param>
        public void SetAutoStart(bool autoStart)
        {
            _autoStart = autoStart;
            Settings.autoStart = autoStart;
        }

        /// <summary>
        /// Sets whether to automatically kills tweens after being completed,
        /// by default. This setting can be overridden by individual tweens.
        /// </summary>
        /// <param name="autoKill">Whether to automatically kill tweens after being completed.</param>
        public void SetAutoKill(bool autoKill)
        {
            _autoKill = autoKill;
            Settings.autoKill = autoKill;
        }

        /// <summary>
        /// Sets whether to keep tweens in memory to be re-used after being
        /// killed, by default. This setting can be overridden by individual tweens.
        /// </summary>
        /// <param name="recyclable">Whether to allow tweens to be recycled.</param>
        public void SetRecyclable(bool recyclable)
        {
            _recyclable = recyclable;
            Settings.recyclable = recyclable;
        }

    }

}
