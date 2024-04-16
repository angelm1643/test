using UnityEngine;

namespace course.PatronesDiseno.template
{
    public abstract class Character : MonoBehaviour
    {
        protected int health = 100;

        public void attack()
        {
            if (CanAttack())
            {
                DOAttack();
            }
        }
        protected abstract bool CanAttack();
        protected abstract void DOAttack();
        public void ReciveDamage(int damage)
        {
            bool isdead = applydamage(damage);
            DamageReceived(isdead);
        }
        private bool applydamage(int damage)
        {
            health -= damage;
            if (health > 0)
            {
                return false;
            }
            health = 0;
            return true;
        }
        protected abstract void DamageReceived(bool isdead);
    }
}
