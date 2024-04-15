using UnityEngine;
//el debug.log sirve para ver los datos en consola, puedes probar y ver cuando se activa cierta funcion y cuantas veces

namespace course
{
    public class AwakeStart : MonoBehaviour
    {
        // el arranque del proyecto y el arranque de la escena
        #region AwakeStart
        // awake: lo primero que se ejecuta, es para hacer los preparativos
        // start: se ejecuta cuando ya esta todo listo, al iniciar la esena
        private void Awake()
        {
            Debug.Log("Awake"); //se usa solo para obtener las referencias, antes de que la esena siquiera comienze,por ej si quieres basar alguna cosa en otro objeto o obtener referencia o informacion para este script
        }

        private void Start()
        {
            Debug.Log("Start"); // el start se ejecuta al inicio, datos como municion etc te interesa ponerlos luego del start
        }
        #endregion
        // datos que se actualizan constantemente
        #region update
        // tipos de update, hay 3, y van en el seguiente orden,
        // "1 fixupdate actualiza las fisicas y colisiones en cada frame, es lo primero que comienza en la parte fisica
        // 2 update actualiza datos generales en cada frame, se actualiza en la parte logica, se usa para actualizar cosas y imputs de teclado o mouse
        // 3ro lateupdate actaliza los demas de la renderizacion etc" se actualiza en el render, normalmente se utiliza por ej para movimientos de camara para que siga al personaje

        private void FixedUpdate()
        {
            Debug.Log("FixUpdate"); // update en tiempo de fisicas, el mas lento
        }

        private void Update()
        {
            Debug.Log("Update"); //update general, en cada frame
        }

        private void LateUpdate()
        {
            Debug.Log("LateUpdate"); //update un poquito mas lenta para el proceso final
        }
        #endregion
        // controla el estado exitencial del objeto, si aparece o no en la esena, si se deshabilita habilita o destruye
        #region OnEnableDisableDestroy
        //OnEnable: se ejecuta entre el awake y el start al principio de todo
        //OnDisable: se ejecuta al final del todo antes de acabar el ciclo
        //OnDestroy: el final, destruye el ciclo y si no se aplica el script se reinicia

        private void OnEnable() // al prender la existencia del objeto o al iniciar la esena
        {
            Debug.Log("OnEnbale");
        }

        private void OnDisable() // al deshabilitar la existencia del objeto
        {
            Debug.Log("OnDisable");
        }

        private void OnDestroy() // al finalizar la esena, al cambiar la esena o borrar se destruye el objeto
        {
            Debug.Log("OnDestroy");
        }
        #endregion
        // diferente a disable o enable, esto es cuando el objeto es directamente in visible EN LA CAMARA, pero sigue existiendo en el costado
        #region OnBecame In-Visible
        private void OnBecameVisible()
        {
            Debug.Log("Visible");
        }
        private void OnBecameInvisible()
        {
            Debug.Log("Invisible");
        }

        #endregion
    }
}
