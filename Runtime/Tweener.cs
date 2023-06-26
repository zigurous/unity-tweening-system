namespace Zigurous.Tweening
{
    /// <summary>
    /// A tween that animates a parameter over time on a source object from a
    /// start value to an end value.
    /// </summary>
    /// <typeparam name="S">The type of object to tween.</typeparam>
    /// <typeparam name="T">The type of parameter to tween.</typeparam>
    public class Tweener<S,T> : Tween
    {
        /// <summary>
        /// The source object being tweened.
        /// </summary>
        public S source;

        /// <summary>
        /// The function that interpolates values between the tween's start and
        /// end value.
        /// </summary>
        public Interpolater<T> interpolater;

        /// <summary>
        /// The function that gets the current value of the parameter being
        /// tweened.
        /// </summary>
        public TweenGetter<S,T> getter;

        /// <summary>
        /// The function that sets a new value of the parameter being tweened.
        /// </summary>
        public TweenSetter<S,T> setter;

        /// <summary>
        /// The initial value of the parameter at the start of the tween.
        /// </summary>
        public T startValue;

        /// <summary>
        /// The desired value of the parameter at the end of the tween.
        /// </summary>
        public T endValue;

        /// <summary>
        /// Creates a new tweener.
        /// </summary>
        public Tweener() : base()
        {
            type = TweenType.Tweener;
            template = typeof(Tweener<S,T>);
        }

        /// <inheritdoc/>
        public override void Animate()
        {
            if (interpolater == null || setter == null) {
                return;
            }

            float percent = PercentComplete;

            if (reversed) {
                percent = 1f - percent;
            }

            float time = EaseFunction.lookup[ease](percent);
            setter(source, interpolater(startValue, endValue, time, snapping));
        }

        /// <inheritdoc/>
        protected override void OnStart()
        {
            if (iterations == 0 && getter != null) {
                startValue = getter(source);
            }
        }

        /// <inheritdoc/>
        protected override void OnKill()
        {
            source = default(S);
            interpolater = null;
            getter = null;
            setter = null;
        }

        /// <inheritdoc/>
        protected override void OnReset()
        {
            source = default(S);
            interpolater = null;
            getter = null;
            setter = null;
        }

    }

}
