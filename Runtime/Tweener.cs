using System.Collections.Generic;

namespace Zigurous.Animation.Tweening
{
    public static class Tweener
    {
        public static int Count => TweenManager.Instance.tweens.Count;

        public static Tween To(Tween.Getter getter, Tween.Setter setter, float endValue, float duration)
        {
            return TweenManager.Instance.Build(getter, setter, endValue, duration);
        }

        public static Tween From(Tween.Getter getter, Tween.Setter setter, float endValue, float duration)
        {
            return TweenManager.Instance.Build(getter, setter, endValue, duration)
                                        .SetReversed(true);
        }

        public static TweenSequence Sequence()
        {
            return TweenManager.Instance.Build();
        }

        public static TweenSequence Sequence(params Tween[] tweens)
        {
            return TweenManager.Instance.Build(tweens);
        }

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

        public static void Play<T>(T target) where T: class
        {
            Play(target.GetHashCode());
        }

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

        public static void Stop<T>(T target) where T: class
        {
            Stop(target.GetHashCode());
        }

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

        public static void Restart<T>(T target) where T: class
        {
            Restart(target.GetHashCode());
        }

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

        public static void Complete<T>(T target) where T: class
        {
            Complete(target.GetHashCode());
        }

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

        public static void Kill<T>(T target, bool complete = false) where T: class
        {
            Kill(target.GetHashCode(), complete);
        }

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
