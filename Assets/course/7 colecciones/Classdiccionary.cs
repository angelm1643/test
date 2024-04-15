using System.Collections.Generic;
using UnityEngine;

namespace course
{
    public class Classdiccionary : MonoBehaviour // diccionary es lo mismo que list pero con string, sirve por ejemplo para buscar un gameobject  atravez del nombre y mirar datos o cambiarlos asi
    {
        [Header("content")]
        public GameObject[] mycontent;

        [Header("Diccionario")]
        public Dictionary<string, GameObject> characterdiccionary;

        private void Start()
        {
            // inicializar
            characterdiccionary = new Dictionary<string, GameObject>();

            //add, agregar
            for (int i = 0; i < mycontent.Length; i++)
            {
                characterdiccionary.Add(mycontent[i].name, mycontent[i]); //orc
            }

            //remove: remover
            characterdiccionary.Remove("orc");

            //contains: preguntar si contiene
            bool contains = characterdiccionary.ContainsKey("orc");

            //read: leer la informacion con poner el nombre
            GameObject myValue = characterdiccionary["orc"];

            // amount: cantidad
            int ammount = characterdiccionary.Count;

            //clear
            characterdiccionary.Clear();
        }
    }
}
