using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public struct Vector2Adapter : IAdapter<Vector2>, ITweenable
    {
        public System.Func<Vector2> getter;
        public System.Action<Vector2> setter;
        public Vector2 startValue;
        public Vector2 endValue;

        public ITweenable Build(System.Func<Vector2> getter, System.Action<Vector2> setter, Vector2 endValue)
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
            setter(Vector2.Lerp(this.startValue, this.endValue, time));
        }

    }

}
