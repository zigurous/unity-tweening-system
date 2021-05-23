using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public struct QuaternionAdapter : IAdapter<Quaternion>, ITweenable
    {
        public System.Func<Quaternion> getter;
        public System.Action<Quaternion> setter;
        public Quaternion startValue;
        public Quaternion endValue;

        public ITweenable Build(System.Func<Quaternion> getter, System.Action<Quaternion> setter, Quaternion endValue)
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
            setter(Quaternion.Lerp(this.startValue, this.endValue, time));
        }

    }

}
