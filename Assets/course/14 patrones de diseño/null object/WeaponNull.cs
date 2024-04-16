using UnityEngine;

namespace Course.PatronesDiseno.NullObject
{
    public class WeaponNull : Weapon
    {
        public override void Attack(IDamage damageReceiver)
        {
            // Do nothing
        }
    }
}
