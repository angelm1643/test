using UnityEngine;
using UnityEngine.Events;
using TMPro;

namespace course.PatronesDiseno.observer
{
    public class Player : MonoBehaviour
    {
        private int _health = 100;

        public UnityEvent<int> onupdatehealth;
        public int Health
        {
            get 
            { 
                return _health; 
            }
            set
            {
                _health = value;
                onupdatehealth.Invoke(_health);
            }
        }

        public void ApplyDamage(int damage)
        {
            Health -= damage;
        }
    }
}
