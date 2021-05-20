namespace Zigurous.Animation.Tweening
{
    public abstract class TweenBase
    {
        internal int id;
        internal InternalTweenState internalState = InternalTweenState.Queued;
        public TweenState state { get; internal set; } = TweenState.Ready;
        public bool IsPlaying => this.state == TweenState.Playing;
        public bool IsStopped => this.state == TweenState.Stopped;
        public bool IsComplete => this.state == TweenState.Complete;
        public bool IsKilled => this.state == TweenState.Killed;

        public bool autoStart = Settings.defaultAutoStart;
        public bool autoKill = Settings.defaultAutoKill;
        public bool recyclable = Settings.defaultRecyclable;

        public delegate void Callback();
        public Callback onUpdate;
        public Callback onStart;
        public Callback onStop;
        public Callback onComplete;
        public Callback onKill;

        internal TweenBase()
        {
            TweenManager.Instance.Track(this);
        }

        internal void Update(float deltaTime)
        {
            if (this.IsPlaying)
            {
                OnUpdate(deltaTime);

                if (this.onUpdate != null) {
                    this.onUpdate.Invoke();
                }
            }
            else if (this.state == TweenState.Ready && this.autoStart)
            {
                Play();
            }
        }

        public void Play()
        {
            if (this.state.CanTransition(TweenState.Playing)) {
                TransitionToPlaying(this.state);
            }
        }

        public void Stop()
        {
            if (this.state.CanTransition(TweenState.Stopped)) {
                TransitionToStopped();
            }
        }

        public void Complete()
        {
            if (this.state.CanTransition(TweenState.Complete)) {
                TransitionToComplete();
            }
        }

        public void Kill()
        {
            if (this.state.CanTransition(TweenState.Killed)) {
                TransitionToKilled();
            }
        }

        public void Restart()
        {
            Stop();
            Play();
        }

        private void TransitionToPlaying(TweenState previousState)
        {
            this.state = TweenState.Playing;
            this.internalState = InternalTweenState.Active;

            if (previousState == TweenState.Stopped)
            {
                OnResume();
            }
            else
            {
                OnStart();

                if (this.onStart != null) {
                    this.onStart.Invoke();
                }
            }
        }

        private void TransitionToStopped()
        {
            this.state = TweenState.Stopped;

            OnStop();

            if (this.onStop != null) {
                this.onStop.Invoke();
            }
        }

        private void TransitionToComplete()
        {
            this.state = TweenState.Complete;

            OnComplete();

            if (this.onComplete != null) {
                this.onComplete.Invoke();
            }

            if (this.autoKill) {
                Kill();
            }
        }

        private void TransitionToKilled()
        {
            this.state = TweenState.Killed;
            this.internalState = InternalTweenState.Dequeued;

            OnKill();

            if (this.onKill != null) {
                this.onKill.Invoke();
            }

            this.onUpdate = null;
            this.onStart = null;
            this.onStop = null;
            this.onComplete = null;
            this.onKill = null;
        }

        internal void Reset()
        {
            this.id = 0;
            this.state = TweenState.Ready;
            this.internalState = InternalTweenState.Queued;
            this.autoStart = Settings.defaultAutoStart;
            this.autoKill = Settings.defaultAutoKill;
            this.recyclable = Settings.defaultRecyclable;

            this.onUpdate = null;
            this.onStart = null;
            this.onStop = null;
            this.onComplete = null;
            this.onKill = null;

            OnReset();
        }

        protected virtual void OnUpdate(float deltaTime) {}
        protected virtual void OnStart() {}
        protected virtual void OnStop() {}
        protected virtual void OnResume() {}
        protected virtual void OnComplete() {}
        protected virtual void OnKill() {}
        protected virtual void OnReset() {}

    }

}
