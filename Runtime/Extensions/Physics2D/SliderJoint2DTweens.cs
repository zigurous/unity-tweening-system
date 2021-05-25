using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class SliderJoint2DTweens
    {
        public static Tween TweenAngle(this SliderJoint2D joint, float to, float duration) =>
            Tweening.To(getter: () => joint.angle,
                        setter: angle => joint.angle = angle,
                        to, duration).SetTarget(joint);

    }

}
