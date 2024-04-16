using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace course
{
    [HelpURL("www . reference url . com")] //sirve para poner un url de referencia en el script accesible desde unity
    [RequireComponent(typeof(BoxCollider), typeof(Rigidbody))] // requirecomponent sirve para forzar a unity a agregar los componentes nesesario junto con el script, se pone antes de la class 
    public class atributos : MonoBehaviour
    {
        #region atributos
        [Header("status")]  // poner subtitulos en el inspector
        public string DisplayName;
        [Space]  // separar en el inspector
        public int health;
        public int mana;
        [Space] [Tooltip("chek if its dead")]
        public bool IsAlive;

        [System.Serializable] // crea una pesta?a desplegable, solo valido para structs o enum
        public struct RPGstatus  // lista de varaibles
        {
            public int fuerza;
            public int Destreza;
            public int Mente;
            public int inteligencia;
            public int aguante;
        }
        [System.Serializable]
        public enum Magic  // asi mismo es como haces una lista, enum es la funcion "lista" en otros lenguajes
        {
            none,
            fire,
            ice,
            wind,
            earth
        }

        [Header("references")]
        [Tooltip("click and drag the capsule colider u need")]  // poner una explicacion cuando pones el mouse sobre la opcion en el inspector
        public CapsuleCollider capsulecollider;
        #endregion
        #region RangeWeapon
        [Header("ShootingWeaponVariables")]
        [Range(1f, 5.0f)]
        public float ShootSpeed;
        [Range(1, 10)]
        public int ShootRate;
        [Min(2.5f)]
        public float BulletSpeed;
        [Min(1)]
        public int BulletPerShoot;
        #endregion
        #region note
        [TextArea(1, 2)]
        public string description;
        [Multiline(10)]
        public string note;
        #endregion
        #region serialize
        [SerializeField]  // muestra en inspector atributos privados
        private bool CanShoot;
        [HideInInspector] // esconde del inspector atributos publicos
        public bool CanRun;
        #endregion
        #region contextMenu
        [ContextMenu("execute")]
        private void PrintExecute()
        {
            Debug.Log("EXECUTE");
        }
        [ContextMenuItem("get a random scale", "executerandomscale")]
        public float randomscale;
        private void Executerandomscale()
        {
            randomscale = Random.Range(0, 10f);
        }
        #endregion
        
        #region AwakeStart  for getcomponent example
        private BoxCollider boxcollider;
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        private Rigidbody rigidbody;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword

        private void Awake()
        {
            boxcollider = GetComponent<BoxCollider>();
            rigidbody = GetComponent<Rigidbody>();
        }
        private void Start()
        {
            boxcollider.enabled = true;
            rigidbody.isKinematic = false;
        }
        #endregion
    }
}
