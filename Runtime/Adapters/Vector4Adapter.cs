using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public struct Vector4Adapter : IAdapter<Vector4>, ITweenable
    {
        public System.Func<Vector4> getter;
        public System.Action<Vector4> setter;
        public Vector4 startValue;
        public Vector4 endValue;

        public ITweenable Build(System.Func<Vector4> getter, System.Action<Vector4> setter, Vector4 endValue)
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
            setter(Vector4.Lerp(this.startValue, this.endValue, time));
        }

    }

}
