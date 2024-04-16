using UnityEngine;

namespace course.PatronesDiseno.Strategy
{
    public class bow : MonoBehaviour, IWeapon
    {
        public GameObject arrowPrefab;
        public Transform spawnTransform;
        public void attack()
        {
            Instantiate(arrowPrefab, spawnTransform.position, spawnTransform.rotation);
        }
    }
}
