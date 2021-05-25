using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class JointDriveTweens
    {
        public static Tween TweenPositionSpring(this JointDrive jointDrive, float to, float duration) =>
            Tweening.To(getter: () => jointDrive.positionSpring,
                        setter: positionSpring => jointDrive.positionSpring = positionSpring,
                        to, duration).SetTarget(jointDrive);

        public static Tween TweenPositionDamper(this JointDrive jointDrive, float to, float duration) =>
            Tweening.To(getter: () => jointDrive.positionDamper,
                        setter: positionDamper => jointDrive.positionDamper = positionDamper,
                        to, duration).SetTarget(jointDrive);

        public static Tween TweenMaximumForce(this JointDrive jointDrive, float to, float duration) =>
            Tweening.To(getter: () => jointDrive.maximumForce,
                        setter: maximumForce => jointDrive.maximumForce = maximumForce,
                        to, duration).SetTarget(jointDrive);

    }

}
