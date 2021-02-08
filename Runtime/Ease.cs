using System.Collections.Generic;

namespace Zigurous.Animation.Tweening
{
    public enum Ease : int
    {
        Linear,
        SineIn,
        SineOut,
        SineInOut,
        CubicIn,
        CubicOut,
        CubicInOut,
        QuadIn,
        QuadOut,
        QuadInOut,
        QuartIn,
        QuartOut,
        QuartInOut,
        QuintIn,
        QuintOut,
        QuintInOut,
        ExpoIn,
        ExpoOut,
        ExpoInOut,
        CircIn,
        CircOut,
        CircInOut,
        BackIn,
        BackOut,
        BackInOut,
        ElasticIn,
        ElasticOut,
        ElasticInOut,
        BounceIn,
        BounceOut,
        BounceInOut
    }

    public sealed class EaseEqualityComparer : IEqualityComparer<Ease>
    {
        public bool Equals(Ease x, Ease y) => x == y;

        public int GetHashCode(Ease ease) => (int)ease;
    }

}
