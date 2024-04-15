using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Hellper
{
    public static class HelperScript  // static o estatica significa que se puede acceder desde cualquier lado, como public pero aun mas accesible
    {
        public static RectTransform GetRectTramsfoform(this Transform t)
        {
            return t as RectTransform;
        }
    }
}
