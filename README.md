# Tweening

[![](https://img.shields.io/badge/github-repo-blue?logo=github)](https://github.com/zigurous/unity-tweening-system) [![](https://img.shields.io/github/package-json/v/zigurous/unity-tweening-system)](https://github.com/zigurous/unity-tweening-system/releases) [![](https://img.shields.io/badge/docs-link-success)](https://docs.zigurous.com/com.zigurous.tweening) [![](https://img.shields.io/github/license/zigurous/unity-tweening-system)](https://github.com/zigurous/unity-tweening-system/blob/main/LICENSE.md)

The Tweening package provides a system for tweening object properties in Unity. A tween is an animation of a value from a start position to an end position using an easing function, providing a natural sense of motion.

The system is lightweight, optimized, type-safe, and memory efficient. Hundreds of predefined tweening functions can be called on many common Unity objects, or you can animate anything using generic tweening functions. Tweens can be controlled with many different control methods and various callback functions.

## Reference

- [Tweens](https://docs.zigurous.com/com.zigurous.tweening/manual/tweens.html)
- [Sequences](https://docs.zigurous.com/com.zigurous.tweening/manual/sequences.html)
- [Easing](https://docs.zigurous.com/com.zigurous.tweening/manual/easing.html)
- [Callbacks](https://docs.zigurous.com/com.zigurous.tweening/manual/callbacks.html)
- [Property Chaining](https://docs.zigurous.com/com.zigurous.tweening/manual/property-chaining.html)
- [Managing Tweens](https://docs.zigurous.com/com.zigurous.tweening/manual/managing-tweens.html)
- [Supported Types](https://docs.zigurous.com/com.zigurous.tweening/manual/supported-types.html)
- [Settings](https://docs.zigurous.com/com.zigurous.tweening/manual/settings.html)

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

- [Unity's Package Manager](https://docs.unity3d.com/Manual/Packages.html)
- [Installing from a Git URL](https://docs.unity3d.com/Manual/upm-ui-giturl.html)

### Importing

Import the package namespace in each script or file you want to use it.

> **Note**: You may need to regenerate project files/assemblies first.

```csharp
using Zigurous.Tweening;
```
