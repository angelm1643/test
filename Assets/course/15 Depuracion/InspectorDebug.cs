using UnityEngine;

namespace Course.Depuracion
{
    public class InspectorDebug : MonoBehaviour
    {
        public int publicVar;
        private int privateVar;
        protected int protectedVar;
        [Space]
        [HideInInspector]public bool publicHideVar;
        [SerializeField]private bool privateSerializeVar;
    }
}
