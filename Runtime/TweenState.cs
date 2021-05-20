namespace Zigurous.Animation.Tweening
{
    public enum TweenState
    {
        Ready,
        Playing,
        Stopped,
        Complete,
        Killed
    }

    internal enum InternalTweenState
    {
        Queued,
        Active,
        Dequeued,
        Recycled,
        Killed
    }

    public static class TweenStateExtensions
    {
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
