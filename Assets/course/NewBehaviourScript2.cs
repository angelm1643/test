//parte 2, hacer la parte 1 en caso de olvidar algo

//peque?o respaso a temas de hoy

//aritmetica:
// +: suma
// -: resta
// *: multiplicacion
// /: division
//---------------------------------------------------------------------------------------------------------------------------
// -equaciones:
//> mayor
//< menor
//= valor asignado 
//== igual
//>= mayor o igual
//<= menor o igual
//!=  distinto
//---------------------------------------------------------------------------------------------------------------------------
//operadores condicionales: ((if, while, for, else, &&, ||))
// if:"si esque"
// while: mientras tanto
// for: por una x condicion
// else: en el caso contrario
// &&: significa AND y se usa para SUMAR otra variable para una condicion, esta y esta
// ||: significa or para agregar otra variable para la condicion pero, sin sumarlas, esta o esta
// $: conecta y transforma valores a strings "texto" de manera rapida, se usa con llaves asi: $"hoy cumplo {a?os} y quiero verte en {lugar}, pls"
//---------------------------------------------------------------------------------------------------------------------------
// - METODOS DE BIBLIOTECA DE UNITY
// .this: (significa este script en concreto
// .transform: (significa posicion escala y rotacion de un objeto 3D
// .gameobject: (significa hacer referencia al objeto mismo en cuestion
// .tostring o .toint: (significa transformar la variable de un tipo de valor a string o int dependiendo de cual uses
// .getComponent (significa pedir otro componente por ej de referencia
//---------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------

using UnityEngine;

namespace course
{
    public class NewBehaviourScript2 : MonoBehaviour
    {
        // fijemos valores que se usaran en toda la funcion hecha debajo
        int myint;
        bool mybool;
        string mystring;

        private void Start()
        {
            // operadores: aritmeticos suma resta multiplicacion y division basicos
            myint = 2 + 2;
            myint = 2 - 2;
            myint = 2 * 2;
            myint = 2 / 2;
            myint = 2 / 2;
            // operadores: de asignacion lo mismo pero usando una variante creada en la equiacion
            myint += 2;
            myint -= 2;
            myint *= 2;
            myint /= 2;

            // operadores: relacionales 
            mybool = 2 > 1;  // si 2 es mayor a 1 esto da verdadero
            mybool = 2 < 1;  // si 2 es menor a 1 esto da verdadero
            mybool = 2 == 1;  // si 2 es igual a 1 esto da verdaero
            mybool = 2 >= 1;  // si 2 es mayor o igual a 1 esto da verdaero
            mybool = 2 <= 1;  // si 2 es menor o igual a 1 esto da verdaero
            mybool = 2 != 1;  // si 2 distinto a 1 esto da verdaero

            // operadores: logicos 
            mybool = 2 == 2 || 4 == 4;
            mybool = 2 == 2 && 4 == 4;
            mybool = !(4 == 4);
            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------
            // clase de hoy, string usado para conectar valores
            // formas de trabajarlo toscas generando basura por asi decirlo
            mystring = "mariano";
            mystring = "mariano" + " " + "sosa";
            int age = 23;
            mystring = "mariano's birthday: " + age.ToString();
            // formas de trabajarlo limpiamente opcion 1
            mystring = string.Format("{0}'s birthday:{1}", "maraino", age); // el mismo resultado que la linea de arriba, format tiene 2 variables, primero pones el orden entre llaves empezando siempre de {0} y luego en la segunda variable pones los valores que estarian alli separado por coma
            // opcion 2
            mystring = $"mariano's birthday: {age}"; // exactamente lo mismo que las dos lineas de arriba al parecer el $ sirve para crear cadenas de texto poniendo tus variables entre llaves ""$"hoy cumplo {a?os} y quiero verte en {lugar}, si""
            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------
            //separar variables en string y con array
            mystring = "24_mariano_rifle";
            string[] characterinfo = mystring.Split('_');
            // characterInfo[0] = "24";
            // characterInfo[1] = "maraiano";
            // characterInfo[2] = "rifle";


            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------
            // next class
        }     
    }
}
// continue in part 3
