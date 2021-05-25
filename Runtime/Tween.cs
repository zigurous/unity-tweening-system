namespace Zigurous.Tweening
{
    /// <summary>
    /// A tween object, an animation that changes a value over time using an
    /// easing function.
    /// </summary>
    public abstract class Tween
    {
        /// <summary>
        /// An identifier that can be used to distinguish the tween from others.
        /// This is not explicitly required nor is it necessarily unique. The id
        /// is often used to identify which object the parameter being animated
        /// belongs to, and often that object is animating multiple parameters.
        /// </summary>
        public int id;

        /// <summary>
        /// The template type used by the tween, if relevant.
        /// </summary>
        internal System.Type template;

        /// <summary>
        /// The type of tween, used internally for managing and recycling
        /// tweens.
        /// </summary>
        internal TweenType type;

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
        /// The easing function type used by the tween to animate values.
        /// </summary>
        public Ease ease = Settings.defaultEase;

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
        /// Animates from the end value to the start value as opposed to
        /// animating from the start value to the end value like normal.
        /// </summary>
        public bool reversed = false;

        /// <summary>
        /// Keeps the tween in memory to be re-used after being killed.
        /// </summary>
        public bool recyclable = Settings.defaultRecyclable;

        /// <summary>
        /// Automatically starts the tween after being created.
        /// </summary>
        public bool autoStart = Settings.defaultAutoStart;

        /// <summary>
        /// Automatically kills the tween after being completed.
        /// </summary>
        public bool autoKill = Settings.defaultAutoKill;

        /// <summary>
        /// The callback invoked every time the tween is updated, i.e., any time
        /// the parameter being animated is changed.
        /// </summary>
        public TweenCallback onUpdate;

        /// <summary>
        /// The callback invoked when the tween is started.
        /// </summary>
        public TweenCallback onStart;

        /// <summary>
        /// The callback invoked when the tween is stopped.
        /// </summary>
        public TweenCallback onStop;

        /// <summary>
        /// The callback invoked when the tween is completed.
        /// </summary>
        public TweenCallback onComplete;

        /// <summary>
        /// The callback invoked when the tween is killed.
        /// </summary>
        public TweenCallback onKill;

        /// <summary>
        /// Constructs a new tween object.
        /// </summary>
        internal Tween()
        {
            TweenManager.Instance.Track(this);
        }

        /// <summary>
        /// Animates the parameter being tweened to the latest state.
        /// </summary>
        protected abstract void Animate();

        /// <summary>
        /// Advances the tween's elapsed time by the given delta time causing
        /// the tween to be animated and any lifecycle events to be triggered.
        /// </summary>
        internal void Update(float deltaTime)
        {
            if (this.IsPlaying)
            {
                if (this.elapsed >= this.duration)
                {
                    Complete();
                }
                else if (!this.IsDelayed)
                {
                    this.elapsed += deltaTime;

                    Animate();
                    OnUpdate();

                    if (this.onUpdate != null) {
                        this.onUpdate.Invoke();
                    }
                }
                else
                {
                    this.delayElapsed += deltaTime;
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
            this.id = -1;
            this.state = TweenState.Ready;
            this.internalState = InternalTweenState.Queued;
            this.ease = Settings.defaultEase;
            this.duration = Settings.defaultDuration;
            this.elapsed = 0.0f;
            this.delay = Settings.defaultDelay;
            this.delayElapsed = 0.0f;
            this.reversed = false;
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
                this.elapsed = 0.0f;
                this.delayElapsed = 0.0f;

                OnStart();
                Animate();

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
            this.elapsed = this.duration;
            this.delayElapsed = this.delay;

            Animate();
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

            this.onKill = null;
            this.onUpdate = null;
            this.onStart = null;
            this.onStop = null;
            this.onComplete = null;
        }

        protected virtual void OnUpdate() {}
        protected virtual void OnStart() {}
        protected virtual void OnStop() {}
        protected virtual void OnResume() {}
        protected virtual void OnComplete() {}
        protected virtual void OnKill() {}
        protected virtual void OnReset() {}

    }

}
