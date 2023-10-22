using UnityEngine;

namespace Zigurous.Tweening
{
    public static class JointTweens
    {
        public static Tween TweenAxis(this Joint joint, Vector3 to, float duration) =>
            Tweening.To(joint, (target) => target.axis, (target, value) => target.axis = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenAnchor(this Joint joint, Vector3 to, float duration) =>
            Tweening.To(joint, (target) => target.anchor, (target, value) => target.anchor = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenConnectedAnchor(this Joint joint, Vector3 to, float duration) =>
            Tweening.To(joint, (target) => target.connectedAnchor, (target, value) => target.connectedAnchor = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenBreakForce(this Joint joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.breakForce, (target, value) => target.breakForce = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenBreakTorque(this Joint joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.breakTorque, (target, value) => target.breakTorque = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenMassScale(this Joint joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.massScale, (target, value) => target.massScale = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenConnectedMassScale(this Joint joint, float to, float duration) =>
            Tweening.To(joint, (target) => target.connectedMassScale, (target, value) => target.connectedMassScale = value, to, duration)
                    .SetReference(joint);
    }

}
