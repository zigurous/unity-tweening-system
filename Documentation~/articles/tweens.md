---
slug: "/manual/tweens"
---

# Tweens

A tween is an animation of a value from a start position to an end position using an easing function, providing a natural sense of motion. The **Tweening** package provides two main types of tweens, both of which inherit from the base class [Tween](/api/Zigurous.Tweening/Tween).

- [Tweener](/api/Zigurous.Tweening/Tweener-1)
- [Sequence](/api/Zigurous.Tweening/Sequence)

<hr/>

## 🚀 Creating tweens

### Shortcut Functions

Most of the time you will be creating tweens by using the shortcut extension methods available on most Unity objects. See the [Supported Types](/manual/supported-types) manual for the full list of classes that provide shortcut functions. Here are just a few examples:

```csharp
transform.TweenPosition(Vector3.zero, duration);
material.TweenColor(Color.white, duration);
camera.TweenFieldOfView(90f, duration);
light.TweenIntensity(1f, duration);
```
<br/>

### Generic Approach

Although most of the time you will not be creating tweens with this approach, it is the basis of the entire tweening system so it is valuable to understand how it works. Essentially any value represented by a number can be tweened. The [Supported Types](/manual/supported-types) manual provides a list of all types that can be tweened.

```csharp
// Setup delegates to get and set a value
TweenGetter<Transform, Vector3> getter = (target) => target.position;
TweenSetter<Transform, Vector3> setter = (target, value) => target.position = value;

// Create a tween that animates to the end value over a duration
Tweening.To(transform, getter, setter, Vector3.one, 1f);
Tweening.From(transform, getter, setter, Vector3.one, 1f);
```

<hr/>

## ⭐ Customizing tweens

Many properties exist to customize how tweens are animated. Below are all of the available properties and their default values. Read the [Tween](/api/Zigurous.Tweening/Tween) Scripting API to learn more about each individual property.

```csharp
tween.ease = Ease.QuadOut; // the ease function type used to animate values
tween.duration = 0.3f; // the number of seconds the tween takes to complete
tween.delay = 0f; // the number of seconds to wait before starting
tween.loops = 0; // the number of times to loop
tween.loopType = LoopType.Restart; // the style in which the tween loops
tween.reversed = false; // plays the tween in reverse from the end value to the start value
tween.snapping = false; // snaps animated values to whole numbers
tween.recyclable = true; // recycles the tween so it can be reused again
tween.autoStart = true; // starts the tween automatically after being initialized
tween.autoKill = true; // kills the tween automatically after completing
```

There are also [callback functions](/manual/callbacks) that can be set on any tween.<br/>
All of these properties can be set with [property chaining](/manual/property-chaining) methods.

<hr/>

## 🌪️ Controlling tweens

Often times you might want to manually control the state of the tween, even if it is just pausing and resuming a tween. There are several methods available to transition a tween to a different state. *Note:* not all states can be transitioned to depending on the current state. See [Managing Tweens](/manual/managing-tweens) for ways to control tweens globally.

```csharp
tween.Play(); // starts or resumes the tween
tween.Stop(); // pauses the tween if it is already playing
tween.Restart(); // restarts the tween from the beginning if not killed
tween.Complete(); // completes the tween, jumping to the end value
tween.Kill(); // kills the tween in place, preventing any further state changes
```

<hr/>

## 🌀 Tween state

There are a number of properties available to read the current state of a tween. Many of these are based upon the [TweenState](/api/Zigurous.Tweening/TweenState) enum, which indicates that a tween can be in one of the following states at a given time:

- `Ready`: The tween has been initialized and is ready to be played.
- `Playing`: The tween is currently playing and receiving updates.
- `Stopped`: The tween is currently stopped/paused.
- `Complete`: The tween has completed but not yet killed.
- `Killed`: The tween is killed, making it no longer usable.

```csharp
TweenState state = tween.State; // the current animation state of the tween

bool playing = tween.IsPlaying; // true if playing
bool stopped = tween.IsStopped; // true if stopped
bool complete = tween.IsComplete; // true if complete
bool killed = tween.IsKilled; // true if killed
bool delayed = tween.IsDelayed; // true if delayed

float elapsed = tween.Elapsed; // the amount of seconds playing
float percent = tween.PercentComplete; // the percentage of completion
float delayElapsed = tween.DelayElapsed; // the amount of seconds delayed

int iterations = tween.Iterations; // the number of times completed
```
