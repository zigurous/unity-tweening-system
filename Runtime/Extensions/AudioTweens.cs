using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public static class AudioTweens
    {
        public static Tween TweenPitch(this AudioSource audio, float to, float duration) =>
            Tweener.To(getter: () => audio.pitch,
                       setter: pitch => audio.pitch = pitch,
                       to, duration).SetTarget(audio);

        public static Tween TweenVolume(this AudioSource audio, float to, float duration) =>
            Tweener.To(getter: () => audio.volume,
                       setter: volume => audio.volume = volume,
                       to, duration).SetTarget(audio);

    }

}
