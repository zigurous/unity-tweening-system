namespace Zigurous.Animation.Tweening
{
    /// <summary>
    /// The base class for all tween objects. The base class manages the
    /// external and internal state of a tween.
    /// </summary>
    public abstract class TweenBase
    {
        /// <summary>
        /// An identifier that can be used to distinguish the tween from others.
        /// This is not explicitly required nor is it necessarily unique. The id
        /// is often used to identify which object the parameter being animated
        /// belongs to, and often that object is animating multiple parameters.
        /// </summary>
        public int id;

        /// <summary>
        /// The internal state of the tween as it relates to the lifeycle and
        /// management of the tween.
        /// </summary>
        internal InternalTweenState internalState = InternalTweenState.Queued;

        /// <summary>
        /// The animation state of the tween.
        /// </summary>
        public TweenState state { get; internal set; } = TweenState.Ready;

        /// <summary>
        /// Whether the tween is playing.
        /// </summary>
        public bool IsPlaying => this.state == TweenState.Playing;

        /// <summary>
        /// Whether the tween is stopped.
        /// </summary>
        public bool IsStopped => this.state == TweenState.Stopped;

        /// <summary>
        /// Whether the tween is complete.
        /// </summary>
        public bool IsComplete => this.state == TweenState.Complete;

        /// <summary>
        /// Whether the tween is killed.
        /// </summary>
        public bool IsKilled => this.state == TweenState.Killed;

        /// <summary>
        /// Automatically starts the tween after being created.
        /// </summary>
        public bool autoStart = Settings.defaultAutoStart;

        /// <summary>
        /// Automatically kills the tween after being completed.
        /// </summary>
        public bool autoKill = Settings.defaultAutoKill;

        /// <summary>
        /// Keeps the tween in memory to be re-used after being killed.
        /// </summary>
        public bool recyclable = Settings.defaultRecyclable;

        /// <summary>
        /// A function type that can be invoked during various tween events
        /// and/or state changes.
        /// </summary>
        public delegate void Callback();

        /// <summary>
        /// The callback invoked every time the tween is updated, i.e., any time
        /// the parameter being animated is changed.
        /// </summary>
        public Callback onUpdate;

        /// <summary>
        /// The callback invoked when the tween is started.
        /// </summary>
        public Callback onStart;

        /// <summary>
        /// The callback invoked when the tween is stopped.
        /// </summary>
        public Callback onStop;

        /// <summary>
        /// The callback invoked when the tween is completed.
        /// </summary>
        public Callback onComplete;

        /// <summary>
        /// The callback invoked when the tween is killed.
        /// </summary>
        public Callback onKill;

        /// <summary>
        /// Constructs a new tween object.
        /// </summary>
        internal TweenBase()
        {
            TweenManager.Instance.Track(this);
        }

        /// <summary>
        /// Increases the tween's elapsed time by the given delta time which
        /// sets a new value of the parameter being animated and triggers any
        /// necessary state changes.
        /// </summary>
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

        /// <summary>
        /// Plays the tween, whether starting for the first time or resuming
        /// from a stopped state.
        /// </summary>
        public void Play()
        {
            if (this.state.CanTransition(TweenState.Playing)) {
                TransitionToPlaying(this.state);
            }
        }

        /// <summary>
        /// Stops the tween if currently being played.
        /// </summary>
        public void Stop()
        {
            if (this.state.CanTransition(TweenState.Stopped)) {
                TransitionToStopped();
            }
        }

        /// <summary>
        /// Completes the tween, jumping to the end value.
        /// </summary>
        public void Complete()
        {
            if (this.state.CanTransition(TweenState.Complete)) {
                TransitionToComplete();
            }
        }

        /// <summary>
        /// Kills the tween in its place, preventing any further state changes
        /// or changes to the parameter being animated.
        /// </summary>
        public void Kill()
        {
            if (this.state.CanTransition(TweenState.Killed)) {
                TransitionToKilled();
            }
        }

        /// <summary>
        /// Restarts the tween as along as it has not been killed.
        /// </summary>
        public void Restart()
        {
            Stop();
            Play();
        }

        /// <summary>
        /// Resets all properties of the tween back to their default values.
        /// </summary>
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

        protected virtual void OnUpdate(float deltaTime) {}
        protected virtual void OnStart() {}
        protected virtual void OnStop() {}
        protected virtual void OnResume() {}
        protected virtual void OnComplete() {}
        protected virtual void OnKill() {}
        protected virtual void OnReset() {}

    }

}
