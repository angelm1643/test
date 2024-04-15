using UnityEngine;

namespace Course.OrganizacionProyecto
{
    [CreateAssetMenu(fileName = "New Config", menuName = "ScriptableObjects/Config", order = 1)]
    public class ConfigSO : ScriptableObject
    {
        [Header("General")]
        public int maxPlayers = 4;
        public float maxSpeedMovement = 1.2f;

        [Header("Animation")]
        public float fadeInTime = 1.5f;
        public float fadeOutTime = 3;
    }
}
