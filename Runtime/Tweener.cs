using System.Collections.Generic;

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
        /// Creates a tween that animates from the target object's current value
        /// to the given end value over a set duration.
        /// </summary>
        public static Tween To(Tween.Getter getter, Tween.Setter setter, float endValue, float duration)
        {
            return TweenManager.Instance.Build(getter, setter, endValue, duration);
        }

        /// <summary>
        /// Creates a tween that animates from the given end value to the target
        /// object's current value over a set duration.
        /// </summary>
        public static Tween From(Tween.Getter getter, Tween.Setter setter, float endValue, float duration)
        {
            return TweenManager.Instance.Build(getter, setter, endValue, duration)
                                        .SetReversed(true);
        }

        /// <summary>
        /// Creates a new, empty tween sequence.
        /// </summary>
        public static TweenSequence Sequence()
        {
            return TweenManager.Instance.Build();
        }

        /// <summary>
        /// Creates a new tween sequence of the given tweens.
        /// </summary>
        public static TweenSequence Sequence(params Tween[] tweens)
        {
            return TweenManager.Instance.Build(tweens);
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
