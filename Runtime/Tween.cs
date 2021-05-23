namespace Zigurous.Animation.Tweening
{
    /// <summary>
    /// A tween object, an animation that changes a value over time using an
    /// easing function.
    /// </summary>
    public sealed class Tween : TweenBase
    {
        /// <summary>
        /// The tweenable parameter being animated by the tween.
        /// </summary>
        public ITweenable parameter;

        /// <summary>
        /// The amount of seconds the tween takes to complete.
        /// </summary>
        public float duration = Settings.defaultDuration;

        /// <summary>
        /// The amount of seconds that have elapsed since the tween started.
        /// </summary>
        public float elapsed { get; private set; } = 0.0f;

        /// <summary>
        /// The tween's percentage of completion.
        /// </summary>
        public float PercentComplete => UnityEngine.Mathf.Clamp01(this.elapsed / this.duration);

        /// <summary>
        /// The amount of seconds the tween waits before playing after being
        /// started.
        /// </summary>
        public float delay = Settings.defaultDelay;

        /// <summary>
        /// The amount of seconds that have elapsed during the tween's delayed
        /// state, when applicable.
        /// </summary>
        public float delayElapsed { get; private set; } = 0.0f;

        /// <summary>
        /// Whether the tween is currently in a delayed state, i.e., the tween
        /// has been started but the elapsed time has not exceeded the delay
        /// duration.
        /// </summary>
        public bool IsDelayed => this.delayElapsed < this.delay;

        /// <summary>
        /// The easing function type used by the tween to animate values.
        /// </summary>
        public Ease ease = Settings.defaultEase;

        /// <summary>
        /// Animates from the end value to the start value as opposed to
        /// animating from the start value to the end value like normal.
        /// </summary>
        public bool reversed = false;

        /// <summary>
        /// Constructs a new tween object.
        /// </summary>
        public Tween() : base() {}

        /// <summary>
        /// Plays the tween, whether starting for the first time or resuming
        /// from a stopped state.
        /// </summary>
        public new Tween Play()
        {
            base.Play();
            return this;
        }

        private void Animate(float percentComplete)
        {
            if (this.parameter == null) {
                return;
            }

            if (this.reversed) {
                percentComplete = 1.0f - percentComplete;
            }

            float time = EaseFunction.lookup[this.ease](percentComplete);
            this.parameter.Interpolate(time);
        }

        protected override void OnUpdate(float deltaTime)
        {
            if (this.elapsed >= this.duration)
            {
                Complete();
            }
            else if (!this.IsDelayed)
            {
                this.elapsed += deltaTime;

                Animate(this.PercentComplete);
            }
            else
            {
                this.delayElapsed += deltaTime;
            }
        }

        protected override void OnStart()
        {
            this.elapsed = 0.0f;
            this.delayElapsed = 0.0f;

            if (this.parameter != null) {
                this.parameter.Initialize();
            }

            Animate(0.0f);
        }

        protected override void OnComplete()
        {
            this.elapsed = this.duration;
            this.delayElapsed = this.delay;

            Animate(1.0f);
        }

        protected override void OnKill()
        {
            this.parameter = null;
        }

        protected override void OnReset()
        {
            this.parameter = null;

            this.duration = Settings.defaultDuration;
            this.elapsed = 0.0f;

            this.delay = Settings.defaultDelay;
            this.delayElapsed = 0.0f;

            this.ease = Settings.defaultEase;
            this.reversed = false;
        }

    }

}
