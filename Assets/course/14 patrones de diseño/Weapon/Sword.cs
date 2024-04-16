using UnityEngine;

namespace course.PatronesDiseno.Strategy
{
    public class Sword : MonoBehaviour, IWeapon
    {
        private int _damage = 10;
        private float _attackRadius = 200f;
        public void attack()
        {
            var hits = Physics2D.OverlapCircleAll(transform.position, _attackRadius);
            if (hits[0] != null)
            {
                for (int i = 0; i < hits.Length; i++)
                {
                    var otherDamage = hits[i].GetComponent<IDamage>();
                    otherDamage.DoDamage(_damage);
                }

            }
        }
    }
}
