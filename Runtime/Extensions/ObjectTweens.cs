namespace Zigurous.TweenEngine
{
    public static class ObjectTweens
    {
        public static void KillTweens<T>(this T target, bool complete = false) where T: class
        {
            Tweening.Kill(target, complete);
        }

    }

}
