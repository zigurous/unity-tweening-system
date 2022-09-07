using UnityEngine.SceneManagement;

namespace Zigurous.Tweening
{
    /// <summary>
    /// The base class of every tween.
    /// </summary>
    public abstract class Tween
    {
        /// <summary>
        /// A set of configuration flags available for a tween.
        /// </summary>
        [System.Flags]
        internal enum Flag
        {
            None        = 0,
            Reversed    = 1 << 0,
            Snapping    = 1 << 1,
            Recyclable  = 1 << 2,
            AutoStart   = 1 << 3,
            AutoKill    = 1 << 4,
        }

        /// <summary>
        /// An identifier that can be used to distinguish the tween from others.
        /// This is not explicitly required nor is it necessarily unique. The id
        /// is often used to identify which object the parameter being animated
        /// belongs to, and often that object is animating multiple parameters.
        /// </summary>
        public int id;

        /// <summary>
        /// The index of the scene that contains the object being animated by
        /// the tween. The is used to kill the tween when the scene is unloaded.
        /// </summary>
        public int sceneIndex = -1;

        /// <summary>
        /// The type of tween, used internally for managing and recycling
        /// tweens.
        /// </summary>
        internal TweenType type;

        /// <summary>
        /// The template type used by the tween, if relevant.
        /// </summary>
        internal System.Type template;

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
        public bool IsPlaying => state == TweenState.Playing;

        /// <summary>
        /// Whether the tween is stopped.
        /// </summary>
        public bool IsStopped => state == TweenState.Stopped;

        /// <summary>
        /// Whether the tween is complete.
        /// </summary>
        public bool IsComplete => state == TweenState.Complete;

        /// <summary>
        /// Whether the tween is killed.
        /// </summary>
        public bool IsKilled => state == TweenState.Killed;

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
        public float elapsed { get; internal set; }

        /// <summary>
        /// The tween's percentage of completion.
        /// </summary>
        public float PercentComplete => duration > 0f ? UnityEngine.Mathf.Clamp01(elapsed / duration) : 1f;

        /// <summary>
        /// The amount of seconds the tween waits before playing after being
        /// started.
        /// </summary>
        public float delay = Settings.defaultDelay;

        /// <summary>
        /// The amount of seconds that have elapsed during the tween's delayed
        /// state, when applicable.
        /// </summary>
        public float delayElapsed { get; internal set; }

        /// <summary>
        /// Whether the tween is currently in a delayed state, i.e., the tween
        /// has been started but the elapsed time has not exceeded the delay
        /// duration.
        /// </summary>
        public bool IsDelayed => delayElapsed < delay;

        /// <summary>
        /// The number of times the tween loops. A value of -1 will loop the
        /// tween infinitely.
        /// </summary>
        public int loops;

        /// <summary>
        /// The style in which the tween loops.
        /// </summary>
        public LoopType loopType;

        /// <summary>
        /// The number of times the tween has completed.
        /// </summary>
        public int iterations { get; internal set; }

        /// <summary>
        /// The configuration flags set on the tween.
        /// </summary>
        internal Flag flags = 0;

        /// <summary>
        /// Animates from the end value to the start value as opposed to
        /// animating from the start value to the end value like normal.
        /// </summary>
        public bool reversed
        {
            get => GetFlag(Flag.Reversed);
            set => SetFlag(Flag.Reversed, value);
        }

        /// <summary>
        /// Smoothly snaps all interpolated values to whole numbers.
        /// </summary>
        public bool snapping
        {
            get => GetFlag(Flag.Snapping);
            set => SetFlag(Flag.Snapping, value);
        }

        /// <summary>
        /// Keeps the tween in memory to be re-used after being killed.
        /// </summary>
        public bool recyclable
        {
            get => GetFlag(Flag.Recyclable);
            set => SetFlag(Flag.Recyclable, value);
        }

        /// <summary>
        /// Automatically starts the tween after being created.
        /// </summary>
        public bool autoStart
        {
            get => GetFlag(Flag.AutoStart);
            set => SetFlag(Flag.AutoStart, value);
        }

        /// <summary>
        /// Automatically kills the tween after being completed.
        /// </summary>
        public bool autoKill
        {
            get => GetFlag(Flag.AutoKill);
            set => SetFlag(Flag.AutoKill, value);
        }

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
        /// The callback invoked when the tween is looped.
        /// </summary>
        public TweenCallback onLoop;

        /// <summary>
        /// The callback invoked when the tween is completed.
        /// </summary>
        public TweenCallback onComplete;

        /// <summary>
        /// The callback invoked when the tween is killed.
        /// </summary>
        public TweenCallback onKill;

        /// <summary>
        /// Creates a new tween object.
        /// </summary>
        public Tween()
        {
            Reset();

            if (!TweenManager.Unloading) {
                TweenManager.Instance.Track(this);
            }
        }

        /// <summary>
        /// Animates the parameter being tweened to the current state.
        /// </summary>
        public abstract void Animate();

        /// <summary>
        /// Advances the tween's elapsed time by the given delta time causing
        /// the tween to be animated and any lifecycle events to be triggered.
        /// </summary>
        /// <param name="deltaTime">The amount of time to advance the tween by.</param>
        internal void Update(float deltaTime)
        {
            if (!IsPlaying)
            {
                if (state == TweenState.Ready && autoStart) {
                    Play();
                }
                return;
            }

            if (!IsDelayed)
            {
                elapsed += deltaTime;

                Animate();
                OnUpdate();

                if (onUpdate != null) {
                    onUpdate.Invoke();
                }

                // Once finished we check if the tween should loop before
                // considering it complete
                if (IsFinished() && !Loop()) {
                    Complete();
                }
            }
            else
            {
                delayElapsed += deltaTime;

                // Start the tween once the delay is complete and only if the
                // elapsed time is zero which indicates it has never been
                // updated yet
                if (delayElapsed >= delay && elapsed == 0) {
                    Start();
                }
            }
        }

        /// <summary>
        /// Plays the tween, whether starting for the first time or resuming
        /// from a stopped state.
        /// </summary>
        public void Play()
        {
            if (!state.CanTransition(TweenState.Playing)) {
                return;
            }

            TweenState previousState = state;

            state = TweenState.Playing;
            internalState = InternalTweenState.Active;

            if (previousState == TweenState.Stopped)
            {
                OnResume();
            }
            else
            {
                elapsed = 0f;
                delayElapsed = 0f;

                if (!IsDelayed) {
                    Start();
                }
            }
        }

        /// <summary>
        /// Starts the tween for the first time.
        /// </summary>
        private void Start()
        {
            if (iterations > 0)
            {
                OnLoop();

                if (onLoop != null) {
                    onLoop.Invoke();
                }
            }

            OnStart();
            Animate();

            if (iterations == 0 && onStart != null) {
                onStart.Invoke();
            }
        }

        /// <summary>
        /// Stops the tween if currently being played.
        /// </summary>
        public void Stop()
        {
            if (!state.CanTransition(TweenState.Stopped)) {
                return;
            }

            state = TweenState.Stopped;

            OnStop();

            if (onStop != null) {
                onStop.Invoke();
            }
        }

        /// <summary>
        /// Loops the tween on completion.
        /// </summary>
        /// <returns>True if the tween is looped.</returns>
        private bool Loop()
        {
            iterations++;

            if (iterations >= loops && loops != -1) {
                return false;
            }

            elapsed = 0f;

            switch (loopType)
            {
                case LoopType.RestartWithDelay:
                    delayElapsed = 0f;
                    break;

                case LoopType.PingPong:
                    reversed = !reversed;
                    break;

                case LoopType.PingPongWithDelay:
                    reversed = !reversed;
                    delayElapsed = 0f;
                    break;
            }

            if (!IsDelayed) {
                Start();
            }

            return true;
        }

        /// <summary>
        /// Completes the tween, jumping to the end value.
        /// </summary>
        public void Complete()
        {
            if (!state.CanTransition(TweenState.Complete)) {
                return;
            }

            state = TweenState.Complete;
            elapsed = duration;
            delayElapsed = delay;

            Animate();
            OnComplete();

            if (onComplete != null) {
                onComplete.Invoke();
            }

            if (autoKill) {
                Kill();
            }
        }

        /// <summary>
        /// Kills the tween in its place, preventing any further state changes
        /// or changes to the parameter being animated.
        /// </summary>
        public void Kill()
        {
            if (!state.CanTransition(TweenState.Killed)) {
                return;
            }

            state = TweenState.Killed;
            internalState = InternalTweenState.Dequeued;

            OnKill();

            if (onKill != null) {
                onKill.Invoke();
            }

            onKill = null;
            onUpdate = null;
            onStart = null;
            onStop = null;
            onLoop = null;
            onComplete = null;
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
            id = -1;
            sceneIndex = SceneManager.GetActiveScene().buildIndex;

            state = TweenState.Ready;
            internalState = InternalTweenState.Queued;

            ease = Settings.defaultEase;
            duration = Settings.defaultDuration;
            elapsed = 0f;
            delay = Settings.defaultDelay;
            delayElapsed = 0f;

            loops = 0;
            loopType = LoopType.Restart;
            iterations = 0;

            flags = 0;
            reversed = false;
            snapping = false;
            autoStart = Settings.autoStart;
            autoKill = Settings.autoKill;
            recyclable = Settings.recyclable;

            onUpdate = null;
            onStart = null;
            onStop = null;
            onLoop = null;
            onComplete = null;
            onKill = null;

            OnReset();
        }

        internal bool GetFlag(Flag flag)
        {
            return flags.Has(flag);
        }

        internal void SetFlag(Flag flag, bool on)
        {
            if (on) {
                flags |= flag;
            } else {
                flags &= ~flag;
            }
        }

        /// <summary>
        /// Determines if the tween has finished playing.
        /// </summary>
        /// <returns>True if the tween has finished playing.</returns>
        protected virtual bool IsFinished() => elapsed >= duration;

        /// <summary>
        /// Override to handle custom logic when the tween is updated.
        /// </summary>
        protected virtual void OnUpdate() {}

        /// <summary>
        /// Override to handle custom logic when the tween is started.
        /// </summary>
        protected virtual void OnStart() {}

        /// <summary>
        /// Override to handle custom logic when the tween is stopped.
        /// </summary>
        protected virtual void OnStop() {}

        /// <summary>
        /// Override to handle custom logic when the tween is resumed.
        /// </summary>
        protected virtual void OnResume() {}

        /// <summary>
        /// Override to handle custom logic when the tween is looped.
        /// </summary>
        protected virtual void OnLoop() {}

        /// <summary>
        /// Override to handle custom logic when the tween is completed.
        /// </summary>
        protected virtual void OnComplete() {}

        /// <summary>
        /// Override to handle custom logic when the tween is killed.
        /// </summary>
        protected virtual void OnKill() {}

        /// <summary>
        /// Override to handle custom logic when the tween is reset.
        /// </summary>
        protected virtual void OnReset() {}

    }

}
