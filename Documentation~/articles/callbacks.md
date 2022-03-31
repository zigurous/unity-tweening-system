---
slug: "/manual/callbacks"
---

# Callbacks

Callbacks are used to respond to state changes of a tween. A [TweenCallback](/api/Zigurous.Tweening/TweenCallback) function delegate is invoked for each of the following events:

- [onUpdate](/api/Zigurous.Tweening/Tween/onUpdate): Invoked every time the tween is updated
- [onStart](/api/Zigurous.Tweening/Tween/onStart): Invoked when the tween is started
- [onStop](/api/Zigurous.Tweening/Tween/onStop): Invoked when the tween is stopped
- [onLoop](/api/Zigurous.Tweening/Tween/onLoop): Invoked when the tween is looped
- [onComplete](/api/Zigurous.Tweening/Tween/onComplete): Invoked when the tween is completed
- [onKill](/api/Zigurous.Tweening/Tween/onKill): Invoked when the tween is killed

<hr/>

## 🗣️ Assigning callbacks

Tween callbacks can be assigned with lambdas or normal functions. You can also use [property chaining](/manual/property-chaining) to make it easier in some cases. Tween callbacks have no parameters or return types.

```csharp
// assigning callbacks with lambdas
tween.onUpdate = () => Debug.Log("Updated");
tween.onStart = () => Debug.Log("Started");
tween.onStop = () => Debug.Log("Stopped");
tween.onLoop = () => Debug.Log("Looped");
tween.onComplete = () => Debug.Log("Completed");
tween.onKill = () => Debug.Log("Killed");
```

```csharp
// assigning a callback with a function
Tween tween = transform.TweenPosition(Vector3.zero, 1f);
tween.onComplete = SomeFunction;
```
