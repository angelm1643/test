using UnityEngine;
using UnityEngine.Hellper;

namespace course
{
    public class HelperUseExample : MonoBehaviour
    {
        private void Start()
        {
            RectTransform test = HelperScript.GetRectTramsfoform(transform);
        }
    }
}
