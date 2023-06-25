# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [2.6.2] - 2022/10/16

### Fixed

- Fixed tweens not updating when the duration is set to zero

### Added

- New extension method `ShadowTweens.TweenAlpha`

### Changed

- Renamed `ShadowTweens.TweenEffectColor` to `ShadowTweens.TweenColor`
- Renamed `ShadowTweens.TweenEffectDistance` to `ShadowTweens.TweenDistance`

## [2.6.1] - 2022/05/11

### Fixed

- Prevented errors caused when tweens are created while the game or scene is unloading

### Changed

- Changed material extension parameter order to match Unity conventions

## [2.6.0] - 2021/09/06

### Changed

- The existing `TweeningSettings` MonoBehaviour has been consolidated into the `Settings` class. Settings can be changed in this class through static properties or as a MonoBehaviour.

## [2.5.0] - 2021/07/21

### Changed

- Global settings defined in `Tweening` have been moved to new static class `Settings`
- Scene indexes default to the current active scene
- Tween `sceneIndex` is now a publicly exposed field
- Shortcut tweens that are not apart of components still have an id set automatically

## [2.4.0] - 2021/06/28

### Added

- New `TweeningSettings` component that can be used to change settings in the editor

### Changed

- Hide `TweenManager` in component menu
- Settings properties have been renamed

## [2.3.0] - 2021/06/27

### Added

- Support for tweening `Rect` values
- New `Material` tween extensions
- New `Camera` tween extensions

### Changed

- Optimized memory consumption using enum flags

### Removed

- Removed `Tweening.killTweensOnSceneUnload` setting. Each tween now tracks the scene index and is automatically killed when that scene is unloaded.

## [2.2.1] - 2021/06/18

### Fixed

- Removed editor only property tweens

## [2.2.0] - 2021/06/15

### Added

- Setting to kill tweens when the scene is unloaded (default=true)

## [2.1.0] - 2021/06/09

### Added

- Support for looping
- Support for snapping
- Support for reversing sequences

## [2.0.1] - 2021/06/07

### Fixed

- Fix meta file reference error

## [2.0.0] - 2021/05/25

### Changed

- Overhauled internal code to be more optimized and memory efficient
- Sequences can now be controlled and managed the same way as any other tween

### Added

- Hundreds of predefined extension methods for tweening properties on common Unity objects
- More generic types are now compatible with the tweening system

## [1.0.1] - 2021/04/13

### Changed

- Package name and description

## [1.0.0] - 2021/03/24

### Added

- Scripts
  - Ease
  - EaseFunction
  - Sequence
  - Settings
  - Tween
  - Tween+Chaining
  - Tweener
  - TweenState
  - TweenUpdater
- Tweenable Objects
  - Audio
  - Camera
  - CanvasGroup
  - Graphic
  - Light
  - SpriteRenderer
  - TextMesh
  - Transform
