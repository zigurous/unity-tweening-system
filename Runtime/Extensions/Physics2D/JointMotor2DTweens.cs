using UnityEngine;

namespace Zigurous.TweenEngine
{
    public static class JointMotor2DTweens
    {
        public static Tween TweenMotorSpeed(this JointMotor2D motor, float to, float duration) =>
            Tweening.To(getter: () => motor.motorSpeed,
                        setter: motorSpeed => motor.motorSpeed = motorSpeed,
                        to, duration).SetTarget(motor);

        public static Tween TweenMaxMotorTorque(this JointMotor2D motor, float to, float duration) =>
            Tweening.To(getter: () => motor.maxMotorTorque,
                        setter: maxMotorTorque => motor.maxMotorTorque = maxMotorTorque,
                        to, duration).SetTarget(motor);

    }

}
