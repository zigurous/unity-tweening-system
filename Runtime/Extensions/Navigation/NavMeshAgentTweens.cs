using UnityEngine;
using UnityEngine.AI;

namespace Zigurous.Tweening
{
    public static class NavMeshAgentTweens
    {
        public static Tween TweenSpeed(this NavMeshAgent agent, float to, float duration) =>
            Tweening.To(agent, (source) => source.speed, (source, value) => source.speed = value, to, duration)
                    .SetTarget(agent);

        public static Tween TweenAngularSpeed(this NavMeshAgent agent, float to, float duration) =>
            Tweening.To(agent, (source) => source.angularSpeed, (source, value) => source.angularSpeed = value, to, duration)
                    .SetTarget(agent);

        public static Tween TweenAcceleration(this NavMeshAgent agent, float to, float duration) =>
            Tweening.To(agent, (source) => source.acceleration, (source, value) => source.acceleration = value, to, duration)
                    .SetTarget(agent);

        public static Tween TweenRadius(this NavMeshAgent agent, float to, float duration) =>
            Tweening.To(agent, (source) => source.radius, (source, value) => source.radius = value, to, duration)
                    .SetTarget(agent);

        public static Tween TweenHeight(this NavMeshAgent agent, float to, float duration) =>
            Tweening.To(agent, (source) => source.height, (source, value) => source.height = value, to, duration)
                    .SetTarget(agent);

        public static Tween TweenBaseOffset(this NavMeshAgent agent, float to, float duration) =>
            Tweening.To(agent, (source) => source.baseOffset, (source, value) => source.baseOffset = value, to, duration)
                    .SetTarget(agent);

        public static Tween TweenNextPosition(this NavMeshAgent agent, Vector3 to, float duration) =>
            Tweening.To(agent, (source) => source.nextPosition, (source, value) => source.nextPosition = value, to, duration)
                    .SetTarget(agent);

        public static Tween TweenDestination(this NavMeshAgent agent, Vector3 to, float duration) =>
            Tweening.To(agent, (source) => source.destination, (source, value) => source.destination = value, to, duration)
                    .SetTarget(agent);

        public static Tween TweenVelocity(this NavMeshAgent agent, Vector3 to, float duration) =>
            Tweening.To(agent, (source) => source.velocity, (source, value) => source.velocity = value, to, duration)
                    .SetTarget(agent);

        public static Tween TweenStoppingDistance(this NavMeshAgent agent, float to, float duration) =>
            Tweening.To(agent, (source) => source.stoppingDistance, (source, value) => source.stoppingDistance = value, to, duration)
                    .SetTarget(agent);
    }

}
