namespace Zigurous.Animation.Tweening
{
    /// <summary>
    /// A type that can adapt to a tweenable type.
    /// </summary>
    public interface IAdapter<T>
    {
        ITweenable Build(System.Func<T> getter, System.Action<T> setter, T endValue);
    }

}
