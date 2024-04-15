//parte 4, hacer la parte 3 en caso de olvidar algo
using UnityEngine;

namespace course
{
    //-----------------------------------------------------------------------------------------
    //-----------------------------------------------------------------------------------------
    // tipo array [] conjunto de datos del mismo valor que se pueden almacenar en una variable
    public class NewBehaviourScript4 : MonoBehaviour
    {
        public int[] enemyid = { 100,200,300,400 };   // el public int [] (array icono) puesto asi, deja una lista vacia que se puede rellenar desde el inspector de unity, si pones valores por defecto se representan del 0+ como abajo

        private void Start()
        {
            int myid = enemyid[0]; // 100
            myid = enemyid[3]; // 400

            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------
            //clase conversiones 

            // conversion 
            int mycastint = (int)2.55f; // cast type, best and easyer "solo pon el parentesis con el tipo de valor objetivo, en este caso convertir el 2.55f (float) a int 
            //valores
            Collider mycollider = GetComponent<Collider>();
            BoxCollider myboxcollider;
            // tipo (cast)
            myboxcollider = (BoxCollider)mycollider;
            myboxcollider = mycollider as BoxCollider;
            // conversion (parse)
            string mystringint = "128";
            int myintparsed;
            myintparsed = int.Parse(mystringint);  /// 128
            bool resultparse = int.TryParse(mystringint, out myintparsed); //best 2 pedirle que intente convertirlo y que te avise con un booleano si puede o no puede
            // conversion (enum)
            string mystringEnum = "fire";

            attacktype myenum;
            myenum = (attacktype)System.Enum.Parse(typeof(attacktype), mystringEnum);

            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------
            //clase constructores
            weapon myweapon = new weapon(100);
            myweapon.shoot();

        }
    }

    public class weapon
    {
        int ammo;
        public weapon()
        {
            ammo = 30;
        }
        public weapon(int ammo)
        {
            this.ammo = ammo;
        }
        public void shoot()
        {
            // do smtg
        }
    }
}