using UnityEngine;

namespace course
{
    public class documentation : MonoBehaviour  // pones 3/ juntos para documentar un script, cosas sobre que funcion cumple etc, o una variable
    {
        private void Start()
        {
            int myvalue;
            myvalue = Getid("mariano");
        }
        /// <summary>  // solo poner 3 / y crea esto solo para que lo rellenes
        /// summary: description corta
        /// <remarks>
        /// descripcion mas detallada
        /// </remarks>
        /// </summary>
        /// <param name="CharacterName"> param:descripcion de la variable </param>
        /// <returns>
        /// return: descripcion del tipo de valor que devuelve
        /// </returns>
        private int Getid(string CharacterName)
        {
            return 1;
        }
        
    }
}
