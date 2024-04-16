using UnityEngine;

namespace Course.PatronesDiseno.NullObject
{
    public class Weapon : MonoBehaviour
    {
        private int _damage = 10;

        public virtual void Attack(IDamage damageReceiver)
        {
            damageReceiver.DoDamage(_damage);
        }
    }
}
