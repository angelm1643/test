using UnityEngine;

namespace Course.PatronesDiseno.ServiceAdapter
{
    public class GameServiceInstaller : MonoBehaviour
    {
        public PlayerPrefsAdapter saveSystem;
        private void Awake()
        {
            GameServiceLocator._Instance.RegisterService<IDataSaver>(saveSystem);
        }
    }
}
