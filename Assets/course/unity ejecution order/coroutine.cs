using System.Collections;
using UnityEngine;

namespace course
{
    public class coroutine : MonoBehaviour
    {
        #region corroutine start
        //start
        private void Start()
        {
            //StartCoroutine("CallCorroutine");

            StartCoroutine(CallCorroutineWithParams(2.5f, 100, "test"));

            #region stop
            StopAllCoroutines();
            #endregion
        }
        #endregion

        #region IEnumerator
        private IEnumerator CallCorroutine()
        {
            yield return null;
        }
        // parametros
        private IEnumerator CallCorroutineWithParams(float myfloat,int myint,string mystring)
        {
            yield return null;
        }
        #endregion
        public string reminder = ("estudiar esta shit, coroutine y quaterion,");
    }
}
