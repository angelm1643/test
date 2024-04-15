//parte 3, hacer la parte 2 en caso de olvidar algo
using UnityEngine;

[System.Serializable]   // crea una pesta?a para poder acceder a cierta configuracion en el inspector, recordar
public struct playerdataref
{
    public string name;
    public int health;
    public bool isdead;
    public int ammo;
}
public enum attacktype  // asi mismo es como haces una lista, enum es la funcion "lista" en otros lenguajes
{
    none,
    fire,
    ice,
    sword,
    punch
}

namespace course // namespace que puedes llamar con el "using" al inicio
{
    // --------------------------------------------------------------------------------
    // --------------------------------------------------------------------------------
    //clase disparar arma
    public class NewBehaviourScript3 : MonoBehaviour
    {
        
        int ammo;

        private void start()
        {
            shoot(weapontype: 2);  // 10
            changeplayeridwithout(out myid); // 20
            changeplayeridwithref(ref myid); // 30
        }
        
        public void shoot(int amountbullets = 5, int weapontype = 0)
        {
            // disparar

            ammo -= amountbullets;
            myid = getplayerid();
        }

        int myid;

        private void changeplayeridwithout(out int id)
        {
            // do something
            id = 20;
        }
        private void changeplayeridwithref(ref int id)
        {
            //do something
            id = 30;
        }


        private int getplayerid()
        {
            // do something
            return 10;
        }
        // --------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------
        // clase usar habilidad  

        public attacktype attacktypeEnum = attacktype.sword;    // desde el "=" es opcional simplemente el valor por defecto que yo elijo

        //-----------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------
        //clase tipo struct

        public string playername;
        public int playerhealth;
        public bool playerisdead;


        public playerdataref playerdata;

        private void Start()
        {
            playerdata.name = "mariano";
            playerdata.health = 100;
            playerdata.isdead = false;
        }

        private void changeinfo(playerdataref data)  // pedimos directamente los datos de la structur en lugar de poner "(string name, int health, bool isdead)" es mas facil cuando tengamos que llamarlo cientos de veces a futuro
        {

        }
    }
}



// continue in part 4