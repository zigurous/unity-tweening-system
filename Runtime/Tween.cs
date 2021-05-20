namespace Zigurous.Animation.Tweening
{
    public sealed class Tween : TweenBase
    {
        public delegate float Getter();
        public delegate void Setter(float value);
        internal Getter getter;
        internal Setter setter;

        public float startValue;
        public float endValue;

        public float duration = Settings.defaultDuration;
        public float elapsed { get; private set; } = 0.0f;
        public float PercentComplete => UnityEngine.Mathf.Clamp01(this.elapsed / this.duration);

        public float delay = Settings.defaultDelay;
        public float delayElapsed { get; private set; } = 0.0f;
        public bool IsDelayed => this.delayElapsed < this.delay;

        public Ease ease = Settings.defaultEase;
        public bool reversed = Settings.defaultReversed;

        public Tween() : base() {}

        public new Tween Play()
        {
            base.Play();
            return this;
        }

        private void Animate(float percentComplete)
        {
            if (this.setter == null) {
                return;
            }

            if (this.reversed) {
                percentComplete = 1.0f - percentComplete;
            }

            EaseFunction function = EaseFunctions.functions[this.ease];
            float time = function(percentComplete);

            float value = time * (this.endValue - this.startValue) + this.startValue;
            this.setter.Invoke(value);
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

            if (this.getter != null) {
                this.startValue = this.getter.Invoke();
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
            this.getter = null;
            this.setter = null;
        }

        protected override void OnReset()
        {
            this.getter = null;
            this.setter = null;

            this.startValue = 0.0f;
            this.endValue = 0.0f;

            this.duration = Settings.defaultDuration;
            this.elapsed = 0.0f;

            this.delay = Settings.defaultDelay;
            this.delayElapsed = 0.0f;

            this.ease = Settings.defaultEase;
            this.reversed = Settings.defaultReversed;
        }

    }

}
