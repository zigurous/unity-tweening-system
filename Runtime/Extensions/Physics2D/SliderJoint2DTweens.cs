using UnityEngine;

namespace Zigurous.Tweening
{
    public static class SliderJoint2DTweens
    {
        public static Tween TweenAngle(this SliderJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.angle, (target, value) => target.angle = value, to, duration)
                    .SetReference(joint);
    }

}
