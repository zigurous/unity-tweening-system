using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class AudioListenerTweens
    {
        public static Tween TweenVolume(this AudioListener listener, float to, float duration) =>
            Tweening.To(getter: () => AudioListener.volume,
                        setter: volume => AudioListener.volume = volume,
                        to, duration).SetTarget(listener);

    }

}
