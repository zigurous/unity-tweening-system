using UnityEngine.UI;

namespace Zigurous.Tweening
{
    public static class AspectRatioFitterTweens
    {
        public static Tween TweenAspectRatio(this AspectRatioFitter fitter, float to, float duration) =>
            Tweening.To(fitter, (source) => source.aspectRatio, (source, value) => source.aspectRatio = value, to, duration)
                    .SetTarget(fitter);
    }

}
