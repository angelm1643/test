using UnityEngine;

namespace course
{
    // crea pesta?as para enumerar varias funciones, abres con "region" y cierras con "endregion"
    public class collision : MonoBehaviour
    {
        // 2D y 3D por colision se entiende algo solido e impenetrable, como una pared, algo que no puedes atravesar, limites de mapa, por ejemplo una bala, que desencadena un evento PERO NO LO ATRAVIESA es solido
        #region collision 
        private void OnCollisionEnter(Collision collision)  // es cuando entra una colision, 
        {
            Debug.Log("Collision ENTER");
        }
        private void OnCollisionStay(Collision collision) // es cuando se mantiene una colision,
        {
            Debug.Log("Collision STAY");
        }
        private void OnCollisionExit(Collision collision) // es cuando se sale de una colision,
        {
            Debug.Log("Collision EXIT");
        }
        #endregion

        //2D y 3D, por trigger se entiende una colision que funciona mas bien a modo de AREA es decir es atravesable, podria ser el desencadenante para que pase algun evento, algun cambio si llegas a x zona por ejemplo
        #region trigger
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Trigger ENTER");
        }
        private void OnTriggerStay(Collider other)
        {
            Debug.Log("Trigger STAY");
        }
        private void OnTriggerExit(Collider other)
        {
            Debug.Log("Trigger EXIT");
        }
        #endregion

    }
}
