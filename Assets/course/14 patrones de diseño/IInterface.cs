using UnityEngine;

namespace course.PatronesDiseno.Strategy
{
    public interface IWeapon
    {
       void attack();
    }
    public interface IDamage
    {
        void DoDamage(int damage);
    }
}
