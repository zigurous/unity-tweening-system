using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public struct LongAdapter : IAdapter<long>, ITweenable
    {
        public System.Func<long> getter;
        public System.Action<long> setter;
        public long startValue;
        public long endValue;

        public ITweenable Build(System.Func<long> getter, System.Action<long> setter, long endValue)
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
            setter((long)Mathf.Lerp(this.startValue, this.endValue, time));
        }

    }

}
