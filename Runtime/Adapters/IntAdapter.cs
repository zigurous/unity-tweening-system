using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public struct IntAdapter : IAdapter<int>, ITweenable
    {
        public System.Func<int> getter;
        public System.Action<int> setter;
        public int startValue;
        public int endValue;

        public ITweenable Build(System.Func<int> getter, System.Action<int> setter, int endValue)
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
            setter((int)Mathf.Lerp(this.startValue, this.endValue, time));
        }

    }

}
