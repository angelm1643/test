using System.Collections.Generic;
using UnityEngine;

namespace course
{
    public class classQueque : MonoBehaviour  // el queue es similar al stack pero este se comporta mas a manera de "fila" en lugar de "monticulo" el primero que entre es el primero que salga
    {
        [Header("content")]
        public GameObject[] mycontent;

        [Header("queue")]
        public Queue<GameObject> PlayerQueue;

        private void Start()
        {
            //int
            PlayerQueue = new Queue<GameObject>();
            //add
            for (int i = 0; i < mycontent.Length; i++)
            {
                PlayerQueue.Enqueue(mycontent[i]);
            }
            //remove
            GameObject mygameObject = PlayerQueue.Dequeue();
            //contains
            bool contains = PlayerQueue.Contains(mygameObject);

            //ammount
            int ammount = PlayerQueue.Count;
            //clear
            PlayerQueue.Clear();
        }
    }
}
