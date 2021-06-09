namespace Zigurous.Tweening
{
    /// <summary>
    /// A type of loop style.
    /// </summary>
    public enum LoopType
    {
        /// <summary>
        /// Restarts the tween from the beginning after it ends.
        /// </summary>
        Restart,

        /// <summary>
        /// Restarts the tween from the beginning after it ends. If the tween
        /// has a delay it will be delayed again each loop.
        /// </summary>
        RestartWithDelay,

        /// <summary>
        /// Plays the tween forwards then backwards then forwards then
        /// backwards, etc.
        /// </summary>
        PingPong,

        /// <summary>
        /// Plays the tween forwards then backwards then forwards then
        /// backwards, etc.  If the tween has a delay it will be delayed again
        /// each loop.
        /// </summary>
        PingPongWithDelay,
    }

}
