using System.Collections.Generic;
using UnityEngine;

namespace Zigurous.Tweening
{
    /// <summary>
    /// The primary interface to create, control, and manage tweens.
    /// </summary>
    public static class Tweening
    {
        /// <summary>
        /// The default Ease assigned to every tween.
        /// </summary>
        public static Ease defaultEase = Ease.QuadOut;

        /// <summary>
        /// Automatically starts tweens after being created, by default.
        /// </summary>
        public static bool defaultAutoStart = true;

        /// <summary>
        /// Automatically kills tweens after being completed, by default.
        /// </summary>
        public static bool defaultAutoKill = true;

        /// <summary>
        /// Keeps tweens in memory to be re-used after being killed, by default.
        /// </summary>
        public static bool defaultRecyclable = true;

        /// <summary>
        /// The default amount of seconds a tween takes to complete.
        /// </summary>
        public static float defaultDuration = 0.3f;

        /// <summary>
        /// The default amount of seconds before every tween starts.
        /// </summary>
        public static float defaultDelay = 0.0f;

        /// <summary>
        /// The default overshoot value used in easing functions.
        /// </summary>
        public static float overshoot = 1.70158f;

        /// <summary>
        /// Kills all tweens when the active scene is unloaded.
        /// </summary>
        public static bool killTweensOnSceneUnload = true;

        /// <summary>
        /// The initial amount of tweens that memory is allocated for when the
        /// system starts. Additional memory will be allocated as needed.
        /// </summary>
        public static int initialCapacity = 16;

        /// <summary>
        /// The number of tweens currently alive (not necessarily active).
        /// </summary>
        public static int Count
        {
            get
            {
                if (TweenManager.HasInstance) {
                    return TweenManager.Instance.tweens.Count;
                } else {
                    return 0;
                }
            }
        }

        /// <summary>
        /// The number of tweens that are currently alive and active.
        /// </summary>
        public static int ActiveCount
        {
            get
            {
                if (!TweenManager.HasInstance) {
                    return 0;
                }

                int count = 0;
                List<Tween> tweens = TweenManager.Instance.tweens;

                foreach (Tween tween in tweens)
                {
                    if (tween.internalState == InternalTweenState.Active) {
                        count++;
                    }
                }

                return count;
            }
        }

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        public static Tween To(TweenGetter<float> getter, TweenSetter<float> setter, float endValue, float duration) =>
            To(Interpolation.Lerp, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        public static Tween To(TweenGetter<double> getter, TweenSetter<double> setter, double endValue, float duration) =>
            To(Interpolation.Lerp, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        public static Tween To(TweenGetter<long> getter, TweenSetter<long> setter, long endValue, float duration) =>
            To(Interpolation.Lerp, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        public static Tween To(TweenGetter<int> getter, TweenSetter<int> setter, int endValue, float duration) =>
            To(Interpolation.Lerp, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        public static Tween To(TweenGetter<Vector2> getter, TweenSetter<Vector2> setter, Vector2 endValue, float duration) =>
            To(Interpolation.Lerp, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        public static Tween To(TweenGetter<Vector2Int> getter, TweenSetter<Vector2Int> setter, Vector2Int endValue, float duration) =>
            To(Interpolation.Lerp, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        public static Tween To(TweenGetter<Vector3> getter, TweenSetter<Vector3> setter, Vector3 endValue, float duration) =>
            To(Interpolation.Lerp, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        public static Tween To(TweenGetter<Vector3Int> getter, TweenSetter<Vector3Int> setter, Vector3Int endValue, float duration) =>
            To(Interpolation.Lerp, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        public static Tween To(TweenGetter<Vector4> getter, TweenSetter<Vector4> setter, Vector4 endValue, float duration) =>
            To(Interpolation.Lerp, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        public static Tween To(TweenGetter<Quaternion> getter, TweenSetter<Quaternion> setter, Quaternion endValue, float duration) =>
            To(Interpolation.Lerp, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        public static Tween To(TweenGetter<Color> getter, TweenSetter<Color> setter, Color endValue, float duration) =>
            To(Interpolation.Lerp, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        public static Tween To<T>(Interpolater<T> interpolater, TweenGetter<T> getter, TweenSetter<T> setter, T endValue, float duration)
        {
            Tweener<T> tween = TweenManager.Instance.BuildTweener<T>();
            tween.interpolater = interpolater;
            tween.getter = getter;
            tween.setter = setter;
            tween.endValue = endValue;
            tween.duration = duration;
            tween.reversed = false;
            return tween;
        }

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        public static Tween From(TweenGetter<float> getter, TweenSetter<float> setter, float endValue, float duration) =>
            From(Interpolation.Lerp, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        public static Tween From(TweenGetter<double> getter, TweenSetter<double> setter, double endValue, float duration) =>
            From(Interpolation.Lerp, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        public static Tween From(TweenGetter<long> getter, TweenSetter<long> setter, long endValue, float duration) =>
            From(Interpolation.Lerp, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        public static Tween From(TweenGetter<int> getter, TweenSetter<int> setter, int endValue, float duration) =>
            From(Interpolation.Lerp, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        public static Tween From(TweenGetter<Vector2> getter, TweenSetter<Vector2> setter, Vector2 endValue, float duration) =>
            From(Interpolation.Lerp, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        public static Tween From(TweenGetter<Vector2Int> getter, TweenSetter<Vector2Int> setter, Vector2Int endValue, float duration) =>
            From(Interpolation.Lerp, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        public static Tween From(TweenGetter<Vector3> getter, TweenSetter<Vector3> setter, Vector3 endValue, float duration) =>
            From(Interpolation.Lerp, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        public static Tween From(TweenGetter<Vector3Int> getter, TweenSetter<Vector3Int> setter, Vector3Int endValue, float duration) =>
            From(Interpolation.Lerp, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        public static Tween From(TweenGetter<Vector4> getter, TweenSetter<Vector4> setter, Vector4 endValue, float duration) =>
            From(Interpolation.Lerp, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        public static Tween From(TweenGetter<Quaternion> getter, TweenSetter<Quaternion> setter, Quaternion endValue, float duration) =>
            From(Interpolation.Lerp, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        public static Tween From(TweenGetter<Color> getter, TweenSetter<Color> setter, Color endValue, float duration) =>
            From(Interpolation.Lerp, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        public static Tween From<T>(Interpolater<T> interpolater, TweenGetter<T> getter, TweenSetter<T> setter, T endValue, float duration)
        {
            Tweener<T> tween = TweenManager.Instance.BuildTweener<T>();
            tween.interpolater = interpolater;
            tween.getter = getter;
            tween.setter = setter;
            tween.endValue = endValue;
            tween.duration = duration;
            tween.reversed = true;
            return tween;
        }

        /// <summary>
        /// Creates a new, empty tween sequence.
        /// </summary>
        public static Sequence Sequence()
        {
            return TweenManager.Instance.BuildSequence();
        }

        /// <summary>
        /// Creates a new tween sequence of the given tweens.
        /// </summary>
        public static Sequence Sequence(params Tween[] tweens)
        {
            Sequence sequence = TweenManager.Instance.BuildSequence();

            if (tweens != null && tweens.Length > 0) {
                sequence.tweens.AddRange(tweens);
            }

            return sequence;
        }

        /// <summary>
        /// Plays all active tweens.
        /// </summary>
        public static void PlayAll()
        {
            if (!TweenManager.HasInstance) {
                return;
            }

            List<Tween> tweens = TweenManager.Instance.tweens;

            foreach (Tween tween in tweens) {
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

            List<Tween> tweens = TweenManager.Instance.tweens;

            foreach (Tween tween in tweens)
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

            List<Tween> tweens = TweenManager.Instance.tweens;

            foreach (Tween tween in tweens) {
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

            List<Tween> tweens = TweenManager.Instance.tweens;

            foreach (Tween tween in tweens)
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

            List<Tween> tweens = TweenManager.Instance.tweens;

            foreach (Tween tween in tweens) {
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

            List<Tween> tweens = TweenManager.Instance.tweens;

            foreach (Tween tween in tweens)
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

            List<Tween> tweens = TweenManager.Instance.tweens;

            foreach (Tween tween in tweens) {
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

            List<Tween> tweens = TweenManager.Instance.tweens;

            foreach (Tween tween in tweens)
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

            List<Tween> tweens = TweenManager.Instance.tweens;

            foreach (Tween tween in tweens) {
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

            List<Tween> tweens = TweenManager.Instance.tweens;

            foreach (Tween tween in tweens)
            {
                if (tween.id == id) {
                    Kill(tween, complete);
                }
            }
        }

        /// <summary>
        /// Kills any alive tweens being animated on the target object.
        /// Optionally, the tweens can be completed before being killed.
        /// </summary>
        public static void KillTweens<T>(this T target, bool complete = false) where T: class
        {
            Kill(target.GetHashCode(), complete);
        }

        /// <summary>
        /// Kills the given tween, preventing it from being further updated.
        /// Optionally, the tween can be completed before being killed.
        /// </summary>
        private static void Kill(Tween tween, bool complete)
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
