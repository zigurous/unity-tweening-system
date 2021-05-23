using System.Collections.Generic;
using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    /// <summary>
    /// The primary interface to create, control, and manage tweens.
    /// </summary>
    public static class Tweener
    {
        /// <summary>
        /// The number of tweens currently alive (not necessarily active).
        /// </summary>
        public static int Count => TweenManager.Instance.tweens.Count;

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        public static Tween To(ITweenable parameter, float duration)
        {
            Tween tween = TweenManager.Instance.Build();
            tween.parameter = parameter;
            tween.duration = duration;
            tween.reversed = false;
            return tween;
        }

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        public static Tween To(System.Func<float> getter, System.Action<float> setter, float endValue, float duration) =>
            Tweener.To(new FloatAdapter().Build(getter, setter, endValue), duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        public static Tween To(System.Func<double> getter, System.Action<double> setter, double endValue, float duration) =>
            Tweener.To(new DoubleAdapter().Build(getter, setter, endValue), duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        public static Tween To(System.Func<long> getter, System.Action<long> setter, long endValue, float duration) =>
            Tweener.To(new LongAdapter().Build(getter, setter, endValue), duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        public static Tween To(System.Func<int> getter, System.Action<int> setter, int endValue, float duration) =>
            Tweener.To(new IntAdapter().Build(getter, setter, endValue), duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        public static Tween To(System.Func<Vector2> getter, System.Action<Vector2> setter, Vector2 endValue, float duration) =>
            Tweener.To(new Vector2Adapter().Build(getter, setter, endValue), duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        public static Tween To(System.Func<Vector2Int> getter, System.Action<Vector2Int> setter, Vector2Int endValue, float duration) =>
            Tweener.To(new Vector2IntAdapter().Build(getter, setter, endValue), duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        public static Tween To(System.Func<Vector3> getter, System.Action<Vector3> setter, Vector3 endValue, float duration) =>
            Tweener.To(new Vector3Adapter().Build(getter, setter, endValue), duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        public static Tween To(System.Func<Vector3Int> getter, System.Action<Vector3Int> setter, Vector3Int endValue, float duration) =>
            Tweener.To(new Vector3IntAdapter().Build(getter, setter, endValue), duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        public static Tween To(System.Func<Vector4> getter, System.Action<Vector4> setter, Vector4 endValue, float duration) =>
            Tweener.To(new Vector4Adapter().Build(getter, setter, endValue), duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        public static Tween To(System.Func<Quaternion> getter, System.Action<Quaternion> setter, Quaternion endValue, float duration) =>
            Tweener.To(new QuaternionAdapter().Build(getter, setter, endValue), duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        public static Tween To(System.Func<Color> getter, System.Action<Color> setter, Color endValue, float duration) =>
            Tweener.To(new ColorAdapter().Build(getter, setter, endValue), duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        public static Tween From(ITweenable parameter, float duration)
        {
            Tween tween = TweenManager.Instance.Build();
            tween.parameter = parameter;
            tween.duration = duration;
            tween.reversed = true;
            return tween;
        }

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        public static Tween From(System.Func<float> getter, System.Action<float> setter, float endValue, float duration) =>
            Tweener.From(new FloatAdapter().Build(getter, setter, endValue), duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        public static Tween From(System.Func<double> getter, System.Action<double> setter, double endValue, float duration) =>
            Tweener.From(new DoubleAdapter().Build(getter, setter, endValue), duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        public static Tween From(System.Func<long> getter, System.Action<long> setter, long endValue, float duration) =>
            Tweener.From(new LongAdapter().Build(getter, setter, endValue), duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        public static Tween From(System.Func<int> getter, System.Action<int> setter, int endValue, float duration) =>
            Tweener.From(new IntAdapter().Build(getter, setter, endValue), duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        public static Tween From(System.Func<Vector2> getter, System.Action<Vector2> setter, Vector2 endValue, float duration) =>
            Tweener.From(new Vector2Adapter().Build(getter, setter, endValue), duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        public static Tween From(System.Func<Vector2Int> getter, System.Action<Vector2Int> setter, Vector2Int endValue, float duration) =>
            Tweener.From(new Vector2IntAdapter().Build(getter, setter, endValue), duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        public static Tween From(System.Func<Vector3> getter, System.Action<Vector3> setter, Vector3 endValue, float duration) =>
            Tweener.From(new Vector3Adapter().Build(getter, setter, endValue), duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        public static Tween From(System.Func<Vector3Int> getter, System.Action<Vector3Int> setter, Vector3Int endValue, float duration) =>
            Tweener.From(new Vector3IntAdapter().Build(getter, setter, endValue), duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        public static Tween From(System.Func<Vector4> getter, System.Action<Vector4> setter, Vector4 endValue, float duration) =>
            Tweener.From(new Vector4Adapter().Build(getter, setter, endValue), duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        public static Tween From(System.Func<Quaternion> getter, System.Action<Quaternion> setter, Quaternion endValue, float duration) =>
            Tweener.From(new QuaternionAdapter().Build(getter, setter, endValue), duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        public static Tween From(System.Func<Color> getter, System.Action<Color> setter, Color endValue, float duration) =>
            Tweener.From(new ColorAdapter().Build(getter, setter, endValue), duration);

        /// <summary>
        /// Creates a new, empty tween sequence.
        /// </summary>
        public static TweenSequence Sequence()
        {
            return TweenManager.Instance.BuildSequence();
        }

        /// <summary>
        /// Creates a new tween sequence of the given tweens.
        /// </summary>
        public static TweenSequence Sequence(params Tween[] tweens)
        {
            return TweenManager.Instance.BuildSequence(tweens);
        }

        /// <summary>
        /// Plays all active tweens.
        /// </summary>
        public static void PlayAll()
        {
            if (!TweenManager.HasInstance) {
                return;
            }

            List<TweenBase> tweens = TweenManager.Instance.tweens;

            foreach (TweenBase tween in tweens) {
                tween.Play();
            }
        }

        /// <summary>
        /// Plays any alive tween that matches the given id.
        /// </summary>
        public static void Play(int id)
        {
            if (!TweenManager.HasInstance) {
                return;
            }

            List<TweenBase> tweens = TweenManager.Instance.tweens;

            foreach (TweenBase tween in tweens)
            {
                if (tween.id == id) {
                    tween.Play();
                }
            }
        }

        /// <summary>
        /// Plays any alive tween that is animating the given target object.
        /// </summary>
        public static void Play<T>(T target) where T: class
        {
            Play(target.GetHashCode());
        }

        /// <summary>
        /// Stops all active tweens.
        /// </summary>
        public static void StopAll()
        {
            if (!TweenManager.HasInstance) {
                return;
            }

            List<TweenBase> tweens = TweenManager.Instance.tweens;

            foreach (TweenBase tween in tweens) {
                tween.Stop();
            }
        }

        /// <summary>
        /// Stops any alive tween that matches the given id.
        /// </summary>
        public static void Stop(int id)
        {
            if (!TweenManager.HasInstance) {
                return;
            }

            List<TweenBase> tweens = TweenManager.Instance.tweens;

            foreach (TweenBase tween in tweens)
            {
                if (tween.id == id) {
                    tween.Stop();
                }
            }
        }

        /// <summary>
        /// Stops any alive tween that is animating the given target object.
        /// </summary>
        public static void Stop<T>(T target) where T: class
        {
            Stop(target.GetHashCode());
        }

        /// <summary>
        /// Restarts all active tweens.
        /// </summary>
        public static void RestartAll()
        {
            if (!TweenManager.HasInstance) {
                return;
            }

            List<TweenBase> tweens = TweenManager.Instance.tweens;

            foreach (TweenBase tween in tweens) {
                tween.Restart();
            }
        }

        /// <summary>
        /// Restarts any alive tween that matches the given id.
        /// </summary>
        public static void Restart(int id)
        {
            if (!TweenManager.HasInstance) {
                return;
            }

            List<TweenBase> tweens = TweenManager.Instance.tweens;

            foreach (TweenBase tween in tweens)
            {
                if (tween.id == id) {
                    tween.Restart();
                }
            }
        }

        /// <summary>
        /// Restarts any alive tween that is animating the given target object.
        /// </summary>
        public static void Restart<T>(T target) where T: class
        {
            Restart(target.GetHashCode());
        }

        /// <summary>
        /// Completes all active tweens.
        /// </summary>
        public static void CompleteAll()
        {
            if (!TweenManager.HasInstance) {
                return;
            }

            List<TweenBase> tweens = TweenManager.Instance.tweens;

            foreach (TweenBase tween in tweens) {
                tween.Complete();
            }
        }

        /// <summary>
        /// Completes any alive tween that matches the given id.
        /// </summary>
        public static void Complete(int id)
        {
            if (!TweenManager.HasInstance) {
                return;
            }

            List<TweenBase> tweens = TweenManager.Instance.tweens;

            foreach (TweenBase tween in tweens)
            {
                if (tween.id == id) {
                    tween.Complete();
                }
            }
        }

        /// <summary>
        /// Completes any alive tween that is animating the given target object.
        /// </summary>
        public static void Complete<T>(T target) where T: class
        {
            Complete(target.GetHashCode());
        }

        /// <summary>
        /// Kills all active tweens. Optionally, the tweens can be completed
        /// before being killed.
        /// </summary>
        public static void KillAll(bool complete = false)
        {
            if (!TweenManager.HasInstance) {
                return;
            }

            List<TweenBase> tweens = TweenManager.Instance.tweens;

            foreach (TweenBase tween in tweens) {
                Kill(tween, complete);
            }
        }

        /// <summary>
        /// Kills any alive tween that matches the given id. Optionally, the
        /// tweens can be completed before being killed.
        /// </summary>
        public static void Kill(int id, bool complete = false)
        {
            if (!TweenManager.HasInstance) {
                return;
            }

            List<TweenBase> tweens = TweenManager.Instance.tweens;

            foreach (TweenBase tween in tweens)
            {
                if (tween.id == id) {
                    Kill(tween, complete);
                }
            }
        }

        /// <summary>
        /// Kills any alive tween that is animating the given target object.
        /// Optionally, the tweens can be completed before being killed.
        /// </summary>
        public static void Kill<T>(T target, bool complete = false) where T: class
        {
            Kill(target.GetHashCode(), complete);
        }

        /// <summary>
        /// Kills the given tween after optionally completing it.
        /// </summary>
        private static void Kill(TweenBase tween, bool complete)
        {
            if (complete) {
                tween.Complete();
            }

            // Only kill the tween if it is not automatically killed when
            // completed otherwise it would be killed twice
            if (!tween.autoKill || !complete) {
                tween.Kill();
            }
        }

    }

}
