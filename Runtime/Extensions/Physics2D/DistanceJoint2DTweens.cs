using UnityEngine;

namespace Zigurous.Tweening
{
    public static class DistanceJoint2DTweens
    {
        public static Tween TweenDistance(this DistanceJoint2D joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.distance, (source, value) => source.distance = value, to, duration)
                    .SetTarget(joint);
    }

}
