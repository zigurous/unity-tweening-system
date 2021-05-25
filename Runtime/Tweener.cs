namespace Zigurous.Tweening
{
    /// <summary>
    /// A tween object, an animation that changes a value over time using an
    /// easing function.
    /// </summary>
    public class Tweener<T> : Tween
    {
        /// <summary>
        /// The function that interpolates values between the tween's start and
        /// end value.
        /// </summary>
        public Interpolater<T> interpolater;

        /// <summary>
        /// The function that gets the current value of the parameter being
        /// tweened.
        /// </summary>
        public TweenGetter<T> getter;

        /// <summary>
        /// The function that sets a new value of the parameter being tweened.
        /// </summary>
        public TweenSetter<T> setter;

        /// <summary>
        /// The value of the parameter being tweened at the start of the tween.
        /// </summary>
        public T startValue;

        /// <summary>
        /// The value of the parameter being tweened at the end of the tween.
        /// </summary>
        public T endValue;

        /// <summary>
        /// Constructs a new core tween.
        /// </summary>
        public Tweener() : base()
        {
            this.type = TweenType.Tweener;
            this.template = typeof(T);
        }

        protected override void Animate()
        {
            if (this.interpolater == null || this.setter == null) {
                return;
            }

            float percent = this.PercentComplete;

            if (this.reversed) {
                percent = 1.0f - percent;
            }

            float time = EaseFunction.lookup[this.ease](percent);
            setter(interpolater(this.startValue, this.endValue, time));
        }

        protected override void OnStart()
        {
            if (this.getter != null) {
                this.startValue = getter();
            }
        }

        protected override void OnKill()
        {
            this.interpolater = null;
            this.getter = null;
            this.setter = null;
        }

        protected override void OnReset()
        {
            this.interpolater = null;
            this.getter = null;
            this.setter = null;
        }

    }

}
