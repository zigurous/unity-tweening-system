---
slug: "/manual/managing-tweens"
---

# Managing Tweens

Apart from controlling the state of an individual tween, you can also manage tweens globally using the static class [Tweening](/api/Zigurous.Tweening/Tweening). This class contains functions to change the state of all managed tweens:

```csharp
Tweening.PlayAll();
Tweening.StopAll();
Tweening.RestartAll();
Tweening.CompleteAll();
Tweening.KillAll();
```

You can also get the current amount of tweens:

```csharp
int count = Tweening.Count; // the number of tweens alive (not necessarily active)
int alive = Tweening.ActiveCount; // the number of tween active
```

<hr/>

## 🏷️ Tween Ids

You can also target specific tweens by id. Every tween has an `id` property which allows you to distinguish it from others. However, this is not required, nor is the id unique. The id is set automatically unless you create tweens manually using the generic approach.

```csharp
Tweening.Play(id);
Tweening.Stop(id);
Tweening.Restart(id);
Tweening.Complete(id);
Tweening.Kill(id);
```

<hr/>

## 🎯 Target References

Tweens that are created using the shortcut functions will automatically set the id based on the target object being animated. For example, if you tween a transform's position, the id of the tween will get set to the hash code of the transform instance. This then allows you to find tweens using that reference object.

```csharp
Tweening.Play(transform);
Tweening.Stop(transform);
Tweening.Restart(transform);
Tweening.Complete(transform);
Tweening.Kill(transform);
```

If you create tweens manually using the generic approach, you should indicate to the tween what its target game object or component is, which will set the id of the tween based on that object's hash code.

```csharp
tween.SetTarget(gameObject);
tween.SetTarget(component);
```

<hr/>

## 🎬 Scene Unloading

Tweens will be killed automatically when the scene they are apart of is unloaded which prevents errors. However, this only works automatically if the tween knows which target object it is animating (see above). You should only need to worry about this if you are creating tweens manually using the generic approach.

Make sure to kill your tweens before transitioning scenes, or set the target reference as outlined above. You can also manually set the scene index if desired.

```csharp
tween.sceneIndex = SceneManager.GetActiveScene().buildIndex;
```
