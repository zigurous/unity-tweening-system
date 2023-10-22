using UnityEngine;

namespace Zigurous.Tweening
{
    public static class AudioListenerTweens
    {
        public static Tween TweenVolume(this AudioListener listener, float to, float duration) =>
            Tweening.To(listener, (source) => AudioListener.volume, (source, value) => AudioListener.volume = value, to, duration)
                    .SetReference(listener);
    }

}
