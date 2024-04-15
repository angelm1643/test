using UnityEngine;

namespace course
{
    public class EnemyOrc : ClassEnemy  // la convertimos en clase hijo, hereda de la clase padre, remplazamos monobehaviour con la anterior clase que creamos para usar sus propiedades
    {
        public override void attack() // override sirve para llamar a algo que contenga virtual en la clase padre desde la clase hijo para poder rescribirla
        {
            damage = 99;
            base.attack();
            Debug.Log("wuga wuga waa");
        }

        public override void defense()
        {
            throw new System.NotImplementedException();
        }
    }
}
