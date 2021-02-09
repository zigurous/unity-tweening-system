namespace Zigurous.Animation.Tweening
{
    public sealed class Tween
    {
        public delegate float Getter();
        public delegate void Setter(float value);
        public delegate void Callback();

        public int id;

        public Ease ease = Settings.defaultEase;
        public bool reversed = Settings.defaultReversed;
        public bool autoStart = Settings.defaultAutoStart;
        public bool autoKill = Settings.defaultAutoKill;
        public bool recyclable = Settings.defaultRecyclable;

        internal Getter getter;
        internal Setter setter;
        internal float startValue;
        internal float endValue;

        public float duration = Settings.defaultDuration;
        public float elapsed { get; private set; } = 0.0f;
        public float PercentComplete => UnityEngine.Mathf.Clamp01(this.elapsed / this.duration);

        public float delay = Settings.defaultDelay;
        public float delayElapsed { get; private set; } = 0.0f;

        public TweenState state { get; private set; } = TweenState.Queued;
        public bool IsQueued => this.state == TweenState.Queued;
        public bool IsPlaying => this.state == TweenState.Playing;
        public bool IsDelayed => this.delayElapsed < this.delay;
        public bool IsDelayComplete => this.delayElapsed >= this.delay;
        public bool IsStopped => this.state == TweenState.Stopped;
        public bool IsComplete => this.state == TweenState.Complete;
        public bool IsKilled => this.state == TweenState.Killed;

        public Callback onUpdate;
        public Callback onStart;
        public Callback onStop;
        public Callback onRestart;
        public Callback onComplete;
        public Callback onKill;

        internal Tween() {}
        public Tween(Getter getter, Setter setter, float endValue, float duration)
        {
            this.getter = getter;
            this.setter = setter;
            this.endValue = endValue;
            this.duration = duration;
        }

        internal void Update(float deltaTime)
        {
            if (this.IsQueued && this.autoStart) {
                Start();
                return;
            }

            if (!this.IsPlaying) {
                return;
            }

            if (this.IsDelayed) {
                this.delayElapsed += deltaTime;
                return;
            }

            this.elapsed += deltaTime;
            Animate(this.PercentComplete);

            this.onUpdate?.Invoke();

            if (this.elapsed >= this.duration) {
                Complete();
            }
        }

        private void Animate(float percentComplete)
        {
            if (this.reversed) percentComplete = 1.0f - percentComplete;
            EaseFunction function = EaseFunctions.functions[this.ease];
            float time = function(percentComplete);
            this.setter(time * (this.endValue - this.startValue) + this.startValue);
        }

        public void Play()
        {
            if (!TweenStateTransition.CanPlay(this.state)) {
                return;
            }

            if (this.IsQueued) {
                Start();
            } else {
                this.state = TweenState.Playing;
            }
        }

        private void Start(bool withDelay = true)
        {
            this.elapsed = 0.0f;
            this.delayElapsed = withDelay ? 0.0f : this.delay;
            this.startValue = this.getter();
            this.state = TweenState.Playing;

            Animate(0.0f);

            this.onStart?.Invoke();
        }

        public void Stop()
        {
            if (!TweenStateTransition.CanStop(this.state)) {
                return;
            }

            this.state = TweenState.Stopped;
            this.onStop?.Invoke();
        }

        public void Restart(bool withDelay = true)
        {
            if (!TweenStateTransition.CanRestart(this.state)) {
                return;
            }

            Stop();
            Start(withDelay);

            this.onRestart?.Invoke();
        }

        public void Complete()
        {
            if (!TweenStateTransition.CanComplete(this.state)) {
                return;
            }

            this.elapsed = this.duration;
            this.delayElapsed = this.delay;
            this.state = TweenState.Complete;

            Animate(1.0f);

            this.onComplete?.Invoke();

            if (this.autoKill) {
                Kill();
            }
        }

        public void Kill()
        {
            if (!TweenStateTransition.CanKill(this.state)) {
                return;
            }

            this.state = TweenState.Killed;
            this.onKill?.Invoke();

            this.getter = null;
            this.setter = null;
            this.onUpdate = null;
            this.onStart = null;
            this.onStop = null;
            this.onRestart = null;
            this.onComplete = null;
            this.onKill = null;

            TweenUpdater.Instance.Untrack(this);
        }

        internal void Reset()
        {
            this.state = TweenState.Queued;
            this.ease = Settings.defaultEase;
            this.reversed = Settings.defaultReversed;
            this.autoStart = Settings.defaultAutoStart;
            this.autoKill = Settings.defaultAutoKill;
            this.recyclable = Settings.defaultRecyclable;
            this.duration = Settings.defaultDuration;
            this.elapsed = 0.0f;
            this.delay = Settings.defaultDelay;
            this.delayElapsed = 0.0f;
        }

    }

}
