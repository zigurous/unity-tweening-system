using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public struct Vector3IntAdapter : IAdapter<Vector3Int>, ITweenable
    {
        public System.Func<Vector3Int> getter;
        public System.Action<Vector3Int> setter;
        public Vector3 startValue;
        public Vector3 endValue;

        public ITweenable Build(System.Func<Vector3Int> getter, System.Action<Vector3Int> setter, Vector3Int endValue)
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
            Vector3 value = Vector3.Lerp(this.startValue, this.endValue, time);
            setter(new Vector3Int((int)value.x, (int)value.y, (int)value.z));
        }

    }

}
