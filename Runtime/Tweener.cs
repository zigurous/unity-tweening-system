namespace Zigurous.Tweening
{
    /// <summary>
    /// A tween that animates a parameter over time on an object from a start
    /// value to an end value.
    /// </summary>
    /// <typeparam name="T">The type of object to tween.</typeparam>
    /// <typeparam name="U">The type of parameter to tween.</typeparam>
    public class Tweener<T,U> : Tween
    {
        /// <summary>
        /// The object being tweened.
        /// </summary>
        public T target;

        /// <summary>
        /// The function that gets the current value of the parameter being
        /// tweened.
        /// </summary>
        public TweenGetter<T,U> getter;

        /// <summary>
        /// The function that sets a new value of the parameter being tweened.
        /// </summary>
        public TweenSetter<T,U> setter;

        /// <summary>
        /// The function that interpolates values between the tween's start and
        /// end value.
        /// </summary>
        public Interpolater<U> interpolater;

        /// <summary>
        /// The initial value of the parameter at the start of the tween.
        /// </summary>
        public U startValue;

        /// <summary>
        /// The desired value of the parameter at the end of the tween.
        /// </summary>
        public U endValue;

        /// <summary>
        /// Creates a new tweener.
        /// </summary>
        public Tweener() : base()
        {
            type = TweenType.Tweener;
            template = typeof(Tweener<T,U>);
        }

        /// <summary>
        /// Creates a new tweener with the specified target object.
        /// </summary>
        /// <param name="target">The object to tween.</param>
        public Tweener(T target) : this()
        {
            this.SetTarget(target);
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
            setter(target, interpolater(startValue, endValue, time, snapping));
        }

        /// <inheritdoc/>
        protected override void OnStart()
        {
            if (Iterations == 0 && getter != null) {
                startValue = getter(target);
            }
        }

        /// <inheritdoc/>
        protected override void OnKill()
        {
            target = default;
            interpolater = null;
            getter = null;
            setter = null;
        }

        /// <inheritdoc/>
        protected override void OnReset()
        {
            target = default;
            interpolater = null;
            getter = null;
            setter = null;
        }

    }

}
