using UnityEngine;
using UnityEngine.AI;

namespace Zigurous.TweenEngine
{
    public static class NavMeshObstacleTweens
    {
        public static Tween TweenHeight(this NavMeshObstacle obstacle, float to, float duration) =>
            Tweening.To(getter: () => obstacle.height,
                        setter: height => obstacle.height = height,
                        to, duration).SetTarget(obstacle);

        public static Tween TweenRadius(this NavMeshObstacle obstacle, float to, float duration) =>
            Tweening.To(getter: () => obstacle.radius,
                        setter: radius => obstacle.radius = radius,
                        to, duration).SetTarget(obstacle);

        public static Tween TweenSize(this NavMeshObstacle obstacle, Vector3 to, float duration) =>
            Tweening.To(getter: () => obstacle.size,
                        setter: size => obstacle.size = size,
                        to, duration).SetTarget(obstacle);

        public static Tween TweenCenter(this NavMeshObstacle obstacle, Vector3 to, float duration) =>
            Tweening.To(getter: () => obstacle.center,
                        setter: center => obstacle.center = center,
                        to, duration).SetTarget(obstacle);

        public static Tween TweenVelocity(this NavMeshObstacle obstacle, Vector3 to, float duration) =>
            Tweening.To(getter: () => obstacle.velocity,
                        setter: velocity => obstacle.velocity = velocity,
                        to, duration).SetTarget(obstacle);

    }

}
