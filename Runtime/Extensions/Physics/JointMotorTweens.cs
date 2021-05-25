using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class JointMotorTweens
    {
        public static Tween TweenTargetVelocity(this JointMotor jointMotor, float to, float duration) =>
            Tweening.To(getter: () => jointMotor.targetVelocity,
                        setter: targetVelocity => jointMotor.targetVelocity = targetVelocity,
                        to, duration).SetTarget(jointMotor);

        public static Tween TweenJointMotor(this JointMotor jointMotor, float to, float duration) =>
            Tweening.To(getter: () => jointMotor.force,
                        setter: force => jointMotor.force = force,
                        to, duration).SetTarget(jointMotor);

    }

}
