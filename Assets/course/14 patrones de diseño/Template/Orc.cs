using UnityEngine;

namespace course.PatronesDiseno.template
{
    public class Orc : Character
    {
        protected override bool CanAttack()
        {
            return true;
        }
        protected override void DOAttack()
        {
            //attack
        }

        protected override void DamageReceived(bool isdead)
        {
            if (isdead)
            {
                //Drop Item or currency
                return;
            }
            Debug.Log("HA HA HA!");
        }

    }
}
