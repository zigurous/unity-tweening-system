using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public static class AudioListenerTweens
    {
        public static Tween TweenVolume(this AudioListener listener, float to, float duration) =>
            Tweener.To(getter: () => AudioListener.volume,
                       setter: volume => AudioListener.volume = volume,
                       to, duration).SetTarget(listener);

    }

}
