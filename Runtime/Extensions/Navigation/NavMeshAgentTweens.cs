using UnityEngine;
using UnityEngine.AI;

namespace Zigurous.Tweening
{
    public static class NavMeshAgentTweens
    {
        public static Tween TweenSpeed(this NavMeshAgent agent, float to, float duration) =>
            Tweening.To(agent, (target) => target.speed, (target, value) => target.speed = value, to, duration)
                    .SetReference(agent);

        public static Tween TweenAngularSpeed(this NavMeshAgent agent, float to, float duration) =>
            Tweening.To(agent, (target) => target.angularSpeed, (target, value) => target.angularSpeed = value, to, duration)
                    .SetReference(agent);

        public static Tween TweenAcceleration(this NavMeshAgent agent, float to, float duration) =>
            Tweening.To(agent, (target) => target.acceleration, (target, value) => target.acceleration = value, to, duration)
                    .SetReference(agent);

        public static Tween TweenRadius(this NavMeshAgent agent, float to, float duration) =>
            Tweening.To(agent, (target) => target.radius, (target, value) => target.radius = value, to, duration)
                    .SetReference(agent);

        public static Tween TweenHeight(this NavMeshAgent agent, float to, float duration) =>
            Tweening.To(agent, (target) => target.height, (target, value) => target.height = value, to, duration)
                    .SetReference(agent);

        public static Tween TweenBaseOffset(this NavMeshAgent agent, float to, float duration) =>
            Tweening.To(agent, (target) => target.baseOffset, (target, value) => target.baseOffset = value, to, duration)
                    .SetReference(agent);

        public static Tween TweenNextPosition(this NavMeshAgent agent, Vector3 to, float duration) =>
            Tweening.To(agent, (target) => target.nextPosition, (target, value) => target.nextPosition = value, to, duration)
                    .SetReference(agent);

        public static Tween TweenDestination(this NavMeshAgent agent, Vector3 to, float duration) =>
            Tweening.To(agent, (target) => target.destination, (target, value) => target.destination = value, to, duration)
                    .SetReference(agent);

        public static Tween TweenVelocity(this NavMeshAgent agent, Vector3 to, float duration) =>
            Tweening.To(agent, (target) => target.velocity, (target, value) => target.velocity = value, to, duration)
                    .SetReference(agent);

        public static Tween TweenStoppingDistance(this NavMeshAgent agent, float to, float duration) =>
            Tweening.To(agent, (target) => target.stoppingDistance, (target, value) => target.stoppingDistance = value, to, duration)
                    .SetReference(agent);
    }

}
