using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public struct DoubleAdapter : IAdapter<double>, ITweenable
    {
        public System.Func<double> getter;
        public System.Action<double> setter;
        public double startValue;
        public double endValue;

        public ITweenable Build(System.Func<double> getter, System.Action<double> setter, double endValue)
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
            setter(Mathf.Lerp((float)this.startValue, (float)this.endValue, time));
        }

    }

}
