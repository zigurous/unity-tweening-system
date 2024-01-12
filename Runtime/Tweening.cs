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
        /// The number of tweens currently alive. This includes tweens that have
        /// been recycled and are not currently active (Read only).
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
        /// The number of tweens that are currently alive and active (Read only).
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
        /// <typeparam name="T">The type of object to tween.</typeparam>
        /// <param name="target">The object to tween.</param>
        /// <param name="getter">The function that gets the current value of the parameter.</param>
        /// <param name="setter">The function that sets a new value of the parameter.</param>
        /// <param name="endValue">The end value of the parameter.</param>
        /// <param name="duration">The duration of the tween.</param>
        /// <returns>A new tween that animates the parameter.</returns>
        public static Tween To<T>(T target, TweenGetter<T, float> getter, TweenSetter<T, float> setter, float endValue, float duration) =>
            To(Interpolation._float, target, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        /// <typeparam name="T">The type of object to tween.</typeparam>
        /// <param name="target">The object to tween.</param>
        /// <param name="getter">The function that gets the current value of the parameter.</param>
        /// <param name="setter">The function that sets a new value of the parameter.</param>
        /// <param name="endValue">The end value of the parameter.</param>
        /// <param name="duration">The duration of the tween.</param>
        /// <returns>A new tween that animates the parameter.</returns>
        public static Tween To<T>(T target, TweenGetter<T, double> getter, TweenSetter<T, double> setter, double endValue, float duration) =>
            To(Interpolation._double, target, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        /// <typeparam name="T">The type of object to tween.</typeparam>
        /// <param name="target">The object to tween.</param>
        /// <param name="getter">The function that gets the current value of the parameter.</param>
        /// <param name="setter">The function that sets a new value of the parameter.</param>
        /// <param name="endValue">The end value of the parameter.</param>
        /// <param name="duration">The duration of the tween.</param>
        /// <returns>A new tween that animates the parameter.</returns>
        public static Tween To<T>(T target, TweenGetter<T, int> getter, TweenSetter<T, int> setter, int endValue, float duration) =>
            To(Interpolation._int, target, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        /// <typeparam name="T">The type of object to tween.</typeparam>
        /// <param name="target">The object to tween.</param>
        /// <param name="getter">The function that gets the current value of the parameter.</param>
        /// <param name="setter">The function that sets a new value of the parameter.</param>
        /// <param name="endValue">The end value of the parameter.</param>
        /// <param name="duration">The duration of the tween.</param>
        /// <returns>A new tween that animates the parameter.</returns>
        public static Tween To<T>(T target, TweenGetter<T, long> getter, TweenSetter<T, long> setter, long endValue, float duration) =>
            To(Interpolation._long, target, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        /// <typeparam name="T">The type of object to tween.</typeparam>
        /// <param name="target">The object to tween.</param>
        /// <param name="getter">The function that gets the current value of the parameter.</param>
        /// <param name="setter">The function that sets a new value of the parameter.</param>
        /// <param name="endValue">The end value of the parameter.</param>
        /// <param name="duration">The duration of the tween.</param>
        /// <returns>A new tween that animates the parameter.</returns>
        public static Tween To<T>(T target, TweenGetter<T, short> getter, TweenSetter<T, short> setter, short endValue, float duration) =>
            To(Interpolation._short, target, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        /// <typeparam name="T">The type of object to tween.</typeparam>
        /// <param name="target">The object to tween.</param>
        /// <param name="getter">The function that gets the current value of the parameter.</param>
        /// <param name="setter">The function that sets a new value of the parameter.</param>
        /// <param name="endValue">The end value of the parameter.</param>
        /// <param name="duration">The duration of the tween.</param>
        /// <returns>A new tween that animates the parameter.</returns>
        public static Tween To<T>(T target, TweenGetter<T, Vector2> getter, TweenSetter<T, Vector2> setter, Vector2 endValue, float duration) =>
            To(Interpolation._Vector2, target, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        /// <typeparam name="T">The type of object to tween.</typeparam>
        /// <param name="target">The object to tween.</param>
        /// <param name="getter">The function that gets the current value of the parameter.</param>
        /// <param name="setter">The function that sets a new value of the parameter.</param>
        /// <param name="endValue">The end value of the parameter.</param>
        /// <param name="duration">The duration of the tween.</param>
        /// <returns>A new tween that animates the parameter.</returns>
        public static Tween To<T>(T target, TweenGetter<T, Vector2Int> getter, TweenSetter<T, Vector2Int> setter, Vector2Int endValue, float duration) =>
            To(Interpolation._Vector2Int, target, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        /// <typeparam name="T">The type of object to tween.</typeparam>
        /// <param name="target">The object to tween.</param>
        /// <param name="getter">The function that gets the current value of the parameter.</param>
        /// <param name="setter">The function that sets a new value of the parameter.</param>
        /// <param name="endValue">The end value of the parameter.</param>
        /// <param name="duration">The duration of the tween.</param>
        /// <returns>A new tween that animates the parameter.</returns>
        public static Tween To<T>(T target, TweenGetter<T, Vector3> getter, TweenSetter<T, Vector3> setter, Vector3 endValue, float duration) =>
            To(Interpolation._Vector3, target, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        /// <typeparam name="T">The type of object to tween.</typeparam>
        /// <param name="target">The object to tween.</param>
        /// <param name="getter">The function that gets the current value of the parameter.</param>
        /// <param name="setter">The function that sets a new value of the parameter.</param>
        /// <param name="endValue">The end value of the parameter.</param>
        /// <param name="duration">The duration of the tween.</param>
        /// <returns>A new tween that animates the parameter.</returns>
        public static Tween To<T>(T target, TweenGetter<T, Vector3Int> getter, TweenSetter<T, Vector3Int> setter, Vector3Int endValue, float duration) =>
            To(Interpolation._Vector3Int, target, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        /// <typeparam name="T">The type of object to tween.</typeparam>
        /// <param name="target">The object to tween.</param>
        /// <param name="getter">The function that gets the current value of the parameter.</param>
        /// <param name="setter">The function that sets a new value of the parameter.</param>
        /// <param name="endValue">The end value of the parameter.</param>
        /// <param name="duration">The duration of the tween.</param>
        /// <returns>A new tween that animates the parameter.</returns>
        public static Tween To<T>(T target, TweenGetter<T, Vector4> getter, TweenSetter<T, Vector4> setter, Vector4 endValue, float duration) =>
            To(Interpolation._Vector4, target, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        /// <typeparam name="T">The type of object to tween.</typeparam>
        /// <param name="target">The object to tween.</param>
        /// <param name="getter">The function that gets the current value of the parameter.</param>
        /// <param name="setter">The function that sets a new value of the parameter.</param>
        /// <param name="endValue">The end value of the parameter.</param>
        /// <param name="duration">The duration of the tween.</param>
        /// <returns>A new tween that animates the parameter.</returns>
        public static Tween To<T>(T target, TweenGetter<T, Quaternion> getter, TweenSetter<T, Quaternion> setter, Quaternion endValue, float duration) =>
            To(Interpolation._Quaternion, target, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        /// <typeparam name="T">The type of object to tween.</typeparam>
        /// <param name="target">The object to tween.</param>
        /// <param name="getter">The function that gets the current value of the parameter.</param>
        /// <param name="setter">The function that sets a new value of the parameter.</param>
        /// <param name="endValue">The end value of the parameter.</param>
        /// <param name="duration">The duration of the tween.</param>
        /// <returns>A new tween that animates the parameter.</returns>
        public static Tween To<T>(T target, TweenGetter<T, Rect> getter, TweenSetter<T, Rect> setter, Rect endValue, float duration) =>
            To(Interpolation._Rect, target, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter to a given end value over
        /// a set duration.
        /// </summary>
        /// <typeparam name="T">The type of object to tween.</typeparam>
        /// <param name="target">The object to tween.</param>
        /// <param name="getter">The function that gets the current value of the parameter.</param>
        /// <param name="setter">The function that sets a new value of the parameter.</param>
        /// <param name="endValue">The end value of the parameter.</param>
        /// <param name="duration">The duration of the tween.</param>
        /// <returns>A new tween that animates the parameter.</returns>
        public static Tween To<T>(T target, TweenGetter<T, Color> getter, TweenSetter<T, Color> setter, Color endValue, float duration) =>
            To(Interpolation._Color, target, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter on an object to a given
        /// end value over a set duration.
        /// </summary>
        /// <typeparam name="T">The type of object to tween.</typeparam>
        /// <typeparam name="U">The type of parameter to tween.</typeparam>
        /// <param name="interpolater">The function that interpolates values between the start and end value.</param>
        /// <param name="target">The object to tween.</param>
        /// <param name="getter">The function that gets the current value of the parameter.</param>
        /// <param name="setter">The function that sets a new value of the parameter.</param>
        /// <param name="endValue">The end value of the parameter.</param>
        /// <param name="duration">The duration of the tween.</param>
        /// <returns>A new tween that animates the parameter.</returns>
        public static Tween To<T,U>(Interpolater<U> interpolater, T target, TweenGetter<T,U> getter, TweenSetter<T,U> setter, U endValue, float duration)
        {
            if (TweenManager.IsUnloading) {
                return null;
            }

            Tweener<T,U> tween = TweenManager.Instance.BuildTweener<T,U>();
            tween.target = target;
            tween.getter = getter;
            tween.setter = setter;
            tween.interpolater = interpolater;
            tween.endValue = endValue;
            tween.duration = duration;
            tween.reversed = false;

            return tween;
        }

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        /// <typeparam name="T">The type of object to tween.</typeparam>
        /// <param name="target">The object to tween.</param>
        /// <param name="getter">The function that gets the current value of the parameter.</param>
        /// <param name="setter">The function that sets a new value of the parameter.</param>
        /// <param name="endValue">The end value of the parameter.</param>
        /// <param name="duration">The duration of the tween.</param>
        /// <returns>A new tween that animates the parameter.</returns>
        public static Tween From<T>(T target, TweenGetter<T, float> getter, TweenSetter<T, float> setter, float endValue, float duration) =>
            From(Interpolation.Lerp, target, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        /// <typeparam name="T">The type of object to tween.</typeparam>
        /// <param name="target">The object to tween.</param>
        /// <param name="getter">The function that gets the current value of the parameter.</param>
        /// <param name="setter">The function that sets a new value of the parameter.</param>
        /// <param name="endValue">The end value of the parameter.</param>
        /// <param name="duration">The duration of the tween.</param>
        /// <returns>A new tween that animates the parameter.</returns>
        public static Tween From<T>(T target, TweenGetter<T, double> getter, TweenSetter<T, double> setter, double endValue, float duration) =>
            From(Interpolation.Lerp, target, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        /// <typeparam name="T">The type of object to tween.</typeparam>
        /// <param name="target">The object to tween.</param>
        /// <param name="getter">The function that gets the current value of the parameter.</param>
        /// <param name="setter">The function that sets a new value of the parameter.</param>
        /// <param name="endValue">The end value of the parameter.</param>
        /// <param name="duration">The duration of the tween.</param>
        /// <returns>A new tween that animates the parameter.</returns>
        public static Tween From<T>(T target, TweenGetter<T, int> getter, TweenSetter<T, int> setter, int endValue, float duration) =>
            From(Interpolation.Lerp, target, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        /// <typeparam name="T">The type of object to tween.</typeparam>
        /// <param name="target">The object to tween.</param>
        /// <param name="getter">The function that gets the current value of the parameter.</param>
        /// <param name="setter">The function that sets a new value of the parameter.</param>
        /// <param name="endValue">The end value of the parameter.</param>
        /// <param name="duration">The duration of the tween.</param>
        /// <returns>A new tween that animates the parameter.</returns>
        public static Tween From<T>(T target, TweenGetter<T, long> getter, TweenSetter<T, long> setter, long endValue, float duration) =>
            From(Interpolation.Lerp, target, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        /// <typeparam name="T">The type of object to tween.</typeparam>
        /// <param name="target">The object to tween.</param>
        /// <param name="getter">The function that gets the current value of the parameter.</param>
        /// <param name="setter">The function that sets a new value of the parameter.</param>
        /// <param name="endValue">The end value of the parameter.</param>
        /// <param name="duration">The duration of the tween.</param>
        /// <returns>A new tween that animates the parameter.</returns>
        public static Tween From<T>(T target, TweenGetter<T, short> getter, TweenSetter<T, short> setter, short endValue, float duration) =>
            From(Interpolation.Lerp, target, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        /// <typeparam name="T">The type of object to tween.</typeparam>
        /// <param name="target">The object to tween.</param>
        /// <param name="getter">The function that gets the current value of the parameter.</param>
        /// <param name="setter">The function that sets a new value of the parameter.</param>
        /// <param name="endValue">The end value of the parameter.</param>
        /// <param name="duration">The duration of the tween.</param>
        /// <returns>A new tween that animates the parameter.</returns>
        public static Tween From<T>(T target, TweenGetter<T, Vector2> getter, TweenSetter<T, Vector2> setter, Vector2 endValue, float duration) =>
            From(Interpolation.Lerp, target, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        /// <typeparam name="T">The type of object to tween.</typeparam>
        /// <param name="target">The object to tween.</param>
        /// <param name="getter">The function that gets the current value of the parameter.</param>
        /// <param name="setter">The function that sets a new value of the parameter.</param>
        /// <param name="endValue">The end value of the parameter.</param>
        /// <param name="duration">The duration of the tween.</param>
        /// <returns>A new tween that animates the parameter.</returns>
        public static Tween From<T>(T target, TweenGetter<T, Vector2Int> getter, TweenSetter<T, Vector2Int> setter, Vector2Int endValue, float duration) =>
            From(Interpolation.Lerp, target, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        /// <typeparam name="T">The type of object to tween.</typeparam>
        /// <param name="target">The object to tween.</param>
        /// <param name="getter">The function that gets the current value of the parameter.</param>
        /// <param name="setter">The function that sets a new value of the parameter.</param>
        /// <param name="endValue">The end value of the parameter.</param>
        /// <param name="duration">The duration of the tween.</param>
        /// <returns>A new tween that animates the parameter.</returns>
        public static Tween From<T>(T target, TweenGetter<T, Vector3> getter, TweenSetter<T, Vector3> setter, Vector3 endValue, float duration) =>
            From(Interpolation.Lerp, target, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        /// <typeparam name="T">The type of object to tween.</typeparam>
        /// <param name="target">The object to tween.</param>
        /// <param name="getter">The function that gets the current value of the parameter.</param>
        /// <param name="setter">The function that sets a new value of the parameter.</param>
        /// <param name="endValue">The end value of the parameter.</param>
        /// <param name="duration">The duration of the tween.</param>
        /// <returns>A new tween that animates the parameter.</returns>
        public static Tween From<T>(T target, TweenGetter<T, Vector3Int> getter, TweenSetter<T, Vector3Int> setter, Vector3Int endValue, float duration) =>
            From(Interpolation.Lerp, target, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        /// <typeparam name="T">The type of object to tween.</typeparam>
        /// <param name="target">The object to tween.</param>
        /// <param name="getter">The function that gets the current value of the parameter.</param>
        /// <param name="setter">The function that sets a new value of the parameter.</param>
        /// <param name="endValue">The end value of the parameter.</param>
        /// <param name="duration">The duration of the tween.</param>
        /// <returns>A new tween that animates the parameter.</returns>
        public static Tween From<T>(T target, TweenGetter<T, Vector4> getter, TweenSetter<T, Vector4> setter, Vector4 endValue, float duration) =>
            From(Interpolation.Lerp, target, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        /// <typeparam name="T">The type of object to tween.</typeparam>
        /// <param name="target">The object to tween.</param>
        /// <param name="getter">The function that gets the current value of the parameter.</param>
        /// <param name="setter">The function that sets a new value of the parameter.</param>
        /// <param name="endValue">The end value of the parameter.</param>
        /// <param name="duration">The duration of the tween.</param>
        /// <returns>A new tween that animates the parameter.</returns>
        public static Tween From<T>(T target, TweenGetter<T, Quaternion> getter, TweenSetter<T, Quaternion> setter, Quaternion endValue, float duration) =>
            From(Interpolation.Lerp, target, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        /// <typeparam name="T">The type of object to tween.</typeparam>
        /// <param name="target">The object to tween.</param>
        /// <param name="getter">The function that gets the current value of the parameter.</param>
        /// <param name="setter">The function that sets a new value of the parameter.</param>
        /// <param name="endValue">The end value of the parameter.</param>
        /// <param name="duration">The duration of the tween.</param>
        /// <returns>A new tween that animates the parameter.</returns>
        public static Tween From<T>(T target, TweenGetter<T, Rect> getter, TweenSetter<T, Rect> setter, Rect endValue, float duration) =>
            From(Interpolation.Lerp, target, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter from a given end value to
        /// the current value over a set duration.
        /// </summary>
        /// <typeparam name="T">The type of object to tween.</typeparam>
        /// <param name="target">The object to tween.</param>
        /// <param name="getter">The function that gets the current value of the parameter.</param>
        /// <param name="setter">The function that sets a new value of the parameter.</param>
        /// <param name="endValue">The end value of the parameter.</param>
        /// <param name="duration">The duration of the tween.</param>
        /// <returns>A new tween that animates the parameter.</returns>
        public static Tween From<T>(T target, TweenGetter<T, Color> getter, TweenSetter<T, Color> setter, Color endValue, float duration) =>
            From(Interpolation.Lerp, target, getter, setter, endValue, duration);

        /// <summary>
        /// Creates a tween that animates a parameter on an object from a given
        /// end value to the current value over a set duration.
        /// </summary>
        /// <typeparam name="T">The type of object to tween.</typeparam>
        /// <typeparam name="U">The type of parameter to tween.</typeparam>
        /// <param name="target">The object to tween.</param>
        /// <param name="interpolater">The function that interpolates values between the start and end value.</param>
        /// <param name="getter">The function that gets the current value of the parameter.</param>
        /// <param name="setter">The function that sets a new value of the parameter.</param>
        /// <param name="endValue">The end value of the parameter.</param>
        /// <param name="duration">The duration of the tween.</param>
        /// <returns>A new tween that animates the parameter.</returns>
        public static Tween From<T,U>(Interpolater<U> interpolater, T target, TweenGetter<T,U> getter, TweenSetter<T,U> setter, U endValue, float duration)
        {
            if (TweenManager.IsUnloading) {
                return null;
            }

            Tweener<T,U> tween = TweenManager.Instance.BuildTweener<T,U>();
            tween.target = target;
            tween.getter = getter;
            tween.setter = setter;
            tween.interpolater = interpolater;
            tween.endValue = endValue;
            tween.duration = duration;
            tween.reversed = true;

            return tween;
        }

        /// <summary>
        /// Creates a new, empty tween sequence.
        /// </summary>
        /// <returns>The new tween sequence.</returns>
        public static Sequence Sequence()
        {
            if (!TweenManager.IsUnloading) {
                return TweenManager.Instance.BuildSequence();
            } else {
                return null;
            }
        }

        /// <summary>
        /// Creates a new tween sequence of the given tweens.
        /// </summary>
        /// <param name="tweens">The tweens to add to the sequence.</param>
        /// <returns>The new tween sequence.</returns>
        public static Sequence Sequence(params Tween[] tweens)
        {
            if (TweenManager.IsUnloading) {
                return null;
            }

            Sequence sequence = TweenManager.Instance.BuildSequence();

            if (tweens != null && tweens.Length > 0) {
                sequence.Tweens.AddRange(tweens);
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
        /// <param name="id">The id of the tween(s) to play.</param>
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
        /// <typeparam name="T">The type of the target object.</typeparam>
        /// <param name="target">The target object to play the tweens of.</param>
        public static void Play<T>(T target) where T : class
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
        /// <param name="id">The id of the tween(s) to stop.</param>
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
        /// <typeparam name="T">The type of the target object.</typeparam>
        /// <param name="target">The target object to stop the tweens of.</param>
        public static void Stop<T>(T target) where T : class
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
        /// <param name="id">The id of the tween(s) to restart.</param>
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
        /// <typeparam name="T">The type of the target object.</typeparam>
        /// <param name="target">The target object to restart the tweens of.</param>
        public static void Restart<T>(T target) where T : class
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
        /// <param name="id">The id of the tween(s) to complete.</param>
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
        /// <typeparam name="T">The type of the target object.</typeparam>
        /// <param name="target">The target object to complete the tweens of.</param>
        public static void Complete<T>(T target) where T : class
        {
            Complete(target.GetHashCode());
        }

        /// <summary>
        /// Kills all active tweens. Optionally, the tweens can be completed
        /// before being killed.
        /// </summary>
        /// <param name="complete">Whether to complete the tweens before being killed.</param>
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
        /// <param name="id">The id of the tween(s) to kill.</param>
        /// <param name="complete">Whether to complete the tweens before being killed.</param>
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
        /// <typeparam name="T">The type of the target object.</typeparam>
        /// <param name="target">The target object to kill the tweens of.</param>
        /// <param name="complete">Whether to complete the tweens before being killed.</param>
        public static void KillTweens<T>(this T target, bool complete = false) where T : class
        {
            Kill(target.GetHashCode(), complete);
        }

        /// <summary>
        /// Kills the given tween, preventing it from being further updated.
        /// Optionally, the tween can be completed before being killed.
        /// </summary>
        /// <param name="tween">The tween to kill.</param>
        /// <param name="complete">Whether to complete the tween before being killed.</param>
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
