using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Zigurous.Tweening
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
        internal List<Tween> tweens = new List<Tween>(Tweening.initialCapacity);

        private static bool _isUnloading = false;
        private static object _lock = new object();

        public static bool HasInstance => _instance != null;

        private static volatile TweenManager _instance;
        internal static TweenManager Instance
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
                            singleton.AddComponent<TweenManager>();
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

            if (_instance == null)
            {
                _instance = this;

                SceneManager.sceneUnloaded += SceneUnloaded;
            }
            else
            {
                Destroy(this);
            }
        }

        private void OnDestroy()
        {
            _isUnloading = true;

            if (_instance == this)
            {
                _instance = null;

                SceneManager.sceneUnloaded -= SceneUnloaded;
            }

            foreach (Tween tween in this.tweens) {
                tween.Kill();
            }

            this.tweens.Clear();
        }

        private void Update()
        {
            float deltaTime = Time.deltaTime;

            for (int i = this.tweens.Count - 1; i >= 0; i--)
            {
                Tween tween = this.tweens[i];

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
        internal Tweener<T> BuildTweener<T>()
        {
            Tweener<T> tweener = null;

            foreach (Tween tween in this.tweens)
            {
                if (tween.internalState == InternalTweenState.Recycled &&
                    tween.type == TweenType.Tweener &&
                    tween.template == typeof(T))
                {
                    tweener = (Tweener<T>)tween;
                    break;
                }
            }

            if (tweener == null) {
                tweener = new Tweener<T>();
            } else {
                tweener.Reset();
            }

            tweener.state = TweenState.Ready;
            tweener.internalState = InternalTweenState.Queued;

            return tweener;
        }

        /// <summary>
        /// Recycles or creates a new tween sequence.
        /// </summary>
        internal Sequence BuildSequence()
        {
            Sequence sequence = null;

            foreach (Tween tween in this.tweens)
            {
                if (tween.internalState == InternalTweenState.Recycled &&
                    tween.type == TweenType.Sequence)
                {
                    sequence = (Sequence)tween;
                    break;
                }
            }

            if (sequence == null) {
                sequence = new Sequence();
            } else {
                sequence.Reset();
            }

            sequence.state = TweenState.Ready;
            sequence.internalState = InternalTweenState.Queued;

            return sequence;
        }

        /// <summary>
        /// Adds a tween to the list of alive tweens so it can be managed and
        /// updated.
        /// </summary>
        internal void Track(Tween tween)
        {
            if (!this.tweens.Contains(tween)) {
                this.tweens.Add(tween);
            }
        }

        /// <summary>
        /// Kills all tweens that are animating objects on the unloaded scene.
        /// </summary>
        private void SceneUnloaded(Scene scene)
        {
            foreach (Tween tween in this.tweens)
            {
                if (tween.sceneIndex == -1 || tween.sceneIndex == scene.buildIndex) {
                    tween.Kill();
                }
            }
        }

    }

}
