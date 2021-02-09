using System.Collections.Generic;
using UnityEngine;
using Zigurous.DataStructures;

namespace Zigurous.Animation.Tweening
{
    internal sealed class TweenUpdater : SingletonBehavior<TweenUpdater>
    {
        public List<Tween> tweens { get; private set; } = new List<Tween>(64);
        private List<Tween> _tweensToAdd = new List<Tween>(16);
        private List<Tween> _tweensToRemove = new List<Tween>(16);
        private ObjectPool<Tween> _tweensPool = new ObjectPool<Tween>(() => new Tween(), 64);

        public void Track(Tween tween)
        {
            _tweensToAdd.Add(tween);
            _tweensToRemove.Remove(tween);
        }

        public void Untrack(Tween tween)
        {
            _tweensToRemove.Add(tween);
            _tweensToAdd.Remove(tween);
        }

        internal Tween AcquireTween(Tween.Getter getter, Tween.Setter setter, float endValue, float duration)
        {
            Tween tween = _tweensPool.Retrieve();

            if (tween == null) {
                tween = new Tween();
            } else {
                tween.Reset();
            }

            tween.getter = getter;
            tween.setter = setter;
            tween.endValue = endValue;
            tween.duration = duration;

            Track(tween);

            return tween;
        }

        protected override void OnDestroy()
        {
            Tweener.KillAll();

            this.tweens.Clear();
            this.tweens = null;

            _tweensToAdd.Clear();
            _tweensToAdd = null;

            _tweensToRemove.Clear();
            _tweensToRemove = null;

            _tweensPool.Dispose();
            _tweensPool = null;

            base.OnDestroy();
        }

        private void Update()
        {
            // Update all tweens
            if (this.tweens.Count > 0)
            {
                float deltaTime = Time.deltaTime;

                foreach (Tween tween in this.tweens) {
                    tween.Update(deltaTime);
                }
            }

            // Add new tweens
            if (_tweensToAdd.Count > 0)
            {
                foreach (Tween tween in _tweensToAdd) {
                    this.tweens.Add(tween);
                }

                _tweensToAdd.Clear();
            }

            // Remove old tweens
            if (_tweensToRemove.Count > 0)
            {
                foreach (Tween tween in _tweensToRemove)
                {
                    this.tweens.Remove(tween);

                    if (tween.recyclable) {
                        _tweensPool.Recycle(tween);
                    }
                }

                _tweensToRemove.Clear();
            }
        }

    }

}
