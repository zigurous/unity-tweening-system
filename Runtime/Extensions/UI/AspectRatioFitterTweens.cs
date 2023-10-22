using UnityEngine.UI;

namespace Zigurous.Tweening
{
    public static class AspectRatioFitterTweens
    {
        public static Tween TweenAspectRatio(this AspectRatioFitter fitter, float to, float duration) =>
            Tweening.To(fitter, (target) => target.aspectRatio, (target, value) => target.aspectRatio = value, to, duration)
                    .SetReference(fitter);
    }

}
