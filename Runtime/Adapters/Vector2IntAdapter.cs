using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public struct Vector2IntAdapter : IAdapter<Vector2Int>, ITweenable
    {
        public System.Func<Vector2Int> getter;
        public System.Action<Vector2Int> setter;
        public Vector2 startValue;
        public Vector2 endValue;

        public ITweenable Build(System.Func<Vector2Int> getter, System.Action<Vector2Int> setter, Vector2Int endValue)
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
            Vector2 value = Vector2.Lerp(this.startValue, this.endValue, time);
            setter(new Vector2Int((int)value.x, (int)value.y));
        }

    }

}
