using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public struct FloatAdapter : IAdapter<float>, ITweenable
    {
        public System.Func<float> getter;
        public System.Action<float> setter;
        public float startValue;
        public float endValue;

        public ITweenable Build(System.Func<float> getter, System.Action<float> setter, float endValue)
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
            setter(Mathf.Lerp(this.startValue, this.endValue, time));
        }

    }

}
