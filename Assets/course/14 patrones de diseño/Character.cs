using System;
using UnityEngine;

namespace course.PatronesDiseno.Strategy
{
    public class Character : MonoBehaviour
    {
        public GameObject weaponPrefab;
        private IWeapon _weapon;

        private void Start()
        {
            EquipWeapon();
        }
        private void EquipWeapon()
        {
            _weapon = Instantiate(weaponPrefab, transform).GetComponent<IWeapon>();
            if (_weapon == null)
                throw new Exception($"prebaf {weaponPrefab.name} does not implement iweapon interface");

        }
        public void DoDamage(int damage)
        {
            Debug.Log("Receive Damage", this);
            throw new System.NotImplementedException();
        }
        private void attack()
        {
            _weapon.attack(); 
        }
    }
}
