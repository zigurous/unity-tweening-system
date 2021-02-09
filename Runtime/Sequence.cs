using System;
using System.Collections.Generic;

namespace Zigurous.Animation.Tweening
{
    public sealed class Sequence : IDisposable
    {
        private LinkedList<Tween> _sequence = new LinkedList<Tween>();
        public Tween.Callback onComplete;

        public bool IsPlaying => _playing;
        private bool _playing;

        public void Dispose()
        {
            _sequence?.Clear();
            _sequence = null;

            this.onComplete = null;
        }

        public Sequence Play()
        {
            if (!_playing && _sequence.Count > 0)
            {
                _playing = true;
                Next();
            }

            return this;
        }

        private void Next()
        {
            if (_sequence.Count <= 0)
            {
                _playing = false;
                this.onComplete?.Invoke();
                return;
            }

            Tween tween = _sequence.First.Value;
            tween.Play();

            _sequence.RemoveFirst();
        }

        public Sequence Append(Tween tween)
        {
            _sequence.AddLast(Prepare(tween));
            return this;
        }

        public Sequence Prepend(Tween tween)
        {
            _sequence.AddFirst(Prepare(tween));
            return this;
        }

        public Sequence OnComplete(Tween.Callback callback)
        {
            this.onComplete = callback;
            return this;
        }

        private Tween Prepare(Tween tween)
        {
            tween.autoStart = false;
            tween.autoKill = true;
            tween.onComplete = Next;

            return tween;
        }

    }

}
