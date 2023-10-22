namespace Zigurous.Tweening
{
    /// <summary>
    /// Provides method chaining for tweens. This allows multiple properties to
    /// be assigned in a single statement without requiring a variable to store
    /// the intermediate results.
    /// </summary>
    public static class PropertyChaining
    {
        /// <summary>
        /// Sets the target object of the tween.
        /// </summary>
        /// <typeparam name="T">The type of object being tweened.</typeparam>
        /// <typeparam name="U">The type of parameter being tweened.</typeparam>
        /// <param name="tween">The tween to assign the target to.</param>
        /// <param name="target">The target object to tween.</param>
        /// <returns>The tween itself to allow for chaining.</returns>
        public static Tweener<T,U> SetTarget<T,U>(this Tweener<T,U> tween, T target)
        {
            if (tween != null)
            {
                tween.target = target;

                if (target is UnityEngine.Component component) {
                    SetReference(tween, component);
                } else if (target is UnityEngine.GameObject gameObject) {
                    SetReference(tween, gameObject);
                } else if (target is UnityEngine.Object obj) {
                    SetReference(tween, obj);
                }
            }

            return tween;
        }

        /// <summary>
        /// Sets the getter function of the tween.
        /// </summary>
        /// <typeparam name="T">The type of object being tweened.</typeparam>
        /// <typeparam name="U">The type of parameter being tweened.</typeparam>
        /// <param name="tween">The tween to assign the getter to.</param>
        /// <param name="getter">The getter function to set.</param>
        /// <returns>The tween itself to allow for chaining.</returns>
        public static Tweener<T,U> SetGetter<T,U>(this Tweener<T,U> tween, TweenGetter<T,U> getter)
        {
            if (tween != null) {
                tween.getter = getter;
            }

            return tween;
        }

        /// <summary>
        /// Sets the setter function of the tween.
        /// </summary>
        /// <typeparam name="T">The type of object being tweened.</typeparam>
        /// <typeparam name="U">The type of parameter being tweened.</typeparam>
        /// <param name="tween">The tween to assign the setter to.</param>
        /// <param name="setter">The setter function to set.</param>
        /// <returns>The tween itself to allow for chaining.</returns>
        public static Tweener<T,U> SetSetter<T,U>(this Tweener<T,U> tween, TweenSetter<T,U> setter)
        {
            if (tween != null) {
                tween.setter = setter;
            }

            return tween;
        }

        /// <summary>
        /// Sets the end value of the tween.
        /// </summary>
        /// <typeparam name="T">The type of object being tweened.</typeparam>
        /// <typeparam name="U">The type of parameter being tweened.</typeparam>
        /// <param name="tween">The tween to assign the setter to.</param>
        /// <param name="endValue">The end value to set.</param>
        /// <returns>The tween itself to allow for chaining.</returns>
        public static Tweener<T,U> SetEndValue<T,U>(this Tweener<T,U> tween, U endValue)
        {
            if (tween != null) {
                tween.endValue = endValue;
            }

            return tween;
        }

        /// <summary>
        /// Sets the id and scene index of the tween to the reference component
        /// so the tween can be retrieved and destroyed based on that component.
        /// </summary>
        /// <typeparam name="T">The type of the tween.</typeparam>
        /// <param name="tween">The tween to assign the reference to.</param>
        /// <param name="reference">The reference component.</param>
        /// <returns>The tween itself to allow for chaining.</returns>
        public static T SetReference<T>(this T tween, UnityEngine.Component reference) where T : Tween
        {
            if (tween != null && reference != null)
            {
                tween.id = reference.GetInstanceID();
                tween.sceneIndex = reference.gameObject.scene.buildIndex;
            }

            return tween;
        }

        /// <summary>
        /// Sets the id and scene index of the tween to the reference game
        /// object so the tween can be retrieved and destroyed based on that
        /// game object.
        /// </summary>
        /// <typeparam name="T">The type of the tween.</typeparam>
        /// <param name="tween">The tween to assign the reference to.</param>
        /// <param name="reference">The reference game object.</param>
        /// <returns>The tween itself to allow for chaining.</returns>
        public static T SetReference<T>(this T tween, UnityEngine.GameObject reference) where T : Tween
        {
            if (tween != null && reference != null)
            {
                tween.id = reference.GetInstanceID();
                tween.sceneIndex = reference.scene.buildIndex;
            }

            return tween;
        }

        /// <summary>
        /// Sets the id and scene index of the tween to the reference object so
        /// the tween can be retrieved and destroyed based on that object.
        /// </summary>
        /// <typeparam name="T">The type of the tween.</typeparam>
        /// <param name="tween">The tween to assign the reference to.</param>
        /// <param name="reference">The reference object.</param>
        /// <returns>The tween itself to allow for chaining.</returns>
        public static T SetReference<T>(this T tween, UnityEngine.Object reference) where T : Tween
        {
            if (tween != null && reference != null) {
                tween.id = reference.GetInstanceID();
            }

            return tween;
        }

        /// <summary>
        /// Sets the id of the tween to the given value.
        /// </summary>
        /// <typeparam name="T">The type of the tween.</typeparam>
        /// <param name="tween">The tween to assign the id to.</param>
        /// <param name="id">The id to set.</param>
        /// <returns>The tween itself to allow for chaining.</returns>
        public static T SetId<T>(this T tween, int id) where T : Tween
        {
            if (tween != null) {
                tween.id = id;
            }

            return tween;
        }

        /// <summary>
        /// Sets the scene index of the tween to the given value.
        /// </summary>
        /// <typeparam name="T">The type of the tween.</typeparam>
        /// <param name="tween">The tween to assign the scene index to.</param>
        /// <param name="index">The scene index to set.</param>
        /// <returns>The tween itself to allow for chaining.</returns>
        public static T SetSceneIndex<T>(this T tween, int index) where T : Tween
        {
            if (tween != null) {
                tween.sceneIndex = index;
            }

            return tween;
        }

        /// <summary>
        /// Sets the ease of the tween to the given value.
        /// </summary>
        /// <typeparam name="T">The type of the tween.</typeparam>
        /// <param name="tween">The tween to assign the ease to.</param>
        /// <param name="ease">The ease to set.</param>
        /// <returns>The tween itself to allow for chaining.</returns>
        public static T SetEase<T>(this T tween, Ease ease) where T : Tween
        {
            if (tween != null) {
                tween.ease = ease;
            }

            return tween;
        }

        /// <summary>
        /// Sets the duration of the tween to the given value.
        /// </summary>
        /// <typeparam name="T">The type of the tween.</typeparam>
        /// <param name="tween">The tween to assign the duration to.</param>
        /// <param name="duration">The duration to set.</param>
        /// <returns>The tween itself to allow for chaining.</returns>
        public static T SetDuration<T>(this T tween, float duration) where T : Tween
        {
            if (tween != null) {
                tween.duration = duration;
            }

            return tween;
        }

        /// <summary>
        /// Sets the delay of the tween to the given value.
        /// </summary>
        /// <typeparam name="T">The type of the tween.</typeparam>
        /// <param name="tween">The tween to assign the delay to.</param>
        /// <param name="delay">The delay to set.</param>
        /// <returns>The tween itself to allow for chaining.</returns>
        public static T SetDelay<T>(this T tween, float delay) where T : Tween
        {
            if (tween != null) {
                tween.delay = delay;
            }

            return tween;
        }

        /// <summary>
        /// Sets the number of loops of the tween to the given value.
        /// </summary>
        /// <typeparam name="T">The type of the tween.</typeparam>
        /// <param name="tween">The tween to loop.</param>
        /// <param name="loops">The number of loops to set.</param>
        /// <param name="loopType">The type of loop style to set.</param>
        /// <returns>The tween itself to allow for chaining.</returns>
        public static T SetLoops<T>(this T tween, int loops, LoopType loopType = LoopType.Restart) where T : Tween
        {
            if (tween != null)
            {
                tween.loops = loops;
                tween.loopType = loopType;
            }

            return tween;
        }

        /// <summary>
        /// Sets the tween to play in reverse.
        /// </summary>
        /// <typeparam name="T">The type of the tween.</typeparam>
        /// <param name="tween">The tween to reverse.</param>
        /// <param name="reversed">True if the tween is to be played in reverse.</param>
        /// <returns>The tween itself to allow for chaining.</returns>
        public static T SetReversed<T>(this T tween, bool reversed = true) where T : Tween
        {
            if (tween != null) {
                tween.reversed = reversed;
            }

            return tween;
        }

        /// <summary>
        /// Sets the tween to snap interpolated values to whole numbers.
        /// </summary>
        /// <typeparam name="T">The type of the tween.</typeparam>
        /// <param name="tween">The tween to enable snapping on.</param>
        /// <param name="snapping">True if interpolated values should be snapped to whole numbers.</param>
        /// <returns>The tween itself to allow for chaining.</returns>
        public static T SetSnapping<T>(this T tween, bool snapping = true) where T : Tween
        {
            if (tween != null) {
                tween.snapping = snapping;
            }

            return tween;
        }

        /// <summary>
        /// Sets the tween to be recycled after being completed.
        /// </summary>
        /// <typeparam name="T">The type of the tween.</typeparam>
        /// <param name="tween">The tween to recycle.</param>
        /// <param name="recyclable">True if the tween is to be recycled.</param>
        /// <returns>The tween itself to allow for chaining.</returns>
        public static T SetRecyclable<T>(this T tween, bool recyclable = true) where T : Tween
        {
            if (tween != null) {
                tween.recyclable = recyclable;
            }

            return tween;
        }

        /// <summary>
        /// Sets the tween to auto start after being initialized.
        /// </summary>
        /// <typeparam name="T">The type of the tween.</typeparam>
        /// <param name="tween">The tween to auto start.</param>
        /// <param name="autoStart">True if the tween is to be started automatically.</param>
        /// <returns>The tween itself to allow for chaining.</returns>
        public static T SetAutoStart<T>(this T tween, bool autoStart = true) where T : Tween
        {
            if (tween != null) {
                tween.autoStart = autoStart;
            }

            return tween;
        }

        /// <summary>
        /// Sets the tween to auto kill after being completed.
        /// </summary>
        /// <typeparam name="T">The type of the tween.</typeparam>
        /// <param name="tween">The tween to auto kill.</param>
        /// <param name="autoKill">True if the tween is to be killed automatically.</param>
        /// <returns>The tween itself to allow for chaining.</returns>
        public static T SetAutoKill<T>(this T tween, bool autoKill = true) where T : Tween
        {
            if (tween != null) {
                tween.autoKill = autoKill;
            }

            return tween;
        }

        /// <summary>
        /// Sets the callback to invoke when the tween is updated.
        /// </summary>
        /// <typeparam name="T">The type of the tween.</typeparam>
        /// <param name="tween">The tween to assign the callback to.</param>
        /// <param name="callback">The callback to invoke.</param>
        /// <returns>The tween itself to allow for chaining.</returns>
        public static T OnUpdate<T>(this T tween, TweenCallback callback) where T : Tween
        {
            if (tween != null) {
                tween.onUpdate += callback;
            }

            return tween;
        }

        /// <summary>
        /// Sets the callback to invoke when the tween is started.
        /// </summary>
        /// <typeparam name="T">The type of the tween.</typeparam>
        /// <param name="tween">The tween to assign the callback to.</param>
        /// <param name="callback">The callback to invoke.</param>
        /// <returns>The tween itself to allow for chaining.</returns>
        public static T OnStart<T>(this T tween, TweenCallback callback) where T : Tween
        {
            if (tween != null) {
                tween.onStart += callback;
            }

            return tween;
        }

        /// <summary>
        /// Sets the callback to invoke when the tween is stopped.
        /// </summary>
        /// <typeparam name="T">The type of the tween.</typeparam>
        /// <param name="tween">The tween to assign the callback to.</param>
        /// <param name="callback">The callback to invoke.</param>
        /// <returns>The tween itself to allow for chaining.</returns>
        public static T OnStop<T>(this T tween, TweenCallback callback) where T : Tween
        {
            if (tween != null) {
                tween.onStop += callback;
            }

            return tween;
        }

        /// <summary>
        /// Sets the callback to invoke when the tween is looped.
        /// </summary>
        /// <typeparam name="T">The type of the tween.</typeparam>
        /// <param name="tween">The tween to assign the callback to.</param>
        /// <param name="callback">The callback to invoke.</param>
        /// <returns>The tween itself to allow for chaining.</returns>
        public static T OnLoop<T>(this T tween, TweenCallback callback) where T : Tween
        {
            if (tween != null) {
                tween.onLoop += callback;
            }

            return tween;
        }

        /// <summary>
        /// Sets the callback to invoke when the tween is completed.
        /// </summary>
        /// <typeparam name="T">The type of the tween.</typeparam>
        /// <param name="tween">The tween to assign the callback to.</param>
        /// <param name="callback">The callback to invoke.</param>
        /// <returns>The tween itself to allow for chaining.</returns>
        public static T OnComplete<T>(this T tween, TweenCallback callback) where T : Tween
        {
            if (tween != null) {
                tween.onComplete += callback;
            }

            return tween;
        }

        /// <summary>
        /// Sets the callback to invoke when the tween is killed.
        /// </summary>
        /// <typeparam name="T">The type of the tween.</typeparam>
        /// <param name="tween">The tween to assign the callback to.</param>
        /// <param name="callback">The callback to invoke.</param>
        /// <returns>The tween itself to allow for chaining.</returns>
        public static T OnKill<T>(this T tween, TweenCallback callback) where T : Tween
        {
            if (tween != null) {
                tween.onKill += callback;
            }

            return tween;
        }

    }

}
