using System.Collections;
using UnityEngine;

namespace course
{
    public class ForEachWhile : MonoBehaviour
    {
        public int[] WeaponArray;

        private void CheckWeaponAmmo()
        {
            for (int i = 0; i < WeaponArray.Length; i++)
            {
                Debug.Log($"index {i} - ammo:{WeaponArray[i]}");
            }
            foreach (int weaponAmmo in WeaponArray)
            {
                Debug.Log($"index ? - ammo:{weaponAmmo}");
            }
        }
        private IEnumerator fade()
        {
            float alpha = 1;

            while (alpha > 0)
            {
                alpha -= Time.deltaTime * 1;
                yield return null;
            }   
            // do something
        }
    }
}
