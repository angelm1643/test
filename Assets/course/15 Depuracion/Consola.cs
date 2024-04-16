using UnityEngine;

namespace Course.Depuracion
{
    public class Consola : MonoBehaviour
    {
        private void Start()
        {
            Debug.Log("Type: Message");
            Debug.LogWarning("Type: Warning");
            Debug.LogError("Type: Error");
        }

    }
}
