namespace Zigurous.Tweening
{
    /// <summary>
    /// A type that responds to tween lifecycle events.
    /// </summary>
    public interface ITweenEventHandler
    {
        /// <summary>
        /// An event invoked every time the tween is updated, i.e., any time the
        /// parameter being animated is changed.
        /// </summary>
        /// <param name="tween">The tween that invoked the event.</param>
        void OnTweenUpdate(Tween tween);

        /// <summary>
        /// An event invoked when the tween is started.
        /// </summary>
        /// <param name="tween">The tween that invoked the event.</param>
        void OnTweenStart(Tween tween);

        /// <summary>
        /// An event invoked when the tween is stopped.
        /// </summary>
        /// <param name="tween">The tween that invoked the event.</param>
        void OnTweenStop(Tween tween);

        /// <summary>
        /// An event invoked when the tween is looped.
        /// </summary>
        /// <param name="tween">The tween that invoked the event.</param>
        void OnTweenLoop(Tween tween);

        /// <summary>
        /// An event invoked when the tween is completed.
        /// </summary>
        /// <param name="tween">The tween that invoked the event.</param>
        void OnTweenComplete(Tween tween);

        /// <summary>
        /// An event invoked when the tween is killed.
        /// </summary>
        /// <param name="tween">The tween that invoked the event.</param>
        void OnTweenKill(Tween tween);
    }

}
