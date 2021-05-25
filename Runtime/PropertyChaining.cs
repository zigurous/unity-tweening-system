namespace Zigurous.Tweening
{
    /// <summary>
    /// Provides method chaining for tweens. This allows multiple properties to
    /// be assigned in a single statement without requiring a variable to store
    /// the intermediate results.
    /// </summary>
    public static class PropertyChaining
    {
        /// <summary>
        /// Sets the id of the tween such that it can be identified by the given
        /// target object.
        /// </summary>
        public static T SetTarget<T, U>(this T tween, U target) where T: Tween
        {
            tween.id = target.GetHashCode();
            return tween;
        }

        public static T SetId<T>(this T tween, int id) where T: Tween
        {
            tween.id = id;
            return tween;
        }

        public static T SetEase<T>(this T tween, Ease ease) where T: Tween
        {
            tween.ease = ease;
            return tween;
        }

        public static T SetDuration<T>(this T tween, float duration) where T: Tween
        {
            tween.duration = duration;
            return tween;
        }

        public static T SetDelay<T>(this T tween, float delay) where T: Tween
        {
            tween.delay = delay;
            return tween;
        }

        public static T SetReversed<T>(this T tween, bool reversed = true) where T: Tween
        {
            tween.reversed = reversed;
            return tween;
        }

        public static T SetRecyclable<T>(this T tween, bool recyclable) where T: Tween
        {
            tween.recyclable = recyclable;
            return tween;
        }

        public static T SetAutoStart<T>(this T tween, bool autoStart) where T: Tween
        {
            tween.autoStart = autoStart;
            return tween;
        }

        public static T SetAutoKill<T>(this T tween, bool autoKill) where T: Tween
        {
            tween.autoKill = autoKill;
            return tween;
        }

        public static T OnUpdate<T>(this T tween, TweenCallback callback) where T: Tween
        {
            tween.onUpdate += callback;
            return tween;
        }

        public static T OnStart<T>(this T tween, TweenCallback callback) where T: Tween
        {
            tween.onStart += callback;
            return tween;
        }

        public static T OnStop<T>(this T tween, TweenCallback callback) where T: Tween
        {
            tween.onStop += callback;
            return tween;
        }

        public static T OnComplete<T>(this T tween, TweenCallback callback) where T: Tween
        {
            tween.onComplete += callback;
            return tween;
        }

        public static T OnKill<T>(this T tween, TweenCallback callback) where T: Tween
        {
            tween.onKill += callback;
            return tween;
        }

    }

}
