namespace Zigurous.Animation.Tweening
{
    public enum TweenState
    {
        Queued,
        Playing,
        Stopped,
        Complete,
        Killed
    }

    internal static class TweenStateTransition
    {
        internal static bool CanPlay(TweenState state) =>
            state != TweenState.Playing && state != TweenState.Complete && state != TweenState.Killed;
        internal static bool CanStop(TweenState state) =>
            state == TweenState.Playing;
        internal static bool CanRestart(TweenState state) =>
            state != TweenState.Killed;
        internal static bool CanComplete(TweenState state) =>
            state != TweenState.Complete && state != TweenState.Killed;
        internal static bool CanKill(TweenState state) =>
            state != TweenState.Killed;
    }

}
