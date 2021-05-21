using System.Collections.Generic;
using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    /// <summary>
    /// Manages the lifecycle of all tween objects, including updating,
    /// creating, destroying, and recycling tweens.
    /// </summary>
    internal sealed class TweenManager : MonoBehaviour
    {
        /// <summary>
        /// A list of all alive tween objects.
        /// </summary>
        internal List<TweenBase> tweens = new List<TweenBase>(Settings.initialCapacity);

        private static bool _isUnloading = false;
        private static object _lock = new object();

        public static bool HasInstance => _instance != null;

        private static volatile TweenManager _instance;
        public static TweenManager Instance
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
                        _instance = FindObjectOfType<TweenManager>();

                        if (_instance == null)
                        {
                            GameObject singleton = new GameObject();
                            singleton.name = typeof(TweenManager).Name;
                            singleton.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector;

                            _instance = singleton.AddComponent<TweenManager>();
                            DontDestroyOnLoad(singleton);
                        }
                    }
                }

                return _instance;
            }
        }

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

            Tweener.KillAll(false);

            this.tweens.Clear();
        }

        private void Update()
        {
            float deltaTime = Time.deltaTime;

            for (int i = this.tweens.Count - 1; i >= 0; i--)
            {
                TweenBase tween = this.tweens[i];

                switch (tween.internalState)
                {
                    case InternalTweenState.Active:
                        tween.Update(deltaTime);
                        break;

                    case InternalTweenState.Queued:
                        tween.internalState = InternalTweenState.Active;
                        break;

                    case InternalTweenState.Dequeued:
                        if (tween.recyclable) {
                            tween.internalState = InternalTweenState.Recycled;
                        } else {
                            tween.internalState = InternalTweenState.Killed;
                            this.tweens.RemoveAt(i);
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// Recycles or creates a new tween object.
        /// </summary>
        internal Tween Build()
        {
            Tween tween = null;

            foreach (TweenBase trackedTween in this.tweens)
            {
                if (trackedTween.internalState == InternalTweenState.Recycled &&
                    trackedTween is Tween)
                {
                    tween = (Tween)trackedTween;
                    break;
                }
            }

            if (tween == null) {
                tween = new Tween();
            } else {
                tween.Reset();
            }

            tween.state = TweenState.Ready;
            tween.internalState = InternalTweenState.Queued;
            tween.getter = null;
            tween.setter = null;
            tween.startValue = 0.0f;
            tween.endValue = 0.0f;

            return tween;
        }

        /// <summary>
        /// Recycles or creates a new tween sequence.
        /// </summary>
        internal TweenSequence BuildSequence(Tween[] tweens = null)
        {
            TweenSequence sequence = null;

            foreach (TweenBase trackedTween in this.tweens)
            {
                if (trackedTween.internalState == InternalTweenState.Recycled &&
                    trackedTween is TweenSequence)
                {
                    sequence = (TweenSequence)trackedTween;
                    break;
                }
            }

            if (sequence == null) {
                sequence = new TweenSequence();
            } else {
                sequence.Reset();
            }

            sequence.state = TweenState.Ready;
            sequence.internalState = InternalTweenState.Queued;
            sequence.tweens.Clear();

            if (tweens != null) {
                sequence.tweens.AddRange(tweens);
            }

            return sequence;
        }

        /// <summary>
        /// Adds a tween to the list of alive tweens so it can be managed and
        /// updated.
        /// </summary>
        internal void Track(TweenBase tween)
        {
            if (!this.tweens.Contains(tween)) {
                this.tweens.Add(tween);
            }
        }

    }

}
