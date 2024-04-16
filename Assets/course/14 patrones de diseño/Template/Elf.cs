using UnityEngine;

namespace course.PatronesDiseno.template
{
    public class Elf : Character
    {
        protected override bool CanAttack()
        {
            if (health >= 30)
            {
                return true;
            }
            Debug.Log("i can't attack - i'm too weak");
            return false;
        }
        protected override void DOAttack()
        {
            //ataque
            throw new System.NotImplementedException();
        }

        protected override void DamageReceived(bool isdead)
        {
            if (isdead)
            {
                //game over
            }
        }

    }
}
