namespace Zigurous.Animation.Tweening
{
    /// <summary>
    /// A type that can be animated over time from a tween.
    /// </summary>
    public interface ITweenable
    {
        void Initialize();
        void Interpolate(float time);
    }

}
