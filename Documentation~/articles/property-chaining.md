---
slug: "/manual/property-chaining"
---

# Property Chaining

Property/method chaining is a technique that allows multiple properties to be assigned in a single statement without requiring a variable to store the intermediate results. This is most useful when creating new tweens. See the [PropertyChaining](/api/Zigurous.Tweening/PropertyChaining) Scripting API for a full list of properties that can be chained.

<hr/>

## ⛓️ Examples

```csharp
// using a tween shortcut
transform.TweenPosition(Vector3.zero, 1f)
         .SetDelay(3f)
         .SetReversed()
         .SetEase(Ease.CubicInOut)
         .SetLoops(-1, LoopType.PingPong)
         .OnLoop(() => Debug.Log("looped!"));
```

```csharp
// building from scratch
Tween tween = new Tweener<Transform, Vector3>(transform)
     .SetGetter((target) => target.position)
     .SetSetter((target, value) => target.position = value)
     .SetEndValue(Vector3.zero)
     .SetDuration(1f)
     .SetEase(Ease.QuadOut)
     .OnComplete(() => Debug.Log("complete!"));
```
