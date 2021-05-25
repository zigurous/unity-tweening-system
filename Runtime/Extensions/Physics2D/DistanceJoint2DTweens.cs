using UnityEngine;

namespace Zigurous.Tweening
{
    public static class DistanceJoint2DTweens
    {
        public static Tween TweenDistance(this DistanceJoint2D joint, float to, float duration) =>
            Tweening.To(getter: () => joint.distance,
                        setter: distance => joint.distance = distance,
                        to, duration).SetTarget(joint);

    }

}
