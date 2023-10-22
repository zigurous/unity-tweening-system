using UnityEngine;

namespace Zigurous.Tweening
{
    public static class AnchoredJoint2DTweens
    {
        public static Tween TweenAnchor(this AnchoredJoint2D joint, Vector2 to, float duration) =>
            Tweening.To(joint, (target) => target.anchor, (target, value) => target.anchor = value, to, duration)
                    .SetReference(joint);

        public static Tween TweenConnectedAnchor(this AnchoredJoint2D joint, Vector2 to, float duration) =>
            Tweening.To(joint, (target) => target.connectedAnchor, (target, value) => target.connectedAnchor = value, to, duration)
                    .SetReference(joint);
    }

}
