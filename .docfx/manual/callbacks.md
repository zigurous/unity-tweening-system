# Callbacks

Callbacks are used to respond to state changes of a tween. A [TweenCallback](xref:Zigurous.Tweening.TweenCallback) function delegate is invoked for each of the following events:

- [onUpdate](xref:Zigurous.Tweening.Tween.onUpdate): Invoked every time the tween is updated
- [onStart](xref:Zigurous.Tweening.Tween.onStart): Invoked when the tween is started
- [onStop](xref:Zigurous.Tweening.Tween.onStop): Invoked when the tween is stopped
- [onLoop](xref:Zigurous.Tweening.Tween.onLoop): Invoked when the tween is looped
- [onComplete](xref:Zigurous.Tweening.Tween.onComplete): Invoked when the tween is completed
- [onKill](xref:Zigurous.Tweening.Tween.onKill): Invoked when the tween is killed

### Assigning callbacks

Tween callbacks can be assigned with lambdas or normal functions. You can also use [property chaining](property-chaining.md) to make it easier in some cases. Callbacks cannot declare any parameters or return types.

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
Tween tween = transform.TweenPosition(Vector3.zero, 1.0f);
tween.onComplete = SomeFunction;
```
