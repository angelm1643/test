using UnityEngine;
using TMPro;

namespace course.PatronesDiseno.observers
{
    public class PlayerUI : MonoBehaviour
    {
        public TextMeshProUGUI healthtxt;

        public void updatehealth(int health)
        {
            healthtxt.text = $"health:{health}";
        }
    }
}
