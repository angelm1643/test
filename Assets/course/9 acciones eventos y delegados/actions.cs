using System;
using UnityEngine;
using UnityEngine.Events;

namespace course  // repaso: las acciones son internamente como funcionan, como script rapido desde el inspector de unity en caso de unityevent
{
    public class actions : MonoBehaviour
    {
        public Action actionvar;
        public UnityAction myunityactionVar;

        public Action<int> actionOneparamVar;
        public UnityAction<int> myunityactionOneparamVar;
        
        public Action<int, bool, string> myactionthreeparamVar;  //si lo queremos complicar mas, se usa igual que siempre, sistema c# puro
        public UnityAction<int, bool, string> myunityactionthreeparamVar;  // sistema c# de unity

        
        private void Start()
        {
            // asignar  // el de unityaction es lo mismo
            actionvar = printMessage;
            actionvar += printMessage;  // reminder cuando usa el += es multicast
            // llamar cualqueira de las dos formas  // action o unityaction es igual aqui
            actionvar();
            actionvar.Invoke();
           
        }
        private void printMessage()
        {
            Debug.Log("helloworld!");
        }
    }
}
