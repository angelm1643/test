using Course.PatronesDiseno.ServiceAdapter;
using UnityEngine;

namespace course.PatronesDiseno.Facade
{
    public class GameManager : MonoBehaviour
    {


        //private SaveSystem saveSystem;  // 
        //private IDataSaver DataSaver; // para usar el game service

        //private void Start()
        //{
        //saveSystem = new SaveSystem(new PlayerPrefsAdapter());

        // in unity save system case

        //PlayerPrefsAdapter._Instance.GetInt; // llamamos a la funcion que nesesitemos

        //DataSaver = GameServiceLocator._Instance.GetService<IDataSaver>();
        //DataSaver.GetInt; //get string exetera puedes usar esas funcionalidades 

        //}

        public BattleFacade battleFacade;  // caso para battle facade

        public void BattleStart()
        {
            battleFacade.BattleStart();
        }
        public void BattleEnd()
        {
            battleFacade.BattleEnd();
        }
    }
}
