namespace Zigurous.Tweening
{
    /// <summary>
    /// A function delegate that gets the current value of a parameter from an
    /// object.
    /// </summary>
    /// <typeparam name="T">The type of object to get the parameter from.</typeparam>
    /// <typeparam name="U">The type of the parameter.</typeparam>
    /// <param name="target">The object to get the value from.</param>
    /// <returns>The current value of the parameter.</returns>
    public delegate U TweenGetter<T,U>(T target);

    /// <summary>
    /// A function delegate that sets a new value of a parameter on an object.
    /// </summary>
    /// <typeparam name="T">The type of object to set the parameter on.</typeparam>
    /// <typeparam name="U">The type of the parameter.</typeparam>
    /// <param name="target">The object to set the value on.</param>
    /// <param name="value">The new value of the parameter.</param>
    public delegate void TweenSetter<T,U>(T target, U value);

    /// <summary>
    /// A function delegate invoked during tween lifecycle events.
    /// </summary>
    public delegate void TweenCallback();

    /// <summary>
    /// A function delegate invoked during tween lifecycle events with a
    /// provided reference to the tween that invoked the event.
    /// </summary>
    /// <param name="tween">The tween that invoked the event.</param>
    public delegate void TweenReferenceCallback(Tween tween);

    /// <summary>
    /// A function delegate that interpolates the value between
    /// <paramref name="a"/> and <paramref name="b"/> by <paramref name="t"/>.
    /// </summary>
    /// <typeparam name="T">The type of the parameter.</typeparam>
    /// <param name="a">The start value.</param>
    /// <param name="b">The end value.</param>
    /// <param name="t">The interpolation value between the start and end value.</param>
    /// <param name="snapping">Snaps the interpolated value to the nearest whole number.</param>
    /// <returns>The interpolated value between the start and end value.</returns>
    public delegate T Interpolater<T>(T a, T b, float t, bool snapping);
}
