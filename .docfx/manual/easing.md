# Easing

Easing functions specify the rate of change of a parameter over time.

Objects in real life don’t just start and stop instantly, and almost never move at a constant speed. When we open a drawer, we first move it quickly, and slow it down as it comes out. Drop something on the floor, and it will first accelerate downwards, and then bounce back up after hitting the floor.

The website https://easings.net/ is a good resource to visualize common easing functions.

### Using easing functions

To specify which easing function a tween uses, the property [ease](xref:Zigurous.Tweening.Tween.ease) can be set. This property is backed by a custom enum called [Ease](xref:Zigurous.Tweening.Ease) containing 30+ ease types.

```csharp
tween.ease = Ease.QuadOut;
```

You can also use the easing functions directly through the static class [EaseFunction](xref:Zigurous.Tweening.EaseFunction).<br/>
Every easing function takes the form f(x):

```csharp
public float EaseFunction(float x);
```

### Available Eases

- Linear
- SineIn
- SineOut
- SineInOut
- CubicIn
- CubicOut
- CubicInOut
- QuadIn
- QuadOut
- QuadInOut
- QuartIn
- QuartOut
- QuartInOut
- QuintIn
- QuintOut
- QuintInOut
- ExpoIn
- ExpoOut
- ExpoInOut
- CircIn
- CircOut
- CircInOut
- BackIn
- BackOut
- BackInOut
- ElasticIn
- ElasticOut
- ElasticInOut
- BounceIn
- BounceOut
- BounceInOut
