namespace Zigurous.Animation.Tweening
{
    public static class TweenChaining
    {
        internal static Tween SetTarget<T>(this Tween tween, T target) where T: class
        {
            tween.id = target.GetHashCode();
            return tween;
        }

        public static Tween SetId(this Tween tween, int id)
        {
            tween.id = id;
            return tween;
        }

        public static Tween SetStartValue(this Tween tween, float startValue)
        {
            tween.startValue = startValue;
            return tween;
        }

        public static Tween SetEndValue(this Tween tween, float endValue)
        {
            tween.endValue = endValue;
            return tween;
        }

        public static Tween SetEase(this Tween tween, Ease ease)
        {
            tween.ease = ease;
            return tween;
        }

        public static Tween SetReversed(this Tween tween, bool reversed)
        {
            tween.reversed = reversed;
            return tween;
        }

        public static Tween SetAutoStart(this Tween tween, bool autoStart = true)
        {
            tween.autoStart = autoStart;
            return tween;
        }

        public static Tween SetAutoKill(this Tween tween, bool autoKill = true)
        {
            tween.autoKill = autoKill;
            return tween;
        }

        public static Tween SetRecyclable(this Tween tween, bool recyclable = true)
        {
            tween.recyclable = recyclable;
            return tween;
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
            tween.onUpdate = callback;
            return tween;
        }

        public static Tween OnStart(this Tween tween, Tween.Callback callback)
        {
            tween.onStart = callback;
            return tween;
        }

        public static Tween OnStop(this Tween tween, Tween.Callback callback)
        {
            tween.onStop = callback;
            return tween;
        }

        public static Tween OnRestart(this Tween tween, Tween.Callback callback)
        {
            tween.onRestart = callback;
            return tween;
        }

        public static Tween OnComplete(this Tween tween, Tween.Callback callback)
        {
            tween.onComplete = callback;
            return tween;
        }

        public static Tween OnKill(this Tween tween, Tween.Callback callback)
        {
            tween.onKill = callback;
            return tween;
        }

    }

}
