using UnityEngine;

namespace Zigurous.Tweening
{
    public static class AnchoredJoint2DTweens
    {
        public static Tween TweenAnchor(this AnchoredJoint2D joint, Vector2 to, float duration) =>
            Tweening.To(getter: () => joint.anchor,
                        setter: anchor => joint.anchor = anchor,
                        to, duration).SetTarget(joint);

        public static Tween TweenConnectedAnchor(this AnchoredJoint2D joint, Vector2 to, float duration) =>
            Tweening.To(getter: () => joint.connectedAnchor,
                        setter: connectedAnchor => joint.connectedAnchor = connectedAnchor,
                        to, duration).SetTarget(joint);

    }

}
