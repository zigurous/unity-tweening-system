using UnityEngine;
using UnityEngine.AI;

namespace Zigurous.TweenEngine
{
    public static class NavMeshAgentTweens
    {
        public static Tween TweenSpeed(this NavMeshAgent agent, float to, float duration) =>
            Tweening.To(getter: () => agent.speed,
                        setter: speed => agent.speed = speed,
                        to, duration).SetTarget(agent);

        public static Tween TweenAngularSpeed(this NavMeshAgent agent, float to, float duration) =>
            Tweening.To(getter: () => agent.angularSpeed,
                        setter: angularSpeed => agent.angularSpeed = angularSpeed,
                        to, duration).SetTarget(agent);

        public static Tween TweenAcceleration(this NavMeshAgent agent, float to, float duration) =>
            Tweening.To(getter: () => agent.acceleration,
                        setter: acceleration => agent.acceleration = acceleration,
                        to, duration).SetTarget(agent);

        public static Tween TweenRadius(this NavMeshAgent agent, float to, float duration) =>
            Tweening.To(getter: () => agent.radius,
                        setter: radius => agent.radius = radius,
                        to, duration).SetTarget(agent);

        public static Tween TweenHeight(this NavMeshAgent agent, float to, float duration) =>
            Tweening.To(getter: () => agent.height,
                        setter: height => agent.height = height,
                        to, duration).SetTarget(agent);

        public static Tween TweenBaseOffset(this NavMeshAgent agent, float to, float duration) =>
            Tweening.To(getter: () => agent.baseOffset,
                        setter: baseOffset => agent.baseOffset = baseOffset,
                        to, duration).SetTarget(agent);

        public static Tween TweenNextPosition(this NavMeshAgent agent, Vector3 to, float duration) =>
            Tweening.To(getter: () => agent.nextPosition,
                        setter: nextPosition => agent.nextPosition = nextPosition,
                        to, duration).SetTarget(agent);

        public static Tween TweenDestination(this NavMeshAgent agent, Vector3 to, float duration) =>
            Tweening.To(getter: () => agent.destination,
                        setter: destination => agent.destination = destination,
                        to, duration).SetTarget(agent);

        public static Tween TweenVelocity(this NavMeshAgent agent, Vector3 to, float duration) =>
            Tweening.To(getter: () => agent.velocity,
                        setter: velocity => agent.velocity = velocity,
                        to, duration).SetTarget(agent);

        public static Tween TweenStoppingDistance(this NavMeshAgent agent, float to, float duration) =>
            Tweening.To(getter: () => agent.stoppingDistance,
                        setter: stoppingDistance => agent.stoppingDistance = stoppingDistance,
                        to, duration).SetTarget(agent);

    }

}
