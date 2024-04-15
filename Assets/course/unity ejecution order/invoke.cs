using UnityEngine;

namespace course
{
    public class invoke : MonoBehaviour
    {
        // invoke: invoca una funcion, por ej mientras el jugador esta en un charco acido que tenga stay trigger, se te invoca la funcion "dmg" cada 3 segundos
        #region Invoke
        private void Start()
        {
            //Invoke("callinvoke", 3f); // pones el 3f al final para que se repita 1 vez al iniciar la esena o al triggear algo a los 3 segundos
            InvokeRepeating("callinvoke", 3f,1f); // con invoke repeating como el nombre dice repite el invoke, se usa igual que el anterior pero se pone una coma extra para poner el intervalo de repeticion entre cada vez

            CancelInvoke();
            IsInvoking("callinvoke");
        }
        private void callinvoke()
        {
            Debug.Log("Invoke Call");
        }
        #endregion

    }
}
