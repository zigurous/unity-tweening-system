namespace Zigurous.TweenEngine
{
    /// <summary>
    /// A function type that gets the current value of a parameter.
    /// </summary>
    public delegate T TweenGetter<T>();

    /// <summary>
    /// A function type that sets a new value of a parameter.
    /// </summary>
    public delegate void TweenSetter<T>(T value);

    /// <summary>
    /// A function type that can be invoked during various tween events and/or
    /// state changes.
    /// </summary>
    public delegate void TweenCallback();

    /// <summary>
    /// A function type that interpolates the value between a and b by t.
    /// </summary>
    public delegate T Interpolater<T>(T a, T b, float t);

}
