using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace course
{
    public class CLassStack : MonoBehaviour  // el stack se comporta a manera de monticulo, como tener un mazo de cartas y sacar el ultimo de arriba
    {
        [Header("content")]
        public GameObject[] mycontent;

        [Header("Stack")]
        public Stack<GameObject> CardsStack;

        private void Start()
        {
            //int
            CardsStack = new Stack<GameObject>();
            //add
            for (int i = 0; i < mycontent.Length; i++)
            {
                CardsStack.Push(mycontent[i]);  //usando un push colocas cosas dentro
            }
            //return first and remove
            GameObject mygameObjectPop = CardsStack.Pop(); // el pop lo que hace es agarrar el ultimo objeto arriba del todo y scarlo del stack, osea removerlo

            //return first
            GameObject mygameObjectPeek = CardsStack.Peek(); // el peek es lo mismo pero agarra el primer objeto y solo lo lee, sabe que esta alli pero no lo remueve

            //contains
            bool contains = CardsStack.Contains(mygameObjectPeek);

            //ammount
            int amoount = CardsStack.Count;

            //clear
            CardsStack.Clear();
        }
    }
}
