using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public struct ColorAdapter : IAdapter<Color>, ITweenable
    {
        public System.Func<Color> getter;
        public System.Action<Color> setter;
        public Color startValue;
        public Color endValue;

        public ITweenable Build(System.Func<Color> getter, System.Action<Color> setter, Color endValue)
        {
            this.getter = getter;
            this.setter = setter;
            this.endValue = endValue;

            return this;
        }

        public void Initialize()
        {
            this.startValue = getter();
        }

        public void Interpolate(float time)
        {
            setter(Color.Lerp(this.startValue, this.endValue, time));
        }

    }

}
