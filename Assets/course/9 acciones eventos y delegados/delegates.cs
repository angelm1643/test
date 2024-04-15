using System.Collections.Generic;
using UnityEngine;

namespace course  // repaso: deleate es el sistema general para comunicaciones entre varaibles y funciones normalmente se usan los events para todo
    // pero funciones como callback y demas requieren usar delegates
{
    public class delegates : MonoBehaviour  // un delegate es una funcion con variables dentro o varias variables, se usa mucho en base de datos etc, o tambien se puede usar para avisar cosas al jugador como si tiene internet o no, basicamente tiras otras variables dentro de esta funcion para poder usarla y cosas similares
    {
        //void
        public delegate void mydelegate();  // creas el delegate
        public mydelegate mydelegatevar;  // creas una variable para nombrar a ese delegate luego en void start simplemente le asignas la variable que gustes (mydelegatevar = printMessage) asi)
        //return
        public delegate int mydelegateint();
        public mydelegateint mydelegateintvar;
        //params  // poder pasar parametros
        public delegate void mydelegateoneparam(string mystring);
        public mydelegateoneparam mydelegateoneparamvar;
        //multicast // forma de poder meterle mas de una funcion
        public delegate void mydelegatemulticast();
        public mydelegatemulticast mydelegatemulticastvar;
        //callback // es como una devolucion de una llamada, devuelve un valor
        public delegate void mydelegatecallback(bool sucess);
        public mydelegatecallback mydelegatecallbackvar;

        private void Start()
        {
            mydelegatevar = printmessage;
            //mydelegatevar(); // forma alternativa de ejecutarlo
            //mydelegatevar.Invoke();

            //return
            mydelegateintvar = getweaponid;
            int myweapon;
            // myweapon = mydelegateintvar();
            //myweapon = mydelegateintvar.Invoke();

            //params
            //mydelegateoneparamvar = printmessagewithvalue;
            //mydelegateoneparamvar("world");
            //mydelegateoneparamvar.Invoke("world");

            //multicast
            mydelegatemulticastvar += printmessage;
            mydelegatemulticastvar += changeweapon;
            mydelegatemulticastvar += heal;
            //ejecutar
            mydelegatemulticastvar();
            mydelegatemulticastvar.Invoke();

            //callback
            mydelegatecallbackvar = requestcompleted;
            conectionrequest(mydelegatecallbackvar); 

        }
        private void printmessage()
        {
            Debug.Log("hello world");
        }
        private void printmessagewithvalue(string message)
        {
            Debug.Log($"hello {message}");
        }
        private int getweaponid()
        {
            return 5;
        }
        private void changeweapon()
        {
            Debug.Log("change weapon!");
        }       
        private void heal()
        {
            Debug.Log("heal!");
        }
        bool conectionRdy = true;
        private void conectionrequest(mydelegatecallback callback)
        {
            if (conectionRdy)
            {
                callback(true);
            }
            else
            {
                callback(false);
            }
        }
        private void requestcompleted(bool success)
        {
            Debug.Log($"conectionn ready:{success}");

        }
    }
}
