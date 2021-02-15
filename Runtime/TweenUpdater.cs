using System.Collections.Generic;
using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    internal sealed class TweenUpdater : MonoBehaviour
    {
        private static object _lock = new object();
        private static bool _isUnloading = false;
        private static volatile TweenUpdater _instance;
        public static TweenUpdater Instance
        {
            get
            {
                if (_isUnloading) {
                    return null;
                }

                if (_instance == null)
                {
                    lock (_lock)
                    {
                        _instance = FindObjectOfType<TweenUpdater>();

                        if (_instance == null)
                        {
                            GameObject singleton = new GameObject();
                            singleton.name = typeof(TweenUpdater).Name;
                            singleton.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector;

                            _instance = singleton.AddComponent<TweenUpdater>();
                            DontDestroyOnLoad(singleton);
                        }
                    }
                }

                return _instance;
            }
        }

        public List<Tween> tweens { get; private set; } = new List<Tween>(64);
        private List<Tween> _adding = new List<Tween>(16);
        private List<Tween> _removing = new List<Tween>(16);
        private Queue<Tween> _pool = new Queue<Tween>(Settings.initialCapacity);

        private void Awake()
        {
            _isUnloading = false;

            if (_instance == null) {
                _instance = this;
            } else {
                Destroy(this);
            }
        }

        private void OnDestroy()
        {
            _isUnloading = true;

            if (_instance == this) {
                _instance = null;
            }

            Tweener.KillAll();

            this.tweens.Clear();
            this.tweens = null;

            _adding.Clear();
            _adding = null;

            _removing.Clear();
            _removing = null;

            _pool.Clear();
            _pool = null;
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
            if (_adding.Count > 0)
            {
                foreach (Tween tween in _adding) {
                    this.tweens.Add(tween);
                }

                _adding.Clear();
            }

            // Remove old tweens
            if (_removing.Count > 0)
            {
                foreach (Tween tween in _removing)
                {
                    this.tweens.Remove(tween);

                    if (tween.recyclable) {
                        _pool.Enqueue(tween);
                    }
                }

                _removing.Clear();
            }
        }

        public void Track(Tween tween)
        {
            _adding.Add(tween);
            _removing.Remove(tween);
        }

        public void Untrack(Tween tween)
        {
            _removing.Add(tween);
            _adding.Remove(tween);
        }

        internal Tween AcquireTween(Tween.Getter getter, Tween.Setter setter, float endValue, float duration)
        {
            Tween tween = _pool.Count > 0 ? _pool.Dequeue() : null;

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

    }

}
