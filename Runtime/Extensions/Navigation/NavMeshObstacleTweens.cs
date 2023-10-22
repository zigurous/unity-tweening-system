using UnityEngine;
using UnityEngine.AI;

namespace Zigurous.Tweening
{
    public static class NavMeshObstacleTweens
    {
        public static Tween TweenHeight(this NavMeshObstacle obstacle, float to, float duration) =>
            Tweening.To(obstacle, (target) => target.height, (target, value) => target.height = value, to, duration)
                    .SetReference(obstacle);

        public static Tween TweenRadius(this NavMeshObstacle obstacle, float to, float duration) =>
            Tweening.To(obstacle, (target) => target.radius, (target, value) => target.radius = value, to, duration)
                    .SetReference(obstacle);

        public static Tween TweenSize(this NavMeshObstacle obstacle, Vector3 to, float duration) =>
            Tweening.To(obstacle, (target) => target.size, (target, value) => target.size = value, to, duration)
                    .SetReference(obstacle);

        public static Tween TweenCenter(this NavMeshObstacle obstacle, Vector3 to, float duration) =>
            Tweening.To(obstacle, (target) => target.center, (target, value) => target.center = value, to, duration)
                    .SetReference(obstacle);

        public static Tween TweenVelocity(this NavMeshObstacle obstacle, Vector3 to, float duration) =>
            Tweening.To(obstacle, (target) => target.velocity, (target, value) => target.velocity = value, to, duration)
                    .SetReference(obstacle);
    }

}
