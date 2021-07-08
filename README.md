# Tweening

The Tweening package provides a system for tweening object properties in Unity. A tween is an animation of a value from a start position to an end position using an easing function, providing a natural sense of motion.

The system is lightweight, optimized, type-safe, and memory efficient. Hundreds of pre-defined tweening functions can be called on many common Unity objects, or you can animate anything using generic tweening functions. Tweens can be controlled with many different control methods and various callback functions.

## Installation

Use the Unity [Package Manager](https://docs.unity3d.com/Manual/upm-ui.html) to install the Tweening package.

1. Open the Package Manager in `Window > Package Manager`
2. Click the add (`+`) button in the status bar
3. Select `Add package from git URL` from the add menu
4. Enter the following Git URL in the text box and click Add:

```http
https://github.com/zigurous/unity-tweening-system.git
```

For more information on the Package Manager and installing packages, see the following pages:

- [Unity’s Package Manager](https://docs.unity3d.com/Manual/Packages.html)
- [Installing from a Git URL](https://docs.unity3d.com/Manual/upm-ui-giturl.html)

### Importing

Import the package namespace in each script or file you want to use it. You may need to regenerate project files/assemblies first.

```csharp
using Zigurous.Tweening;
```
