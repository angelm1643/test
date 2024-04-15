using UnityEngine;
using UnityEngine.Events;

namespace course  // repaso: lo mismo que delegates pero es mas seguro, es decir es lo mas recomendable de usar
{
    public class events : MonoBehaviour  // los eventos son iguales a los delegate pero son mas seguros
    {
        //event  // paso 1 creamos el event o delegate
        public delegate void mydelegateevent();
        //public mydelegateevent mydelegateeventvar;  // forma de trabajarlo como un delegate igual que en el script pasado
        public event mydelegateevent myeventvar;      // forma de trabajarlo como un event

        //unityevents  // igual a los anteriores pero se pueden exponer en el inspector de unity
        public UnityEvent myunityeventvar;

        // se puede trabajar con eventos usando variables
        public UnityEvent<bool> myunityeventoneparamvar;
        public UnityEvent<bool, int, string> myunityeventthreeparamvar;


        private void printMessage()  // paso 2 creamos la varaible a asignar
        {
            Debug.Log("helloWolrd!");
        }


        private void Start()
        {
            myeventvar += printMessage;  // paso 3 igual que en el script anterior de delegates, simplemente asignamos una varaible

            myeventvar();  // forma de llamarlo igual que en el caso anterior
            myeventvar.Invoke();  // forma alternativa recordemos que el invoke sirve para invocar funciones

            //unityevents  // eventos de unity 
            myunityeventvar.AddListener(printMessage); // +=  agregas la varaible
            myunityeventvar.RemoveListener(printMessage); // -=   remueves la varaible

            myunityeventvar.Invoke();  // ejecutas la variable (solo el invoke es valido para eventos de unity)

            // unityevents variables
            myunityeventoneparamvar.Invoke(true);  // el que solo tiene la variante bool, pones el resultado alli
            myunityeventthreeparamvar.Invoke(true, 5, "test");  // el que tiene las 3 variantes, pones los resultados separados por coma asi

        }
    }
}
