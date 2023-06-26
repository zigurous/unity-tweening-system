using UnityEngine;
using UnityEngine.AI;

namespace Zigurous.Tweening
{
    public static class NavMeshObstacleTweens
    {
        public static Tween TweenHeight(this NavMeshObstacle obstacle, float to, float duration) =>
            Tweening.To(obstacle, (source) => source.height, (source, value) => source.height = value, to, duration)
                    .SetTarget(obstacle);

        public static Tween TweenRadius(this NavMeshObstacle obstacle, float to, float duration) =>
            Tweening.To(obstacle, (source) => source.radius, (source, value) => source.radius = value, to, duration)
                    .SetTarget(obstacle);

        public static Tween TweenSize(this NavMeshObstacle obstacle, Vector3 to, float duration) =>
            Tweening.To(obstacle, (source) => source.size, (source, value) => source.size = value, to, duration)
                    .SetTarget(obstacle);

        public static Tween TweenCenter(this NavMeshObstacle obstacle, Vector3 to, float duration) =>
            Tweening.To(obstacle, (source) => source.center, (source, value) => source.center = value, to, duration)
                    .SetTarget(obstacle);

        public static Tween TweenVelocity(this NavMeshObstacle obstacle, Vector3 to, float duration) =>
            Tweening.To(obstacle, (source) => source.velocity, (source, value) => source.velocity = value, to, duration)
                    .SetTarget(obstacle);
    }

}
