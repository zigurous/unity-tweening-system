using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public static class ObjectTweens
    {
        public static void KillTweens(this Object target, bool complete = false)
        {
            Tweener.Kill(target, complete);
        }

    }

}
