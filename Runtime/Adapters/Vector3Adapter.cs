using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public struct Vector3Adapter : IAdapter<Vector3>, ITweenable
    {
        public System.Func<Vector3> getter;
        public System.Action<Vector3> setter;
        public Vector3 startValue;
        public Vector3 endValue;

        public ITweenable Build(System.Func<Vector3> getter, System.Action<Vector3> setter, Vector3 endValue)
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
            setter(Vector3.Lerp(this.startValue, this.endValue, time));
        }

    }

}
