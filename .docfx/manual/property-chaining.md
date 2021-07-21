# Property Chaining

Property/method chaining is a technique that allows multiple properties to be assigned in a single statement without requiring a variable to store the intermediate results. This is most useful when creating new tweens. See the [PropertyChaining](xref:Zigurous.Tweening.PropertyChaining) Scripting API for a full list of properties that can be chained.

### Example

```csharp
transform.TweenPosition(Vector3.zero, 1.0f)
         .SetDelay(3.0f)
         .SetReversed(true)
         .SetEase(Ease.CubicInOut)
         .SetLoops(-1, LoopType.PingPong)
         .OnLoop(() => Debug.Log('looped!'));
```
