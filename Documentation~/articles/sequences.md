---
slug: "/manual/sequences"
---

# Sequences

A [Sequence](/api/Zigurous.Tweening/Sequence) play a list of tweens in order. The sequence itself maintains its own state and can be controlled the same as any other tween (although not every property has an effect).

<hr/>

## 🧬 Creating a sequence

Sequences can be created in one of two ways. You can simply instantiate one like any other class. However, it is recommended to create one using the static class [Tweening](/api/Zigurous.Tweening/Tweening) so it can reuse recycled sequences.

```csharp
Sequence sequence = Tweening.Sequence(); // Recommended
Sequence sequence = new Sequence(); // Not recommended
```

<hr/>

## ➕ Adding tweens

Tweens can either be added to the end or beginning of the sequence using `Append` or `Prepend`, respectively. Tweens will automatically start and stop as needed based on the state of the sequence. You should not manually transition a tween to playing or stopping (or any other state), instead change the state of the sequence. You can still customize individual tween properties, like duration, ease, callbacks, etc.

```csharp
Sequence sequence = Tweening.Sequence();

// Adds a tween to the end of the sequence
sequence.Append(transform.TweenPosition(Vector3.zero, 1f));
sequence.Append(transform.TweenRotation(Quaternion.identity, 1f));

// Adds a tween to the beginning of the sequence
sequence.Prepend(transform.TweenScale(Vector3.one, 1f));
```

<hr/>

## 🔆 State control

Sequences can be controlled the same way as any other tween, meaning you can play, stop, restart, loop, kill etc.

```csharp
Sequence sequence = Tweening.Sequence();
sequence.SetLoops(-1, LoopType.PingPong);
sequence.OnComplete(() => Debug.Log("sucess!"));
sequence.Play();
```
