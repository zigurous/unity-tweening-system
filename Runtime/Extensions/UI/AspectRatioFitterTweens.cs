using UnityEngine.UI;

namespace Zigurous.Tweening
{
    public static class AspectRatioFitterTweens
    {
        public static Tween TweenAspectRatio(this AspectRatioFitter fitter, float to, float duration) =>
            Tweening.To(getter: () => fitter.aspectRatio,
                        setter: aspectRatio => fitter.aspectRatio = aspectRatio,
                        to, duration).SetTarget(fitter);

    }

}
