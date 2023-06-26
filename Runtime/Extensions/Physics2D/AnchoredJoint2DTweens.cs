using UnityEngine;

namespace Zigurous.Tweening
{
    public static class AnchoredJoint2DTweens
    {
        public static Tween TweenAnchor(this AnchoredJoint2D joint, Vector2 to, float duration) =>
            Tweening.To(joint, (source) => source.anchor, (source, value) => source.anchor = value, to, duration)
                    .SetTarget(joint);

        public static Tween TweenConnectedAnchor(this AnchoredJoint2D joint, Vector2 to, float duration) =>
            Tweening.To(joint, (source) => source.connectedAnchor, (source, value) => source.connectedAnchor = value, to, duration)
                    .SetTarget(joint);
    }

}
