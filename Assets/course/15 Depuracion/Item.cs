using UnityEngine;

namespace Course.Depuracion
{
    [RequireComponent(typeof(SphereCollider))]
    public class Item : MonoBehaviour
    {
        public bool showDebug;

        [Header("Data")]
        public string title;
        public Texture texture;

        private SphereCollider sphereCollider;
        public SphereCollider SphereCollider
        {
            get
            {
                return sphereCollider;
            }
            set
            {
                sphereCollider = value;
            }
        }

        private int debugValue;

        private void Start()
        {
            Consume();

            ApplyEffect();
        }

        public void Consume()
        {
            debugValue = 5;

            Debug.Log("Consume Item!");

            debugValue = 200;
        }

        public void ApplyEffect()
        {
            debugValue = 500;

            Debug.Log("Apply Effect!");

            debugValue = 999;
        }

        #region Debug

        public void DebugUpdateRadius(float value)
        {
            sphereCollider.radius = value;
        }

        private void OnValidate()
        {
            if (!sphereCollider)
            {
                sphereCollider = GetComponent<SphereCollider>();
            }
        }

        private void OnDrawGizmos()
        {
            if (!showDebug) return;

            var color = new Color(0, 0.5f, 1, 0.1f); // Blue
            Gizmos.color = color;
            Gizmos.DrawSphere(transform.position, sphereCollider.radius);
        }

        //private void OnDrawGizmosSelected()
        //{
        //    var color = new Color(0, 1, 0, 0.1f);
        //    Gizmos.color = color;
        //    Gizmos.DrawSphere(transform.position, colliderSize);
        //}

        #endregion
    }
}
