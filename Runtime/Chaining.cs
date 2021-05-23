namespace Zigurous.Animation.Tweening
{
    /// <summary>
    /// Provides method chaining for tweens. This allows multiple properties to
    /// be assigned in a single statement without requiring a variable to store
    /// the intermediate results.
    /// </summary>
    public static class Chaining
    {
        /// <summary>
        /// Sets the id of the tween such that it can be identified by the given
        /// target object.
        /// </summary>
        internal static Tween SetTarget<T>(this Tween tween, T target)
        {
            tween.id = target.GetHashCode();
            return tween;
        }

        /// <summary>
        /// Sets the id of the tween such that it can be identified by the given
        /// target object.
        /// </summary>
        internal static TweenBase SetTarget<T>(this TweenBase tween, T target)
        {
            tween.id = target.GetHashCode();
            return tween;
        }

        /// <summary>
        /// Sets the id of the tween sequence such that it can be identified by
        /// the given target object.
        /// </summary>
        internal static TweenSequence SetTarget<T>(this TweenSequence sequence, T target)
        {
            sequence.id = target.GetHashCode();
            return sequence;
        }

        public static Tween SetId(this Tween tween, int id)
        {
            tween.id = id;
            return tween;
        }

        public static TweenBase SetId(this TweenBase tween, int id)
        {
            tween.id = id;
            return tween;
        }

        public static TweenSequence SetId(this TweenSequence sequence, int id)
        {
            sequence.id = id;
            return sequence;
        }

        public static Tween SetEase(this Tween tween, Ease ease)
        {
            tween.ease = ease;
            return tween;
        }

        public static Tween SetReversed(this Tween tween, bool reversed = true)
        {
            tween.reversed = reversed;
            return tween;
        }

        public static Tween SetAutoStart(this Tween tween, bool autoStart = true)
        {
            tween.autoStart = autoStart;
            return tween;
        }

        public static TweenBase SetAutoStart(this TweenBase tween, bool autoStart = true)
        {
            tween.autoStart = autoStart;
            return tween;
        }

        public static TweenSequence SetAutoStart(this TweenSequence sequence, bool autoStart = true)
        {
            sequence.autoStart = autoStart;
            return sequence;
        }

        public static Tween SetAutoKill(this Tween tween, bool autoKill = true)
        {
            tween.autoKill = autoKill;
            return tween;
        }

        public static TweenBase SetAutoKill(this TweenBase tween, bool autoKill = true)
        {
            tween.autoKill = autoKill;
            return tween;
        }

        public static TweenSequence SetAutoKill(this TweenSequence sequence, bool autoKill = true)
        {
            sequence.autoKill = autoKill;
            return sequence;
        }

        public static Tween SetRecyclable(this Tween tween, bool recyclable = true)
        {
            tween.recyclable = recyclable;
            return tween;
        }

        public static TweenBase SetRecyclable(this TweenBase tween, bool recyclable = true)
        {
            tween.recyclable = recyclable;
            return tween;
        }

        public static TweenSequence SetRecyclable(this TweenSequence sequence, bool recyclable = true)
        {
            sequence.recyclable = recyclable;
            return sequence;
        }

        public static Tween SetDuration(this Tween tween, float duration)
        {
            tween.duration = duration;
            return tween;
        }

        public static Tween SetDelay(this Tween tween, float delay)
        {
            tween.delay = delay;
            return tween;
        }

        public static Tween OnUpdate(this Tween tween, Tween.Callback callback)
        {
            tween.onUpdate += callback;
            return tween;
        }

        public static TweenBase OnUpdate(this TweenBase tween, TweenBase.Callback callback)
        {
            tween.onUpdate += callback;
            return tween;
        }

        public static TweenSequence OnUpdate(this TweenSequence sequence, TweenSequence.Callback callback)
        {
            sequence.onUpdate += callback;
            return sequence;
        }

        public static Tween OnStart(this Tween tween, Tween.Callback callback)
        {
            tween.onStart += callback;
            return tween;
        }

        public static TweenBase OnStart(this TweenBase tween, TweenBase.Callback callback)
        {
            tween.onStart += callback;
            return tween;
        }

        public static TweenSequence OnStart(this TweenSequence sequence, TweenSequence.Callback callback)
        {
            sequence.onStart += callback;
            return sequence;
        }

        public static Tween OnStop(this Tween tween, Tween.Callback callback)
        {
            tween.onStop += callback;
            return tween;
        }

        public static TweenBase OnStop(this TweenBase tween, TweenBase.Callback callback)
        {
            tween.onStop += callback;
            return tween;
        }

        public static TweenSequence OnStop(this TweenSequence sequence, TweenSequence.Callback callback)
        {
            sequence.onStop += callback;
            return sequence;
        }

        public static Tween OnComplete(this Tween tween, Tween.Callback callback)
        {
            tween.onComplete += callback;
            return tween;
        }

        public static TweenBase OnComplete(this TweenBase tween, TweenBase.Callback callback)
        {
            tween.onComplete += callback;
            return tween;
        }

        public static TweenSequence OnComplete(this TweenSequence sequence, TweenSequence.Callback callback)
        {
            sequence.onComplete += callback;
            return sequence;
        }

        public static Tween OnKill(this Tween tween, Tween.Callback callback)
        {
            tween.onKill += callback;
            return tween;
        }

        public static TweenBase OnKill(this TweenBase tween, TweenBase.Callback callback)
        {
            tween.onKill += callback;
            return tween;
        }

        public static TweenSequence OnKill(this TweenSequence sequence, TweenSequence.Callback callback)
        {
            sequence.onKill += callback;
            return sequence;
        }

    }

}
