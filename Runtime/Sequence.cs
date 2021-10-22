using System.Collections.Generic;

namespace Zigurous.Tweening
{
    /// <summary>
    /// Plays a sequence of tweens in order. The sequence itself maintains its
    /// own state and can be controlled the same as any other tween.
    /// </summary>
    public sealed class Sequence : Tween
    {
        /// <summary>
        /// The index of the current tween in the sequence being played (Read only).
        /// </summary>
        public int currentIndex { get; private set; } = -1;

        /// <summary>
        /// The tweens contained in the sequence (Read only).
        /// </summary>
        public List<Tween> tweens { get; internal set; } = new List<Tween>();

        /// <summary>
        /// The tween in the sequence currently being played (Read only).
        /// </summary>
        public Tween activeTween
        {
            get
            {
                if (currentIndex >= 0 && currentIndex < tweens.Count) {
                    return tweens[currentIndex];
                } else {
                    return null;
                }
            }
        }

        /// <summary>
        /// Creates a new tween sequence.
        /// </summary>
        public Sequence() : base()
        {
            type = TweenType.Sequence;
        }

        public override void Animate()
        {
            // Do nothing. The individual tweens are animated on their own.
        }

        /// <summary>
        /// Plays the tween sequence, whether starting for the first time or
        /// resuming from a stopped state.
        /// </summary>
        /// <returns>The sequence itself to allow for chaining.</returns>
        public new Sequence Play()
        {
            base.Play();
            return this;
        }

        /// <summary>
        /// Adds a new tween to the end of the sequence.
        /// </summary>
        /// <param name="tween">The tween to add.</param>
        /// <returns>The sequence itself to allow for chaining.</returns>
        public Sequence Append(Tween tween)
        {
            tweens.Add(Prepare(tween));
            return this;
        }

        /// <summary>
        /// Adds a new tween to the beginning of the sequence.
        /// </summary>
        /// <param name="tween">The tween to add.</param>
        /// <returns>The sequence itself to allow for chaining.</returns>
        public Sequence Prepend(Tween tween)
        {
            tweens.Insert(0, Prepare(tween));
            return this;
        }

        private Tween Prepare(Tween tween)
        {
            tween.autoStart = false;
            tween.autoKill = false;
            tween.onComplete += Next;
            return tween;
        }

        private void Next()
        {
            if (reversed) {
                currentIndex--;
            } else {
                currentIndex++;
            }

            Tween tween = activeTween;

            if (tween != null) {
                tween.Play();
            }
        }

        /// <inheritdoc/>
        protected override bool IsFinished()
        {
            if (reversed) {
                return currentIndex < 0;
            } else {
                return currentIndex >= tweens.Count;
            }
        }

        /// <inheritdoc/>
        protected override void OnStart()
        {
            if (reversed) {
                currentIndex = tweens.Count - 1;
            } else {
                currentIndex = 0;
            }

            Tween tween = activeTween;

            if (tween != null) {
                tween.Play();
            }
        }

        /// <inheritdoc/>
        protected override void OnStop()
        {
            Tween tween = activeTween;

            if (tween != null) {
                tween.Stop();
            }
        }

        /// <inheritdoc/>
        protected override void OnResume()
        {
            Tween tween = activeTween;

            if (tween != null) {
                tween.Play();
            }
        }

        /// <inheritdoc/>
        protected override void OnLoop()
        {
            foreach (Tween tween in tweens)
            {
                if (loopType == LoopType.PingPong || loopType == LoopType.PingPongWithDelay) {
                    tween.reversed = !tween.reversed;
                }

                tween.elapsed = 0f;
                tween.Animate();
            }
        }

        /// <inheritdoc/>
        protected override void OnComplete()
        {
            foreach (Tween tween in tweens)
            {
                if (tween != null) {
                    tween.Complete();
                }
            }
        }

        /// <inheritdoc/>
        protected override void OnKill()
        {
            foreach (Tween tween in tweens)
            {
                if (tween != null) {
                    tween.Kill();
                }
            }

            tweens.Clear();
            currentIndex = -1;
        }

        /// <inheritdoc/>
        protected override void OnReset()
        {
            tweens.Clear();
            currentIndex = -1;
        }

    }

}
