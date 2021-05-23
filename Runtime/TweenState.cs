namespace Zigurous.TweenEngine
{
    /// <summary>
    /// A type of animation state that a tween can be in.
    /// </summary>
    public enum TweenState
    {
        /// <summary>
        /// The tween has been initialized and is ready to be played.
        /// </summary>
        Ready,

        /// <summary>
        /// The tween is currently playing and receiving updates.
        /// </summary>
        Playing,

        /// <summary>
        /// The tween is currently stopped/paused.
        /// </summary>
        Stopped,

        /// <summary>
        /// The tween has completed but not yet killed.
        /// </summary>
        Complete,

        /// <summary>
        /// The tween is killed, making it no longer usable.
        /// </summary>
        Killed
    }

    /// <summary>
    /// A type of state that a tween can be in as it relates to the lifecycle
    /// and management of the tween.
    /// </summary>
    internal enum InternalTweenState
    {
        /// <summary>
        /// The tween is waiting to be marked as active.
        /// </summary>
        Queued,

        /// <summary>
        /// The tween is currently active and receiving updates.
        /// </summary>
        Active,

        /// <summary>
        /// The tween is waiting to be recycled or killed.
        /// </summary>
        Dequeued,

        /// <summary>
        /// The tween is inactive but stays in memory to be re-used.
        /// </summary>
        Recycled,

        /// <summary>
        /// The tween is inactive and can no longer be used.
        /// </summary>
        Killed
    }

    public static class TweenStateExtensions
    {
        /// <summary>
        /// Determines if the current state can transition to a new state.
        /// </summary>
        public static bool CanTransition(this TweenState state, TweenState transition)
        {
            // Cannot transition to self
            if (state == transition) {
                return false;
            }

            // Killed tweens cannot make any state changes
            if (state == TweenState.Killed) {
                return false;
            }

            // Cannot transition to Ready state, reserved internally
            if (transition == TweenState.Ready) {
                return false;
            }

            // Determine state-specific transitions
            switch (transition)
            {
                case TweenState.Stopped:
                    return state == TweenState.Playing;

                default:
                    return true;
            }
        }

    }

}
