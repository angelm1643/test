using UnityEngine;

namespace course
{
    public class ifclass : MonoBehaviour
    {
        // if/ else
        public bool canattack;
        private void attack()
        {
            if (canattack) 
            {
                Debug.Log("attack");
            } 
            else
            {
                Debug.Log("No Ammo");  // esta fue la version larga
            }
            Debug.Log(canattack ? "attack" : "No Ammo");  // operador ternario, version corta de escribir if y else (? significa if) ( : significa else)
            int id = canattack ? 24 : -1;

            if(canattack) Debug.Log("attack");  // posible con el if tab tab
        }
        public int CurrentAmmo;
        public int TotalAmmo;

        private void CheackAmmo()
        {
            if (CurrentAmmo > 0)
            {
                //shoot
            }

            if (TotalAmmo == 0 || CurrentAmmo <= 0) // si total ammo es igual a 0 "o" si current ammo es menor o igual a 0
            {
                //requiere ammo
            }
        }
        public SphereCollider ShieldCollider;

        private void defense()
        {
            if (ShieldCollider != null)
            {
                // use shield
            }
            if (ShieldCollider)
            {
                // use shield
            }
        }
    }
    
}
