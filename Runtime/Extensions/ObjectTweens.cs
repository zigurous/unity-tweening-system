namespace Zigurous.Animation.Tweening
{
    public static class ObjectTweens
    {
        public static void KillTweens<T>(this T target, bool complete = false) where T: class
        {
            Tweener.Kill(target, complete);
        }

    }

}
