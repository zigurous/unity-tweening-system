---
slug: "/manual/events"
---

# Events

Various events are invoked throughout the tween lifecycle. A [TweenCallback](/api/Zigurous.Tweening/TweenCallback) function delegate can be used to respond to the following events:

- [onUpdate](/api/Zigurous.Tweening/Tween/onUpdate): Invoked every time the tween is updated
- [onStart](/api/Zigurous.Tweening/Tween/onStart): Invoked when the tween is started
- [onStop](/api/Zigurous.Tweening/Tween/onStop): Invoked when the tween is stopped
- [onLoop](/api/Zigurous.Tweening/Tween/onLoop): Invoked when the tween is looped
- [onComplete](/api/Zigurous.Tweening/Tween/onComplete): Invoked when the tween is completed
- [onKill](/api/Zigurous.Tweening/Tween/onKill): Invoked when the tween is killed

<hr/>

## 🗣️ Assigning callbacks

Tween callbacks can be assigned with delegates or lambdas. They have no parameters or return types. You can also use [property chaining](/manual/property-chaining) to make it easier to set multiple callbacks.

```csharp
// assigning callbacks with functions
tween.onUpdate += OnTweenUpdated
tween.onStart += OnTweenStarted;
tween.onStop += OnTweenStopped;
tween.onLoop += OnTweenLooped;
tween.onComplete += OnTweenCompleted;
tween.onKill += OnTweenKilled;
```

```csharp
// assigning callbacks with lambdas
tween.onUpdate += () => Debug.Log("Updated");
tween.onStart += () => Debug.Log("Started");
tween.onStop += () => Debug.Log("Stopped");
tween.onLoop += () => Debug.Log("Looped");
tween.onComplete += () => Debug.Log("Completed");
tween.onKill += () => Debug.Log("Killed");
```

```csharp
// assigning callbacks with property chaining
transform.TweenPosition(Vector3.zero, 1f)
         .OnUpdate(OnTweenUpdated)
         .OnStart(OnTweenStarted)
         .OnStop(OnTweenStopped)
         .OnLoop(OnTweenLooped)
         .OnComplete(OnTweenCompleted)
         .OnKill(OnTweenKilled);
```

## 🎫 Event Handler

One drawback of using delegates is that it produces GC allocations. If you are highly concerned about performance, you can use the [ITweenEventHandler](/api/Zigurous.Tweening/ITweenEventHandler) interface to avoid allocations.

```csharp
public class Example : MonoBehaviour, ITweenEventHandler
{
    private void Start()
    {
        transform.TweenPosition(Vector3.zero, 1f)
                 .SetEventHandler(this);
    }

    public void OnTweenUpdate(Tween tween)
    {
        Debug.Log("Updated");
    }

    public void OnTweenStart(Tween tween)
    {
        Debug.Log("Started");
    }

    public void OnTweenStop(Tween tween)
    {
        Debug.Log("Stopped");
    }

    public void OnTweenLoop(Tween tween)
    {
        Debug.Log("Looped");
    }

    public void OnTweenComplete(Tween tween)
    {
        Debug.Log("Completed");
    }

    public void OnTweenKill(Tween tween)
    {
        Debug.Log("Killed");
    }
}
