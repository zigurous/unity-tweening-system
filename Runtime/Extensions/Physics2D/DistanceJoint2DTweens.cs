using UnityEngine;

namespace Zigurous.Tweening
{
    public static class DistanceJoint2DTweens
    {
        public static Tween TweenDistance(this DistanceJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.distance, (target, value) => target.distance = value, to, duration)
                    .SetReference(joint);
    }

}
