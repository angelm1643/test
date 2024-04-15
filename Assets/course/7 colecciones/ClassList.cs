using System.Collections.Generic;
using UnityEngine;

namespace course
{
    public class ClassList : MonoBehaviour  // una lista consiste en algo que hace un array dinamico al mismo tiempo que los cambios ocurren en tu juego, por ejemplo para agrupar a todos los enemigos que van spawneando, y asi poder hacer acciones como eliminarlos a todos a la vez etc
    {
        [Header("content")]
        public int[] mycontent;

        [Header("lsit")]
        public List<int> weaponsList;


        private void Start()
        {
            //inicializacion
            weaponsList = new List<int>();
            // add, se puede utilizar for o addRange
            for (int i = 0; i < mycontent.Length; i++) // ejemplo for
            {
                weaponsList.Add(mycontent[i]); // ejemplo addcontent
            }
            weaponsList.AddRange(mycontent);
           
            //remover elementos de la lista
            weaponsList.Remove(mycontent[2]);

            //read, ver la info
            int tempvalue = weaponsList[2];

            // ammount, si quiero saber la cantidad que tiene
            int amoount = weaponsList.Count;  // count cuenta la cantidad, es el equivalente a length pero para listas

            //clear, borrar toda la lista
            weaponsList.Clear();
        }
    }
}
