using UnityEngine;

namespace Zigurous.Tweening
{
    public static class JointTweens
    {
        public static Tween TweenAxis(this Joint joint, Vector3 to, float duration) =>
            Tweening.To(joint, (source) => source.axis, (source, value) => source.axis = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenAnchor(this Joint joint, Vector3 to, float duration) =>
            Tweening.To(joint, (source) => source.anchor, (source, value) => source.anchor = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenConnectedAnchor(this Joint joint, Vector3 to, float duration) =>
            Tweening.To(joint, (source) => source.connectedAnchor, (source, value) => source.connectedAnchor = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenBreakForce(this Joint joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.breakForce, (source, value) => source.breakForce = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenBreakTorque(this Joint joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.breakTorque, (source, value) => source.breakTorque = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenMassScale(this Joint joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.massScale, (source, value) => source.massScale = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenConnectedMassScale(this Joint joint, float to, float duration) =>
            Tweening.To(joint, (source) => source.connectedMassScale, (source, value) => source.connectedMassScale = value, to, duration)
                    .SetTarget(joint);
    }

}
