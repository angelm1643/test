using UnityEngine;

namespace Course.Depuracion
{
    public class ClaseDebug : MonoBehaviour
    {

        private void Start()
        {
            // Print
            print("Hello Print!");

            // Log
            Debug.Log("Hello Log!");
            Debug.LogWarning("Hello Warning!");
            Debug.LogError("Hello Error!");

            // With Format
            Debug.LogFormat("My {0} format!", "Log");
            Debug.LogWarningFormat("My {0} format!", "Warning");
            Debug.LogErrorFormat("My {0} format!", "Error");

            // Break
            //Debug.Break();

            // Get GameObject Location
            Debug.Log("I'm here!", gameObject);

            // Draw
            Debug.DrawLine(
                transform.position,
                transform.position + (Vector3.forward * 5),
                Color.green,
                5f,
                true
                );

            Debug.DrawRay(
                transform.position,
                Vector3.forward * 5,
                Color.yellow,
                5f,
                true
                );

            // Rich Text
            Debug.Log("Rich Text: <color=red>Color by Name</color>");
            Debug.Log("Rich Text: <color=#ff0000ff>Color by Hex Value</color>");
            Debug.Log("Rich Text: <b>Bold</b>");
            Debug.Log("Rich Text: <i>Italic</i>");
            Debug.Log("Rich Text: <size=50>Size</size>");
        }

    }
}
