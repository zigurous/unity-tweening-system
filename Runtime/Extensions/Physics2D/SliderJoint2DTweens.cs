using UnityEngine;

namespace Zigurous.Tweening
{
    public static class SliderJoint2DTweens
    {
        public static Tween TweenAngle(this SliderJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.angle, (source, value) => source.angle = value, to, duration)
                    .SetTarget(joint);
    }

}
