// estos dos "//" sirven para agregar notas que no afectan al codigo, muy informativo
//
//                               COSAS BASICAS
// - modificador de acceso
// public: todo el proyecto puede acceder y hace una casilla en el inspector en unity
// private: solo es accesible entrando al script y otros scripts no pueden acceder a el
//---------------------------------------------------------------------------------------------------------------------------
// - tipo de dato
// int: nros enteros (1)
// float: nros con decimales (1.1111f)
// double: nros con decimales mas exactos (1.11111111)
// bool: "true or false" o la casilla de check
//char: un solo caracter, se pone entre comas 'a'
//string: texto y nros
//enum, lista, es para hacer una casilla como lista en el inspector de unity
//array []: coleccion de variables, por ej una lista de nombres, a la que quieres sumarle puntos
//---------------------------------------------------------------------------------------------------------------------------
// - nombre: lo que quieras, recomendado ordenar para evitar errores o perderte en el debug
// - valor por defecto (opcional): agregas " = tal" puede ser modificado y no cambia el script pero si el resultado
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
// while: mientras tanto, repite una accion hasta que se alcanze una condicion
// for: cumple instrucciones una x cantidad de veces
// else: en el caso contrario
// &&: significa AND y se usa para SUMAR otra variable para una condicion
// ||: significa or para agregar otra variable para la condicion pero, sin sumarlas
// $: conecta y transforma valores a strings "texto" o int de manera rapida, se usa con llaves asi: $"hoy cumplo {a?os} y quiero verte en {lugar}, pls"
//---------------------------------------------------------------------------------------------------------------------------
//aritmetica:
// +: suma
// -: resta
// *: multiplicacion
// /: division
//---------------------------------------------------------------------------------------------------------------------------
// - METODOS de la biblioteca de unity 
// .this: (significa este script en concreto o este objeto en el que esta el script depende del contexto
// .transform (significa posicion escala y rotacion de un objeto 3D
// .gameobject (significa hacer referencia al objeto mismo en cuestion lo pide en una casilla del inspector
// .tostring o .toint (significa transformar la variable de un tipo de valor a string o int dependiendo de cual uses, (puedes usar el $)
// .getComponent (significa pedir otro componente por ej de referencia en una casilla del inspector
//---------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------
// (lo azul es lo del codigo, lo celeste sale de alguna biblioteca (namespace) y lo blanco son cosas asignadas por el usuario como nombres o codigo que no es valido)
using UnityEngine;   //estos son namespaces, son bibliotecas de otras partes, en este caso usando la que aporta el propio unity

namespace course     // creamos nuestro propio namespace (biblioteca) a la que podremos acceder de igual froma desde otro projecto tambien ayuda a no mezclar cosas y conseguir errores por nombres similares al momento de crear otros scripts
{
    public class basicos1 : MonoBehaviour    // lo azul, el primero es el script y el segundo sale de la biblioteca de unity, es otro script que estamos asimilando
    {
        public string playername = "maraino";
        public int age = 23;
        // se compone de el tipo, el valor, el nombre que le das, el = le asigna un valor que pongas y finalmente se cierra la operacion con ; antes de bajar de reglon

        // - avanzado tipos de datos (valor) (datos comunes)
        public string mystring;  //texto 123
        public int myint;        // 1
        public float myfloat;    // 1.1111
        public double mydouble;  // 1.11111111
        public bool mybool;      // yes or no
        public char mychar;      // 'a'
        public Vector2 mystructvector;    // vector2 o vector3 para dar valores de x cosa, similar a las cordenadas 3d, vector 2 da 2 vector 3 da 3, depende de cuantos nesesites
        public Quaternion mystructquaternion;   // no idea

        // - avanzado tipos de datos (referencia) (referencias brindadas por el namespace de unity)
        public Transform myclasstransform;  // referencia a la posicion escala y rotacion de x objeto
        public GameObject myclassgameObject;  // referencia a x objeto en si
        public basicos1 myclass;  // referencia a este u otro script
        // ---------------------------------------------------------------------------------------------------------------------------
        // ---------------------------------------------------------------------------------------------------------------------------

        // operadores = funciones
        private void Start()    // funcion "start", permite ejecutar codigo cuando das play, por ej crear funciones
        {
            // -tipos de datos (valor)
            myint = 5;
            myfloat = 2.5f;
            mydouble = 0.0001;
            mybool = true;
            mychar = 'M';
            mystructvector = new Vector3(1,2,3);    //valor que tiene vectores (axis) x1"lado" y2"altura" z3"profundidad", el new sirve para crear una nueva "instancia" o version paralera de algo (que no efecte a otras versiones)
            mystructquaternion = new Quaternion(1,2,3,4);

            // -tipos de datos (referencia)
            myclasstransform = this.transform;    // con esto se OBTIENE el transform.... de un objeto que tiene puesto este script con el this" (ubicacion rotacion y escala)
            myclassgameObject = gameObject;    // se obtiene una referencia al objeto, "en caso de this del objeto al que esta puesto este codigo" 
        }

    }
}
// continue en part 2
