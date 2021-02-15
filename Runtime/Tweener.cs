using System.Collections.Generic;

namespace Zigurous.Animation.Tweening
{
    public static class Tweener
    {
        private static List<Tween> _tweens => TweenUpdater.Instance.tweens;
        public static int Count => _tweens.Count;

        public static Tween To(Tween.Getter getter, Tween.Setter setter, float endValue, float duration) =>
            TweenUpdater.Instance.AcquireTween(getter, setter, endValue, duration);

        public static Tween From(Tween.Getter getter, Tween.Setter setter, float endValue, float duration) =>
            TweenUpdater.Instance.AcquireTween(getter, setter, endValue, duration)
                                 .SetReversed(true);

        public static void PlayAll()
        {
            foreach (Tween tween in _tweens) {
                tween.Play();
            }
        }

        public static void Play(int id)
        {
            foreach (Tween tween in _tweens)
            {
                if (tween.id == id) {
                    tween.Play();
                }
            }
        }

        public static void Play<T>(T target) where T: class
        {
            Play(target.GetHashCode());
        }

        public static void StopAll()
        {
            foreach (Tween tween in _tweens) {
                tween.Stop();
            }
        }

        public static void Stop(int id)
        {
            foreach (Tween tween in _tweens)
            {
                if (tween.id == id) {
                    tween.Stop();
                }
            }
        }

        public static void Stop<T>(T target) where T: class
        {
            Stop(target.GetHashCode());
        }

        public static void RestartAll(bool withDelay = true)
        {
            foreach (Tween tween in _tweens) {
                tween.Restart(withDelay);
            }
        }

        public static void Restart(int id, bool withDelay = true)
        {
            foreach (Tween tween in _tweens)
            {
                if (tween.id == id) {
                    tween.Restart(withDelay);
                }
            }
        }

        public static void Restart<T>(T target, bool withDelay = true) where T: class
        {
            Restart(target.GetHashCode(), withDelay);
        }

        public static void CompleteAll()
        {
            foreach (Tween tween in _tweens) {
                tween.Complete();
            }
        }

        public static void Complete(int id)
        {
            foreach (Tween tween in _tweens)
            {
                if (tween.id == id) {
                    tween.Complete();
                }
            }
        }

        public static void Complete<T>(T target) where T: class
        {
            Complete(target.GetHashCode());
        }

        public static void KillAll(bool complete = false)
        {
            foreach (Tween tween in _tweens) {
                Kill(tween, complete);
            }
        }

        public static void Kill(int id, bool complete = false)
        {
            foreach (Tween tween in _tweens)
            {
                if (tween.id == id) {
                    Kill(tween, complete);
                }
            }
        }

        public static void Kill<T>(T target, bool complete = false) where T: class
        {
            Kill(target.GetHashCode(), complete);
        }

        private static void Kill(Tween tween, bool complete)
        {
            if (complete) {
                tween.Complete();
            }

            // Only kill the tween if it is not automatically killed when
            // completed
            if (!tween.autoKill || !complete) {
                tween.Kill();
            }
        }

    }

}
